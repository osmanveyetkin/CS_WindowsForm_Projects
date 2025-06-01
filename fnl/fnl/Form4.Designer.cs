namespace fnl
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TextBox txtVize;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAGNO;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.txtVize = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAGNO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Location = new System.Drawing.Point(477, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 447);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(18, 53);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(431, 29);
            this.txtDersAdi.TabIndex = 1;
            // 
            // txtVize
            // 
            this.txtVize.Location = new System.Drawing.Point(18, 121);
            this.txtVize.Name = "txtVize";
            this.txtVize.Size = new System.Drawing.Size(162, 29);
            this.txtVize.TabIndex = 2;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(268, 121);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(162, 29);
            this.txtFinal.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 193);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(431, 40);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ders Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(15, 263);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(431, 45);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Ders Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 339);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(431, 47);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Ders Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAGNO
            // 
            this.lblAGNO.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAGNO.Location = new System.Drawing.Point(6, 429);
            this.lblAGNO.Name = "lblAGNO";
            this.lblAGNO.Size = new System.Drawing.Size(200, 30);
            this.lblAGNO.TabIndex = 7;
            this.lblAGNO.Text = "AGNO: 0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ders Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vize";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Final";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(1166, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.txtVize);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblAGNO);
            this.Name = "Form4";
            this.Text = "Öğrenci Not Takip Sistemi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}