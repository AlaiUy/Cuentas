using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Aguiñagalde.Log
{
    public class Log
    {
        public Log()
        {
            fileName = "C:/log.txt";
        }



        private string fileName;

        public void EscribirLog(string logText)
        {
            try
            {
                using (StreamWriter w = File.AppendText(fileName))
                {
                    w.WriteLine(DateTime.Now.ToString() + " - " + logText);
                }
            }
            catch { }
        }

        public void EscribirLog(Exception ex)
        {
            try
            {
                using (StreamWriter w = File.AppendText(fileName))
                {
                    w.WriteLine("--------------------------------------------------------------------------------");
                    w.WriteLine(DateTime.Now.ToString() + " - EXCEPCION");
                    w.WriteLine("Mensaje: " + ex.Message);
                    w.WriteLine("Lugar: " + ex.Source);
                    w.WriteLine("Sitio: " + ex.TargetSite);
                    w.WriteLine("Excepcion: " + ex.InnerException);
                    w.WriteLine("--------------------------------------------------------------------------------");
                }
            }
            catch { }
        }
    }
}

