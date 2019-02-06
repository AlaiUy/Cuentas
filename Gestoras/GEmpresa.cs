using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aguiñagalde.SQL;
using System.Data.SqlClient;
using Aguiñagalde.Entidades;
using Aguiñagalde.Tools;
using System.Net.Mail;
using System.Data;
using System.ComponentModel;
using System.Reflection;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Net;
using Aguiñagalde.Reportes;

namespace Aguiñagalde.Gestoras
{
    public class GEmpresa
    {

        private List<string> _Frases = new List<string>();

        private void getFrases()
        {
            XDocument Doc;
            try
            {


                Doc = XDocument.Load("//SERVIDOR/Actualizaciones/CTAManager/frases.xml");
                foreach (XElement Node in Doc.Descendants("title"))
                {
                    _Frases.Add(Node.Value);
                }


            }
            catch (Exception)
            {

            }
            finally
            {
                if (_Frases.Count < 1)
                    _Frases.Add("Que tengas un buen dia, que sea el mejor posible.");
            }
        }

        public string ObtenerFrase()
        {
            Random Ran = new Random();
            return _Frases[Ran.Next(1, _Frases.Count - 1)];
        }




        public void EnviarCorreo(string xPara, string xAsunto, string xMensaje, Attachment xAdjunto)
        {

            Usuario User = GCobros.getInstance().Caja.Usuario;

            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(xPara);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = xAsunto;
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            // mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = xMensaje;
            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress(User.Email);
            if (xAdjunto != null)
                mmsg.Attachments.Add(xAdjunto);




            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials = new System.Net.NetworkCredential(User.Email, User.PassEmail);

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            //cliente.Port = 587;
            //cliente.EnableSsl = true;


            cliente.Host = User.EmailHost; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                throw ex;
            }
        }

        public void EnvioECMensual(List<int> Clientes)
        {
            decimal cotizacion = GCobros.getInstance().Caja.Cotizacion;
            string idCliente = "";
            string xArchivo = "";

            try
            {
                foreach (int xCodcliente in Clientes)
                {
                    idCliente = xCodcliente.ToString();
                    EstadoCuenta Temporal = GCliente.Instance().GenerarEstadoCuenta(DateTime.Today.AddMonths(-1), GCliente.Instance().getByID(xCodcliente.ToString(), true), 1);
                    if (Temporal.Pendiente(1) + (Temporal.Pendiente(2) * cotizacion) > 10)
                    {
                        if (Temporal.Cliente.Cobrador != "99" || Temporal.Cliente.Cobrador != "69")
                        {
                            Impresion Im = new Impresion();
                            Im.Imprimir(Temporal, false, "PDF");
                            xArchivo = "C:/EstadosCuentaPDF/EC" + Temporal.Cliente.IdCliente + ".pdf";
                            Attachment xAdjunto = new Attachment(xArchivo);
                            xAdjunto.Name = "Estado de cuenta.pdf";
                            using (MailMessage MailSetup = new MailMessage())
                            {
                                MailSetup.Subject = "Estado de cuenta via E-mail";
                                ClienteActivo C = (ClienteActivo)Temporal.Cliente;

                                MailSetup.From = new MailAddress("rossana@aguinagalde.com.uy");
                                MailSetup.IsBodyHtml = true;
                                string Body = "Adjuntamos automaticamente el estado de cuenta del corriente mes. <br/>";
                                Body = Body + "Sin mas, saludos.<br/><br/>";
                                Body = Body + "Ferreteria y Barraca Aguiñagalde S.A";
                                MailSetup.Body = Body;
                                MailSetup.Attachments.Add(xAdjunto);
                                using (SmtpClient SMTP = new SmtpClient("smtp.gmail.com"))
                                {
                                    SMTP.Port = 587;
                                    SMTP.EnableSsl = true;
                                    SMTP.Credentials = new NetworkCredential("aguinagalderossana@gmail.com", "t0sud4cl4v3");
                                    try
                                    {
                                        MailSetup.To.Add(C.CamposLibres.Email);
                                        SMTP.Send(MailSetup);
                                    }
                                    catch (Exception)
                                    {
                                        if (File.Exists(xArchivo))
                                        {
                                            File.Copy(xArchivo, "C:/EstadosCuentaPDF/EC" + idCliente + ".tmp");
                                        }
                                        else
                                        {
                                            File.Create("C:/EstadosCuentaPDF/EC" + idCliente + ".txt");
                                        }
                                    }
                                }

                            }
                        }
                    }

                }

            }
            catch (Exception)
            {
                File.Create("C:/EstadosCuentaPDF/" + idCliente + ".txt");
            }
        }



        public void EnviarCorreo(IList<string> xPara, string xAsunto, string xMensaje, Attachment xAdjunto)
        {

            foreach (string E in xPara)
            {

                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();


                mmsg.To.Add(E);

                mmsg.Subject = xAsunto;
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

                mmsg.Body = xMensaje;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = false; //Si no queremos que se envíe como HTML


                mmsg.From = new System.Net.Mail.MailAddress("rossana@aguinagalde.com.uy");
                if (xAdjunto != null)
                    mmsg.Attachments.Add(xAdjunto);

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

                cliente.Credentials = new System.Net.NetworkCredential("rossana@aguinagalde.com.uy", "#25106/rossana");

                //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

                //cliente.Port = 587;
                //cliente.EnableSsl = true;

                cliente.Host = "mail.aguinagalde.com.uy"; //Para Gmail "smtp.gmail.com";
                try
                {
                    cliente.Send(mmsg);
                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    throw ex;
                }
            }


        }










        private GEmpresa()
        {

            getFrases();
            SetRegion();



        }

        private void SetRegion()
        {
            System.Globalization.CultureInfo r = new System.Globalization.CultureInfo("es-UY");
            r.NumberFormat.CurrencyDecimalSeparator = ",";
            r.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = r;
        }


        private static GEmpresa _Instance = null;

        public List<string> Frases
        {
            get
            {
                return _Frases;
            }
        }

        public static GEmpresa getInstance()
        {
            if (_Instance == null)
                _Instance = new GEmpresa();
            return _Instance;
        }

        public bool Clave(string xPassWord)
        {
            if (xPassWord == "dc9cb5e08acd25a4a6cdb9e1ddaa4b2c" /* jose */ )

            {
                return true;
            }
            return false;
        }
    }
}
