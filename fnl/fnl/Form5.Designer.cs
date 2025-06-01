namespace fnl
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown nudUzunluk;
        private System.Windows.Forms.CheckBox chkBuyuk;
        private System.Windows.Forms.CheckBox chkKucuk;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzel;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label lblSeviye;
        private System.Windows.Forms.Label lblKirilma;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txtAnalizEt;
        private System.Windows.Forms.Button btnAnalizEt;
        private System.Windows.Forms.ListBox listBoxSonSifreler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.nudUzunluk = new System.Windows.Forms.NumericUpDown();
            this.chkBuyuk = new System.Windows.Forms.CheckBox();
            this.chkKucuk = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzel = new System.Windows.Forms.CheckBox();
            this.btnUret = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblSeviye = new System.Windows.Forms.Label();
            this.lblKirilma = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txtAnalizEt = new System.Windows.Forms.TextBox();
            this.btnAnalizEt = new System.Windows.Forms.Button();
            this.listBoxSonSifreler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // nudUzunluk
            // 
            this.nudUzunluk.Location = new System.Drawing.Point(30, 30);
            this.nudUzunluk.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudUzunluk.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudUzunluk.Name = "nudUzunluk";
            this.nudUzunluk.Size = new System.Drawing.Size(60, 29);
            this.nudUzunluk.TabIndex = 0;
            this.nudUzunluk.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // chkBuyuk
            // 
            this.chkBuyuk.Location = new System.Drawing.Point(30, 70);
            this.chkBuyuk.Name = "chkBuyuk";
            this.chkBuyuk.Size = new System.Drawing.Size(104, 24);
            this.chkBuyuk.TabIndex = 1;
            this.chkBuyuk.Text = "Büyük Harf";
            // 
            // chkKucuk
            // 
            this.chkKucuk.Location = new System.Drawing.Point(140, 70);
            this.chkKucuk.Name = "chkKucuk";
            this.chkKucuk.Size = new System.Drawing.Size(104, 24);
            this.chkKucuk.TabIndex = 2;
            this.chkKucuk.Text = "Küçük Harf";
            // 
            // chkRakam
            // 
            this.chkRakam.Location = new System.Drawing.Point(26, 120);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(104, 24);
            this.chkRakam.TabIndex = 3;
            this.chkRakam.Text = "Rakam";
            // 
            // chkOzel
            // 
            this.chkOzel.Location = new System.Drawing.Point(140, 120);
            this.chkOzel.Name = "chkOzel";
            this.chkOzel.Size = new System.Drawing.Size(104, 24);
            this.chkOzel.TabIndex = 4;
            this.chkOzel.Text = "Özel Karakter";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(26, 170);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(204, 30);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "Şifre Üret";
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSifre.Location = new System.Drawing.Point(26, 229);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.ReadOnly = true;
            this.txtSifre.Size = new System.Drawing.Size(654, 45);
            this.txtSifre.TabIndex = 6;
            // 
            // lblSkor
            // 
            this.lblSkor.Location = new System.Drawing.Point(320, 30);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(300, 20);
            this.lblSkor.TabIndex = 7;
            this.lblSkor.Text = "Güç Skoru: -";
            // 
            // lblSeviye
            // 
            this.lblSeviye.Location = new System.Drawing.Point(320, 60);
            this.lblSeviye.Name = "lblSeviye";
            this.lblSeviye.Size = new System.Drawing.Size(300, 20);
            this.lblSeviye.TabIndex = 8;
            this.lblSeviye.Text = "Güvenlik Seviyesi: -";
            // 
            // lblKirilma
            // 
            this.lblKirilma.Location = new System.Drawing.Point(320, 90);
            this.lblKirilma.Name = "lblKirilma";
            this.lblKirilma.Size = new System.Drawing.Size(300, 20);
            this.lblKirilma.TabIndex = 9;
            this.lblKirilma.Text = "Kırılma Süresi Tahmini: -";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(320, 120);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(300, 25);
            this.progressBar.TabIndex = 10;
            // 
            // txtAnalizEt
            // 
            this.txtAnalizEt.Location = new System.Drawing.Point(320, 170);
            this.txtAnalizEt.Name = "txtAnalizEt";
            this.txtAnalizEt.Size = new System.Drawing.Size(250, 29);
            this.txtAnalizEt.TabIndex = 11;
            // 
            // btnAnalizEt
            // 
            this.btnAnalizEt.Location = new System.Drawing.Point(580, 170);
            this.btnAnalizEt.Name = "btnAnalizEt";
            this.btnAnalizEt.Size = new System.Drawing.Size(100, 26);
            this.btnAnalizEt.TabIndex = 12;
            this.btnAnalizEt.Text = "Şifreyi Analiz Et";
            this.btnAnalizEt.Click += new System.EventHandler(this.btnAnalizEt_Click);
            // 
            // listBoxSonSifreler
            // 
            this.listBoxSonSifreler.ItemHeight = 24;
            this.listBoxSonSifreler.Location = new System.Drawing.Point(30, 290);
            this.listBoxSonSifreler.Name = "listBoxSonSifreler";
            this.listBoxSonSifreler.Size = new System.Drawing.Size(650, 148);
            this.listBoxSonSifreler.TabIndex = 13;
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.nudUzunluk);
            this.Controls.Add(this.chkBuyuk);
            this.Controls.Add(this.chkKucuk);
            this.Controls.Add(this.chkRakam);
            this.Controls.Add(this.chkOzel);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblSeviye);
            this.Controls.Add(this.lblKirilma);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtAnalizEt);
            this.Controls.Add(this.btnAnalizEt);
            this.Controls.Add(this.listBoxSonSifreler);
            this.Name = "Form5";
            this.Text = "Şifre Üretme ve Analiz Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.nudUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}