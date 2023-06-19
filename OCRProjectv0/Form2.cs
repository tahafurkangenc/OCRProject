using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OCRProjectv0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Show();
            Form1 yeniform = new Form1();
            yeniform.Show();
            //button1.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = Clipboard.GetText();
            //button3.Text = "SON 3";
            //label1.Text = "3 saniye içinde";
            Thread.Sleep(1000); // 1 saniye
            //button3.Text = "SON 2";
            //label1.Text = "2 saniye içinde";
            Thread.Sleep(1000); // 1 saniye
            //button3.Text = "SON 1";
           // label1.Text = "1 saniye içinde";
            Thread.Sleep(1000); // 1 saniye
            label1.ResetText();
            label1.Text = "Yapıştırılıyor";
            //button3.Text = "YAPISTIRILIYOR";
            SendKeys.Send(text);
            // button3.Text = "YAPISTIR";
            label1.Text = "Not: Yapıştırma işlemi 3 saniye içinde yapılır";
        }
    }
}
