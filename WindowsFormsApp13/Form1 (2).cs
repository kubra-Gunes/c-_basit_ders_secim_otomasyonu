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
    public partial class Form1 : Form
    {
       public string ad, soyad, numara, bölüm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)// FORM YÜKLENİRKEN BÖLÜMLERİ COMBOBOXA YAZDIR
        {
            comboBox1.Items.Add("Bilgisayar Mühendislği");
            comboBox1.Items.Add("Tıp ");
            
      }

       private void Form1_KeyDown(object sender, KeyEventArgs e)//ENTER TUŞUNUNA BASILDIĞINDA KAYDET BUTONUNU CLİCKLE
       {
            if (e.KeyCode == Keys.Enter && comboBox1.SelectedItem != null)
            {
                button1_Click(sender, e);
            }
        }
        private void button2_Click(object sender, EventArgs e)//İÇERİKLERİ KAYDEDEN BUTON
        {
           
         
            if (comboBox1.SelectedItem != null)
            {
                ad = textBox2.Text;
                soyad = textBox3.Text;
                numara = textBox1.Text;
                bölüm = comboBox1.SelectedItem.ToString();
               
                

                Form2 form2 = new Form2();
                form2.bölüm0 = comboBox1.SelectedIndex.ToString();
                form2.ad0 = ad;
                form2.soyad0 = soyad;
                form2.numara0 = numara;

                form2.ShowDialog();
            }
            else if(ad=="" || soyad==""|| numara==""||bölüm=="")
            {
                MessageBox.Show("BÜTÜN BİLGİLERİ GİRDĞİNİZDEN EMİN OLUNUZ", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)//TÜM İÇERİĞİ SİLEN BUTON
        {
            DialogResult sonuç;
           sonuç=MessageBox.Show("Tüm bilgileri silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (sonuç == DialogResult.OK)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex=-1;
            }
         
        }

    }
}
