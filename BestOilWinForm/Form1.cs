using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BestOilWinForm
{
    public partial class Form1 : Form
    {
        public double TotalPriceforCafe { get; set; }
        public double TotalPriceforOil { get; set; }
        public double TotalSalary { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "Name";

            List<Oils> oils = new List<Oils>
            {
                new Oils
                {
                     Name="Ai-92",
                      Price=0.90
                },
                new Oils
                {
                    Name="Ai-95",
                    Price=1.25
                },
                new Oils
                {
                    Name="Dizel",
                     Price=0.60
                }

            };
            Cafe hotdog = new Cafe
            {
                Name = "Hot-Dog",
                Price = 3.5
            };
            Cafe cola = new Cafe
            {
                Name = "Cola",
                Price = 1.0
            };
            Cafe hamburger = new Cafe
            {
                Name = "Hamburger",
                Price = 3.0
            };
            Cafe Free = new Cafe
            {
                Name = "Hot-Dog",
                Price = 4.0
            };
            comboBox1.DataSource = oils;

            HotDogTextBox.Text = hotdog.Price.ToString();
            colatxtbox.Text = cola.Price.ToString();
            Hamburgertxtbox.Text = hamburger.Price.ToString();
            Freetxtbox.Text = Free.Price.ToString();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var oilsp = comboBox1.SelectedItem as Oils;
            textBox1.Text = oilsp.Price.ToString();

        }

        private void LitrtextBox_TextChanged(object sender, EventArgs e)
        {
            var oil = comboBox1.SelectedItem as Oils;
            var result = double.Parse(LitrtextBox.Text) * oil.Price;
            //Meblegtextbox.Text = result.ToString();
            oiltotallbl.Text = result.ToString();
            TotalPriceforOil = result;
            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();

        }

        private void Meblegtextbox_TextChanged(object sender, EventArgs e)
        {
            var oil = comboBox1.SelectedItem as Oils;
            var result = double.Parse(Meblegtextbox.Text) / oil.Price;
            //LitrtextBox.Text = result.ToString();
            oiltotallbl.Text = result.ToString();
            TotalPriceforOil = double.Parse(Meblegtextbox.Text);
            TotalSalary += TotalPriceforOil;
            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();



        }

        private void Litrradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            Meblegtextbox.Enabled = false;
            LitrtextBox.Enabled = true;
        }

        private void Meblegradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            LitrtextBox.Enabled = false;
            Meblegtextbox.Enabled = true;
        }

        private void HotDogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            HotDogCount.Enabled = true;
        }

        private void Hamburgercheckboc_CheckedChanged(object sender, EventArgs e)
        {
            HhamburgerCount.Enabled = true;
        }
        ///
        private void Freecount_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(Freetxtbox.Text) * double.Parse(Freecount.Text);
            TotalPriceforCafe += result;
            CafeTotalLabel.Text = TotalPriceforCafe.ToString();
            TotalSalary += TotalPriceforCafe;
            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();




        }

        private void colocount_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(colatxtbox.Text) * double.Parse(colocount.Text);
            CafeTotalLabel.Text += result;
            TotalPriceforCafe += result;
            CafeTotalLabel.Text = TotalPriceforCafe.ToString();
            TotalSalary += TotalPriceforCafe;

            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();



        }

        private void HotDogCount_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(HotDogTextBox.Text) * double.Parse(HotDogCount.Text);
            CafeTotalLabel.Text += result;
            TotalPriceforCafe += result;
            CafeTotalLabel.Text = TotalPriceforCafe.ToString();
            TotalSalary += result;
            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();


        }

        private void HhamburgerCount_TextChanged(object sender, EventArgs e)
        {
            var result = double.Parse(Hamburgertxtbox.Text) * double.Parse(HhamburgerCount.Text);
            CafeTotalLabel.Text += result;
            TotalPriceforCafe += result;
            CafeTotalLabel.Text = TotalPriceforCafe.ToString();
            TotalSalary += result;
            TotalSalaryy.Text = (TotalPriceforOil + TotalPriceforCafe).ToString();


        }

        private void CocoColacheckbox_CheckedChanged(object sender, EventArgs e)
        {
            colocount.Enabled = true;
        }

        private void kartofFreecheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Freecount.Enabled = true;
        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Buybtn_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();

            // Get an XGraphics object for drawing
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Create a font
            XFont font = new XFont("Verdana", 20, XFontStyle.BoldItalic);

            // Draw the text
            gfx.DrawString($@"=======Best Oil======== ", font, XBrushes.Black,
              new XRect(0, 0, page.Width, page.Height),
              XStringFormats.TopCenter);
            gfx.DrawString($@"Total Cafe Amount : {oiltotallbl.Text} Azn", font, XBrushes.Black,
  new XRect(10, 20, page.Width, page.Height),
  XStringFormats.TopLeft);
            gfx.DrawString($@"Total Oil Amount : {CafeTotalLabel.Text}  Azn", font, XBrushes.Black,
  new XRect(10,40, page.Width, page.Height),
  XStringFormats.TopLeft);
            gfx.DrawString($@"Total Price   : {TotalSalaryy.Text}   Azn", font, XBrushes.Black,
new XRect(10, 60, page.Width, page.Height),
XStringFormats.TopLeft);
            // Save the document...
            const string filename = "HelloWorld.pdf";
            document.Save(filename);
            // ...and start a viewer.
            Process.Start(filename);
        }
    }
}
