using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                count = null;
            }
            count = 0;
            label2.Text = count.ToString();
        }
        
        private void bt_in_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = Date;
            label5.Text = date;
        }
    }
}
