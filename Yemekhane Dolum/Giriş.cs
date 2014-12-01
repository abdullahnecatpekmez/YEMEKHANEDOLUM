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
    public partial class Giriş : Form
    {
        string kullanıcı = "gümuab", şifre = "123";
        Form y;
        public Giriş(Yükleniyor y)
        {
            this.y = y;
            InitializeComponent();
        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            y.Visible = false;
        }

        private void girişYap_Click(object sender, EventArgs e)
        {
            Form işle = new Yükleniyor("İşleniyor", 1);
            Form kapa = new Yükleniyor("İşleniyor", 2);
            this.Visible = false;
            işle.ShowDialog();
            if (kullanıcı.Equals(kullanıcıt.Text) && şifre.Equals(parola.Text))
            {
                parola.Text = null;
                Form nextform = new Ana_Menü();
                nextform.ShowDialog();
            }
            else 
            {
                MessageBox.Show("PAROLA YANLIŞ VEYA HATALI KULLANICI...", "DİKKAT!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                parola.Text = null;
                this.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
