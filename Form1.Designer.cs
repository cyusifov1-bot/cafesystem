
namespace CafeSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblCafe, lblMenu, lblSebet;
        private System.Windows.Forms.Label lblMuddet, lblMebleg, lblQaliq, lblHesab;
        private System.Windows.Forms.TextBox txtMuddet, txtMebleg, txtQaliq, txtHesab;
        private System.Windows.Forms.ListBox lstSebet;

        private System.Windows.Forms.Button btnSebetdenSil, btnYenile;
        private System.Windows.Forms.Button btnYekunHesab, btnHesabla, btnTemizle;

        private System.Windows.Forms.PictureBox picTort, picKola, picSire;
        private System.Windows.Forms.PictureBox picBurger, picSendvic, picPizza;
        private System.Windows.Forms.PictureBox picKeks, picHotDog, picPecenye;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            this.Text = "Cafe system";
            this.ClientSize = new System.Drawing.Size(920, 570);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Font = new System.Drawing.Font("Segoe UI", 10);
            this.BackColor = System.Drawing.Color.White;

            // SOL PANEL
            System.Windows.Forms.Panel left = new System.Windows.Forms.Panel();
            left.SetBounds(0, 0, 205, 570);
            left.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(left);

            lblCafe = new System.Windows.Forms.Label();
            lblCafe.Text = "Cafe";
            lblCafe.Font = new System.Drawing.Font("Arial", 18,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblCafe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblCafe.SetBounds(35, 25, 135, 35);
            left.Controls.Add(lblCafe);

            System.Windows.Forms.Label cup = new System.Windows.Forms.Label();
            cup.Text = "☕";
            cup.Font = new System.Drawing.Font("Segoe UI Emoji", 65);
            cup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cup.SetBounds(30, 65, 145, 120);
            left.Controls.Add(cup);

            lblMuddet = new System.Windows.Forms.Label();
            lblMuddet.Text = "Müddət:";
            lblMuddet.SetBounds(25, 220, 70, 25);
            left.Controls.Add(lblMuddet);

            txtMuddet = new System.Windows.Forms.TextBox();
            txtMuddet.Name = "txtMuddet";
            txtMuddet.SetBounds(90, 219, 78, 27);
            left.Controls.Add(txtMuddet);

            lblMebleg = new System.Windows.Forms.Label();
            lblMebleg.Text = "Məbləğ";
            lblMebleg.SetBounds(25, 280, 100, 25);
            left.Controls.Add(lblMebleg);

            txtMebleg = new System.Windows.Forms.TextBox();
            txtMebleg.Name = "txtMebleg";
            txtMebleg.SetBounds(25, 305, 140, 28);
            left.Controls.Add(txtMebleg);

            lblQaliq = new System.Windows.Forms.Label();
            lblQaliq.Text = "Qalıq";
            lblQaliq.SetBounds(25, 350, 100, 25);
            left.Controls.Add(lblQaliq);

            txtQaliq = new System.Windows.Forms.TextBox();
            txtQaliq.Name = "txtQaliq";
            txtQaliq.ReadOnly = true;
            txtQaliq.SetBounds(25, 375, 140, 28);
            left.Controls.Add(txtQaliq);

            btnHesabla = new System.Windows.Forms.Button();
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Text = "Hesabla";
            btnHesabla.SetBounds(25, 425, 140, 38);
            btnHesabla.BackColor = System.Drawing.Color.Green;
            btnHesabla.ForeColor = System.Drawing.Color.White;
            left.Controls.Add(btnHesabla);

            btnTemizle = new System.Windows.Forms.Button();
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Text = "Təmizlə";
            btnTemizle.SetBounds(25, 475, 140, 38);
            btnTemizle.BackColor = System.Drawing.Color.Firebrick;
            btnTemizle.ForeColor = System.Drawing.Color.White;
            left.Controls.Add(btnTemizle);

            // ORTA PANEL
            System.Windows.Forms.Panel center = new System.Windows.Forms.Panel();
            center.SetBounds(205, 0, 495, 570);
            center.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(center);

            lblMenu = new System.Windows.Forms.Label();
            lblMenu.Text = "MENU";
            lblMenu.Font = new System.Drawing.Font("Arial", 18,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblMenu.SetBounds(140, 25, 210, 35);
            center.Controls.Add(lblMenu);

            picTort = YemekSekli("picTort", "🍰", 25, 90, center);
            picKola = YemekSekli("picKola", "🥤", 180, 90, center);
            picSire = YemekSekli("picSire", "🍹", 335, 90, center);

            picBurger = YemekSekli("picBurger", "🍔", 25, 220, center);
            picSendvic = YemekSekli("picSendvic", "🥪", 180, 220, center);
            picPizza = YemekSekli("picPizza", "🍕", 335, 220, center);

            picKeks = YemekSekli("picKeks", "🧁", 25, 350, center);
            picHotDog = YemekSekli("picHotDog", "🌭", 180, 350, center);
            picPecenye = YemekSekli("picPecenye", "🍪", 335, 350, center);

            // SAG PANEL
            System.Windows.Forms.Panel right = new System.Windows.Forms.Panel();
            right.SetBounds(700, 0, 220, 570);
            right.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(right);

            lblSebet = new System.Windows.Forms.Label();
            lblSebet.Text = "Səbət";
            lblSebet.Font = new System.Drawing.Font("Arial", 18,
                System.Drawing.FontStyle.Italic);
            lblSebet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblSebet.SetBounds(50, 25, 120, 35);
            right.Controls.Add(lblSebet);

            lstSebet = new System.Windows.Forms.ListBox();
            lstSebet.Name = "lstSebet";
            lstSebet.SetBounds(20, 85, 185, 250);
            right.Controls.Add(lstSebet);

            btnSebetdenSil = new System.Windows.Forms.Button();
            btnSebetdenSil.Name = "btnSebetdenSil";
            btnSebetdenSil.Text = "Səbətdən sil";
            btnSebetdenSil.SetBounds(20, 345, 185, 30);
            right.Controls.Add(btnSebetdenSil);

            btnYenile = new System.Windows.Forms.Button();
            btnYenile.Name = "btnYenile";
            btnYenile.Text = "Yenilə";
            btnYenile.SetBounds(20, 385, 185, 30);
            right.Controls.Add(btnYenile);

            btnYekunHesab = new System.Windows.Forms.Button();
            btnYekunHesab.Name = "btnYekunHesab";
            btnYekunHesab.Text = "Yekun hesab";
            btnYekunHesab.SetBounds(20, 425, 185, 30);
            right.Controls.Add(btnYekunHesab);

            lblHesab = new System.Windows.Forms.Label();
            lblHesab.Text = "Hesab:";
            lblHesab.SetBounds(25, 475, 65, 27);
            right.Controls.Add(lblHesab);

            txtHesab = new System.Windows.Forms.TextBox();
            txtHesab.Name = "txtHesab";
            txtHesab.ReadOnly = true;
            txtHesab.SetBounds(90, 475, 115, 27);
            right.Controls.Add(txtHesab);
        }

        private System.Windows.Forms.PictureBox YemekSekli(
            string ad, string emoji, int x, int y,
            System.Windows.Forms.Control parent)
        {
            System.Windows.Forms.PictureBox pic =
                new System.Windows.Forms.PictureBox();

            pic.Name = ad;
            pic.SetBounds(x, y, 125, 105);
            pic.BackColor = System.Drawing.Color.Transparent;
            pic.Cursor = System.Windows.Forms.Cursors.Hand;
            pic.SizeMode =
                System.Windows.Forms.PictureBoxSizeMode.Zoom;

            System.Windows.Forms.Label icon = new System.Windows.Forms.Label();
            icon.Text = emoji;
            icon.Font = new System.Drawing.Font("Segoe UI Emoji", 47);
            icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            icon.Dock = System.Windows.Forms.DockStyle.Fill;
            icon.BackColor = System.Drawing.Color.Transparent;

          
            icon.Enabled = false;

            pic.Controls.Add(icon);
            parent.Controls.Add(pic);

            return pic;
        }
    }
}