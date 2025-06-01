namespace fnl
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDuraklat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblSecilen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDuraklat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.lblSecilen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(37, 187);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1504, 777);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(37, 13);
            this.btnSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(458, 103);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Dosya Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(518, 13);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(458, 103);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDuraklat
            // 
            this.btnDuraklat.Location = new System.Drawing.Point(1354, 13);
            this.btnDuraklat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuraklat.Name = "btnDuraklat";
            this.btnDuraklat.Size = new System.Drawing.Size(187, 103);
            this.btnDuraklat.TabIndex = 3;
            this.btnDuraklat.Text = "Duraklat";
            this.btnDuraklat.UseVisualStyleBackColor = true;
            this.btnDuraklat.Click += new System.EventHandler(this.btnDuraklat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(1068, 13);
            this.btnDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(216, 103);
            this.btnDurdur.TabIndex = 4;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // lblSecilen
            // 
            this.lblSecilen.Location = new System.Drawing.Point(13, 145);
            this.lblSecilen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(611, 24);
            this.lblSecilen.TabIndex = 5;
            this.lblSecilen.Text = "Seçilen dosya:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 965);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnDuraklat);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.lblSecilen);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Müzik Çalar";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}