using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yemekhane_Dolum
{
    public partial class Ana_Menü : Form
    {
        DB d = new DB();
        Yemek_Katalogu katalog = new Yemek_Katalogu();
        string s = "Menü: ";
        int ss=15;
        Ogun ogun;
        public Ana_Menü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tarihChange(object sender, EventArgs e)
        {
            ogunGBox.Visible = ogun.haftasec(date.Value);
            sabah.Checked = false;
            ögle.Checked = false;
            akşam.Checked = false;
        }

        private void Ana_Menü_Load(object sender, EventArgs e)
        {
            
            ogunGBox.Visible = false;
            menuGBox.Visible = false;
            ogun = new Ogun();
            ss++;
            label1.Text = s;
        }

        private void sabah_CheckedChanged(object sender, EventArgs e)
        {
            yemek.Items.Clear();
            if(sabah.Checked==true)
            {
                ogun.settur(1);
                menuGBox.Visible = ogun.ogunsec("Sabah", 1,katalog);
                katalog.setlist(d.katalog(katalog.gettur()));
                comboat(); ;
                d.menügöster(data, ogun);
            }
        }

        private void ögle_CheckedChanged(object sender, EventArgs e)
        {
            yemek.Items.Clear();
            if (ögle.Checked == true)
            {
                ogun.settur(2);
                menuGBox.Visible = ogun.ogunsec("Öğle", 2, katalog);
                katalog.setlist(d.katalog(katalog.gettur()));
                comboat(); ;
                d.menügöster(data, ogun);
            }
        }

        private void akşam_CheckedChanged(object sender, EventArgs e)
        {
            yemek.Items.Clear();
            if (akşam.Checked == true)
            {
                ogun.settur(3);
                menuGBox.Visible = ogun.ogunsec("Akşam", 2, katalog);
                katalog.setlist(d.katalog(katalog.gettur()));
                comboat(); ;
                d.menügöster(data, ogun);
            }
        }
        public void comboat()
        {
            for (int i = 0; i < katalog.getlist().Count; i++)
                yemek.Items.Add(((Yemek)katalog.getlist()[i]).getAd());
        }

        public object yemekbul(string str)
        {
            foreach(Yemek x in katalog.getlist())
            {
                if (x.getAd().Equals(str))
                    return x;
            }
            return null;
        }
        private void yemekSec_Click(object sender, EventArgs e)
        {
            ogun.yemekSec(((Yemek)yemekbul(yemek.SelectedItem.ToString())));
            d.menügöster(data, ogun);
            yemek.SelectedItem = null;
            label1.Text = ogun.getmenu().yazdır();
        }

        private void menuSec_Click(object sender, EventArgs e)
        {

            ogun.setId(ss);
            d.ogunekle(ogun);
            Ana_Menü_Load(sender, e);
        }
    }
}
