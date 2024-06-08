using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        int? count = 1;
        private void bt_next_Click(object sender, EventArgs e)
        {
            Date = DateTime.Now.ToString("d/M/yyyy");
            date = DateTime.Now.ToString("T");
            label4.Text = Date;
            label5.Text = date;
            count++;
            label2.Text = count.ToString();
            if (count >= 10)
            {
                label2.Location = new Point(99, 140);
            }
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                count = null;
            }
            count = 1;
            label2.Text = count.ToString();
            label2.Location = new Point(112, 140);
            label9.Text = "";
            textBox1.Text = "";
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
        static void ghitext(Form1 form)
        {

            var filename = "danhsachsdt.txt";
            string contentfile = form.textBox1.Text + " | " + DateTime.Now.ToString("g");
            var directory_mydoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fullpath = Path.Combine(directory_mydoc, filename);

            if (File.Exists(fullpath))
            {
                // File đã tồn tại thêm sdt
                File.AppendAllText(fullpath, contentfile + "\r\n");
            }
            else
            {
                // tạo mới vì chưa tồn tại file
                File.WriteAllText(fullpath, contentfile);
            }
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            ghitext(this);
            label9.Text = textBox1.Text;
            Date = DateTime.Now.ToString("d/M/yyyy");
            date = DateTime.Now.ToString("T");
            label4.Text = Date;
            label5.Text = date;
            PrintPanelExample example = new PrintPanelExample();
            example.PrintPanel(panel1);
             count++;
             if (count >= 10)
             {
             label2.Location = new Point(99, 140);
             }
                label2.Text = count.ToString();
                textBox1.Text = "";
                label9.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = Date;
            label5.Text = date;
            label9.Text = "";
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
