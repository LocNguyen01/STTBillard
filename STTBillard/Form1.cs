using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STTBillard
{
    public partial class Form1 : Form
    {
        private string Date, date;
        public Form1()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("d/M/yyyy");
            date = DateTime.Now.ToString("T");
        }
        int? count = 0;
        private void bt_next_Click(object sender, EventArgs e)
        {
            count++;
            label2.Text = count.ToString();
            if (count >= 10)
            {
                label2.Location = new Point(49, 120);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count = null;
            }
            count = 0;
            label2.Text = count.ToString();
            label2.Location = new Point(60, 120);
        }

        public class PrintPanelExample
        {
            public void PrintPanel(Panel panel)
            {
                PrintDocument printDoc = new PrintDocument();
                printDoc.PrintPage += (sender, e) =>
                {
                    // Create a bitmap from the panel
                    Bitmap bitmap = new Bitmap(panel.Width, panel.Height);
                    panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));

                    // Draw the bitmap onto the print document
                    e.Graphics.DrawImage(bitmap, 0, 0);
                };

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDoc;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDoc.Print();
                }
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            PrintPanelExample example = new PrintPanelExample();
            example.PrintPanel(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = Date;
            label5.Text = date;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
