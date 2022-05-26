using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Ejercicios_JSON_AND_PDF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();

            FileStream file = new FileStream("Patos.pdf", FileMode.Create);

            PdfWriter.GetInstance(doc, file);

            doc.Open();
            Font f = FontFactory.GetFont("Helvetica", 15, BaseColor.YELLOW);

            Chunk chunk = new Chunk("Primera linea");
            Chunk chunk2 = new Chunk("Continuación");

            doc.Add(chunk);
            doc.Add(chunk2);

            Phrase phrase1 = new Phrase("Esto es una frase");
            Phrase fresita = new Phrase("Francessssss!!! Qué eres un francesss!!");
            phrase1.Add(chunk2);


            Paragraph p = new Paragraph();

            p.Add(fresita);
            p.SpacingAfter = 20f;

            p.Font = f;

            p.Add(fresita);

            doc.Add(p);

            doc.Add(phrase1);
            doc.Add(fresita);
            doc.Add(p);

            p.IndentationRight = 20f;

            doc.Add(p);

            PdfPTable petable = new PdfPTable(12);
            // no se puede meter chunk en la celda porque es muy básico
            PdfPCell celdita = new PdfPCell(new Phrase("croquetas"));
            celdita.HorizontalAlignment = 1;
            celdita.Colspan = 3;
          

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);

            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);
            petable.AddCell(celdita);


            doc.Add(petable);

            doc.Close();

            string json = "{\"nombre\": \"Pepe\", \"apellido\": \"Mazas\"}";

            Console.Write(json);

        }
    }
}
