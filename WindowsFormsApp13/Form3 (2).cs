using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string ad1, soyad1, numara1, bölüm1,alınanDersler0;

        private void button1_Click(object sender, EventArgs e)//ÖNCEKİ FORMA DÖN
        {
            this.Hide();
            
        }

        private void Form3_Load(object sender, EventArgs e)//HER ŞEYİ BÜYÜK HARFE ÇEVİREREK YAZDIR
        {
           

            if (ad1 != null)
            {
                label1.Text = ad1.ToUpper();
                label6.Text = soyad1.ToUpper();
                label7.Text = numara1.ToUpper();
                label8.Text = bölüm1.ToUpper();
                label9.Text = alınanDersler0.ToUpper();
            }
           
        }
    }
}
