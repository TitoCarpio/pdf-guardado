using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace pdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\Oscar Carpio\Desktop\nuevopdf.pdf", FileMode.Create);
           // FileStream fs = new FileStream(@"C: pdfgenerado.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pdw = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            //definir titulo y autor 
            doc.AddAuthor("Tito");
            doc.AddTitle("se logro banda");
            iTextSharp.text.Font standarfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            doc.Add(new Paragraph("HOLA MUNDO "));
            doc.Add(Chunk.NEWLINE);

            doc.Close();
            pdw.Close();

            MessageBox.Show("se genero piola", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
