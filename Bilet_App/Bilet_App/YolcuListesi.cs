using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilet_App
{
    public partial class YolcuListesi : Form
    {
        
        public YolcuListesi()
        {
            InitializeComponent();
        }
        
        public GroupBox YolcuCek(GroupBox grp)
        {
            grp.Controls[0].Text = Form1.yolcuNumara;
            grp.Controls[1].Text = Form1.yolcuIsim;
            grp.Controls[2].Text = Form1.yolcuSoyad;
            grp.Controls[3].Text = Form1.yolcuCinsiyet;
            return grp;
        }

        private void YolcuListesi_Load(object sender, EventArgs e)
        {
            YolcuCek(yolcuGrup1);
            YolcuCek(yolcuGrup2);
            YolcuCek(yolcuGrup3);
            YolcuCek(yolcuGrup4);
            YolcuCek(yolcuGrup5);
            YolcuCek(yolcuGrup6);
            YolcuCek(yolcuGrup7);
            YolcuCek(yolcuGrup8);
        }
    }
}
