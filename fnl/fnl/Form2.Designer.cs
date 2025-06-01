using System;

namespace fnl
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Timer timer1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(278, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.Location = new System.Drawing.Point(12, 12);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(600, 23);
            this.lblDosyaAdi.TabIndex = 1;
            this.lblDosyaAdi.Text = "Dosya Adı";
            // 
            // btnSec
            // 
            this.btnSec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSec.Location = new System.Drawing.Point(3, 442);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(269, 190);
            this.btnSec.TabIndex = 2;
            this.btnSec.Text = "Resimleri Getirme \r\nSihirbazı";
            this.btnSec.UseVisualStyleBackColor = false;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(508, 558);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(203, 74);
            this.btnIleri.TabIndex = 3;
            this.btnIleri.Text = "İleri";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(278, 558);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(203, 74);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(736, 558);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(233, 74);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Text = "Slayt Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(998, 558);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(233, 74);
            this.btnDurdur.TabIndex = 6;
            this.btnDurdur.Text = "Slayt Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnDurdur);
            this.Name = "Form2";
            this.Text = "Görsel Galeri Uygulaması";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion
    }
}