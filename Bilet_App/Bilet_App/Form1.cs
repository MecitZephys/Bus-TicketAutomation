using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_App
{
    public partial class Form1 : Form
    {
        public static string message = "Koltuk rezerve edilmiştir.";
        public static string yolcuNumara;
        public static string yolcuIsim;
        public static string yolcuSoyad;
        public static string yolcuCinsiyet;
        public Button seciliButon;
        public Form1()
        {
            InitializeComponent();
        }
       
        public Button YolcuBilgi(Button butonP)
        {
            yolcuNumara = butonP.Text;
            yolcuIsim = txtboxName.Text;
            yolcuSoyad = txtboxSurname.Text;

            return butonP;
            

        }
        public Button groupGoster(Button a)
        {
            biletGroup.Visible = true;
            return a;
        }
        private Button ButonSec(Button bt)
        {
            if (checkErkek.Checked == true)
            {
                checkKadin.Checked = false;
                bt.BackColor = Color.Blue;
                yolcuCinsiyet = "Erkek";
                return bt;

            }
            else if (checkKadin.Checked == true)
            {
                checkErkek.Checked = false;
                bt.BackColor = Color.Pink;
                yolcuCinsiyet = "Kadın";
                return bt;
            }
            else
                return bt;
           
        }
        
        private Button KoltukSec(Button btnn)
        {
            label4.Text = btnn.Text;
            seciliButon = btnn;
            return seciliButon; 
        }
        private Button RezerveEt(Button btn)
        {
            MessageBox.Show(message);
            return btn;
        }
        
        
        //-----------------------------BUTON İŞLEMLERİ--------------------------------------------//

        private void btnBilet_Click(object sender, EventArgs e)
        {
            
            ButonSec(seciliButon);
            RezerveEt(seciliButon);
            YolcuBilgi(seciliButon);
        }

        private void koltuk1_Click(object sender, EventArgs e)
        {
            KoltukSec(koltuk1);
            groupGoster(seciliButon);
            
            
        }

        private void checkErkek_Click(object sender, EventArgs e)
        {
            checkKadin.Checked = false;
        }

        private void checkKadin_Click(object sender, EventArgs e)
        {
            checkErkek.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            biletGroup.Visible = false;
        }

        private void pboxYolcular_Click(object sender, EventArgs e)
        {
            YolcuListesi ylc = new YolcuListesi();
            ylc.Show();
            this.Hide();
        }
    }
}
