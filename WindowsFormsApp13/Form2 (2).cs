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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string ad0,soyad0,numara0,bölüm0,alınanDersler;
        private void Form2_Load(object sender, EventArgs e)//FORM YÜKLENİRKEN CHECKEDCİLSTBOXA DERSLERİ YAZDIRIYORUM
        {

            if (bölüm0 == "0")
             {
                bölüm0 = "BİLGİSAYAR MÜHENDİSLİĞİ";

                 checkedListBox1.Items.Add("ALGORİTMA");
                 checkedListBox1.Items.Add("VERİ YAPILARI");
                 checkedListBox1.Items.Add("DİFARENSİYEL DENKLEMLER");
                 checkedListBox1.Items.Add("AYRIK MATEMATİK");
                 checkedListBox1.Items.Add("İŞLETİM SİSTEMLERİ");
             }
             else if (bölüm0 == "1")
             {
                bölüm0 = "TIP";
                 checkedListBox1.Items.Add("ANOTOMİ");
                 checkedListBox1.Items.Add("FİZYOLOJİ");
                 checkedListBox1.Items.Add("PATALOJİ");
                 checkedListBox1.Items.Add("İLK YARDIM");
                 checkedListBox1.Items.Add("KARDİYOLOJİ");
             }
        }
        private void button3_Click(object sender, EventArgs e)// GERİ TUŞUNA BASILDIĞINDA ÖNCEKİ FORMA DÖN 
        {
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)// TÜM BİLGİLERİ FORM3 E YAZDIR
        {
            alınanDersler = "";

            
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                alınanDersler += checkedListBox1.CheckedItems[i].ToString();

              
                if (i < checkedListBox1.CheckedItems.Count - 1)
                {
                    alınanDersler += "\n ";
                }
            }

            if (!string.IsNullOrEmpty(alınanDersler)) 
            {
                Form3 form3 = new Form3();
                form3.ad1 = ad0;
                form3.soyad1 = soyad0;
                form3.numara1 = numara0;
                form3.bölüm1 = bölüm0;
                form3.alınanDersler0 = alınanDersler;
                form3.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)//CHECKEDCİLSTBOX SEÇİMLERİNİ SİL
        {
            checkedListBox1.ClearSelected();
        }
    }
}
