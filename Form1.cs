using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class Form1 : Form
    {
        private class Yemek
        {
            public string Ad { get; set; }
            public decimal Qiymet { get; set; }

            public Yemek(string ad, decimal qiymet)
            {
                Ad = ad;
                Qiymet = qiymet;
            }

            public override string ToString()
            {
                return Ad + " - " + Qiymet.ToString("0.00") + " AZN";
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Yemek sekillerinin click hadiseleri
            picTort.Click += (s, e) => YemekElaveEt("Tort", 4.50m);
            picKola.Click += (s, e) => YemekElaveEt("Kola", 2.00m);
            picSire.Click += (s, e) => YemekElaveEt("Sire", 3.00m);
            picBurger.Click += (s, e) => YemekElaveEt("Burger", 6.00m);
            picSendvic.Click += (s, e) => YemekElaveEt("Sendvic", 4.00m);
            picPizza.Click += (s, e) => YemekElaveEt("Pizza", 7.00m);
            picKeks.Click += (s, e) => YemekElaveEt("Keks", 2.50m);
            picHotDog.Click += (s, e) => YemekElaveEt("Hot-doq", 3.50m);
            picPecenye.Click += (s, e) => YemekElaveEt("Pecenye", 2.00m);

            btnSebetdenSil.Click += btnSebetdenSil_Click;
            btnYenile.Click += btnYenile_Click;
            btnYekunHesab.Click += btnYekunHesab_Click;
            btnHesabla.Click += btnHesabla_Click;
            btnTemizle.Click += btnTemizle_Click;
        }

        // Yemeyi sebete elave et
        private void YemekElaveEt(string ad, decimal qiymet)
        {
            lstSebet.Items.Add(new Yemek(ad, qiymet));
        }

        // Sebetden secilmis yemeyi sil
        private void btnSebetdenSil_Click(object sender, EventArgs e)
        {
            if (lstSebet.SelectedIndex == -1)
            {
                MessageBox.Show("Zehmet olmasa silinecek yemeyi secin!");
                return;
            }

            Yemek yemek = (Yemek)lstSebet.SelectedItem;

            lstSebet.Items.RemoveAt(lstSebet.SelectedIndex);

            MessageBox.Show(yemek.Ad + " adli yemek sebetden silindi");
        }

        // Yenile - butun melumatlari sifirla
        private void btnYenile_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show(
                "Xanalar sifirlansinmi?",
                "Tesdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cavab == DialogResult.Yes)
            {
                txtMebleg.Clear();
                txtQaliq.Clear();
                txtHesab.Clear();
                lstSebet.Items.Clear();
            }
        }

        // Yekun hesab
        private void btnYekunHesab_Click(object sender, EventArgs e)
        {
            if (lstSebet.Items.Count == 0)
            {
                MessageBox.Show("Sebetde yemek yoxdur!");
                return;
            }

            decimal cem = 0;

            foreach (Yemek yemek in lstSebet.Items)
            {
                cem += yemek.Qiymet;
            }

            txtHesab.Text = cem.ToString("0.00");
        }

        // Hesabla - odenis ve qaligi hesabla
        private void btnHesabla_Click(object sender, EventArgs e)
        {
            if (lstSebet.Items.Count == 0)
            {
                MessageBox.Show("Sebetde yemek yoxdur!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHesab.Text))
            {
                MessageBox.Show("Evvelce Yekun hesab duymesine basin!");
                return;
            }

            decimal mebleg;
            decimal hesab;

            if (!decimal.TryParse(txtMebleg.Text, out mebleg))
            {
                MessageBox.Show("Daxil edilen mebleg duzgun deyil!");
                return;
            }

            if (!decimal.TryParse(txtHesab.Text, out hesab))
            {
                MessageBox.Show("Hesab duzgun deyil!");
                return;
            }

            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilen mebleg hesabdan azdir");
                txtQaliq.Clear();
                return;
            }

            decimal qaliq = mebleg - hesab;

            txtQaliq.Text = qaliq.ToString("0.00");

            MessageBox.Show(
                "Odenis ugurla tamamlandi!\nQaliq: " +
                qaliq.ToString("0.00") + " AZN");
        }

        // Yalniz Mebleg ve Qaliq xanalarini temizle
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMebleg.Clear();
            txtQaliq.Clear();
        }
    }
}