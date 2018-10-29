using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Diagnostics;



namespace Aguiñagalde.Tools
{
    public class PDF
    {
               
        public void ExportToPdf(DataTable dt)
        {
            
            try
            {
                
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("c://sample.pdf", FileMode.Create));
                document.Open();
                iTextSharp.text.Font font5 = iTextSharp.text.FontFactory.GetFont(FontFactory.HELVETICA, 5);

                PdfPTable table = new PdfPTable(dt.Columns.Count);

                float[] widths = new float[] { 4f, 4f, 4f, 4f,4f,4f };

                table.SetWidths(widths);

                table.WidthPercentage = 100;

                PdfPCell cell = new PdfPCell(new Phrase("Products"));

                cell.Colspan = dt.Columns.Count;

                foreach (DataColumn c in dt.Columns)
                {

                    table.AddCell(new Phrase(c.ColumnName, font5));
                }

                foreach (DataRow r in dt.Rows)
                {
                    if (dt.Rows.Count > 0)
                    {
                        for (int Index = 0; Index < dt.Columns.Count;Index++ )
                        {
                            table.AddCell(new Phrase(r[Index].ToString(), font5));
                        }
                            
                        //table.AddCell(new Phrase(r[1].ToString(), font5));
                        //table.AddCell(new Phrase(r[2].ToString(), font5));
                        //table.AddCell(new Phrase(r[3].ToString(), font5));
                        //table.AddCell(new Phrase(r[4].ToString(), font5));
                        //table.AddCell(new Phrase(r[5].ToString(), font5));
                    }
                } 
                document.Add(table);
                document.Close();
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public void ExportToPdfReport(ReportDocument Report,string xName,bool xAbrir)
        {
            string Path = "C:/EstadosCuentaPDF/";
            string Ex = ".pdf";
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
                if (File.Exists(Path + xName + Ex))
                    File.Delete(Path + xName + Ex);
                Report.ExportToDisk(ExportFormatType.PortableDocFormat, Path + xName + Ex);
                if(xAbrir)
                    Process.Start(Path+xName+Ex);   
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
