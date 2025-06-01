using System;
using System.Data;
using System.Windows.Forms;

namespace fnl
{
    public partial class Form4 : Form
    {
        DataTable tablo = new DataTable();

        public Form4()
        {
            InitializeComponent();
            // Kolonları tanımla
            tablo.Columns.Add("Ders Adı");
            tablo.Columns.Add("Vize");
            tablo.Columns.Add("Final");
            tablo.Columns.Add("Ortalama");
            tablo.Columns.Add("Harf Notu");
            tablo.Columns.Add("Durum");
            dataGridView1.DataSource = tablo;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!GirdileriAl(out string dersAdi, out double vize, out double final, out bool vizeGirildi, out bool finalGirildi)) 
            return; // Girdiler eklenerek kaydedildi

            double ortalama = finalGirildi ? (vize + final) / 2 : vize ; // ortalama koşulu
            string harfNotu = HarfNotuHesapla(ortalama, out string durum);

            tablo.Rows.Add(dersAdi, vizeGirildi ? vize.ToString() : "-", finalGirildi ? final.ToString() : " - ",
                ortalama, harfNotu, durum);

            AGNO_Hesapla();
            Temizle();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            if (!GirdileriAl(out string dersAdi, out double vize, out double final, out bool vizeGirildi, out bool finalGirildi))
                return;

            double ortalama = finalGirildi ? (vize + final) / 2 : vize;
            string harfNotu = HarfNotuHesapla(ortalama, out string durum);

            DataGridViewRow row = dataGridView1.CurrentRow; // tabloda güncellemesi adına veriler atandı
            row.Cells["Ders Adı"].Value = dersAdi;
            row.Cells["Vize"].Value = vizeGirildi ? vize.ToString() : "-";
            row.Cells["Final"].Value = finalGirildi ? final.ToString() : "-";
            row.Cells["Ortalama"].Value = ortalama;
            row.Cells["Harf Notu"].Value = harfNotu;
            row.Cells["Durum"].Value = durum;

            AGNO_Hesapla();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if( dataGridView1.CurrentRow != null)
            {
                tablo.Rows.RemoveAt(dataGridView1.CurrentRow.Index); // focus indexin temizlenmesi
                AGNO_Hesapla();
            }
        }

        private bool GirdileriAl(out string dersAdi, out double vize, out double final, out bool vizeGirildi, out bool finalGirildi)
        {// Verileri okuyan, kontrol eden ve tabloya ekleyen method
            dersAdi = txtDersAdi.Text;
            vizeGirildi = double.TryParse(txtVize.Text, out vize);
            finalGirildi = double.TryParse(txtFinal.Text, out final);

            if (string.IsNullOrWhiteSpace(dersAdi)) //kontroller
            {
                MessageBox.Show("Ders adı boş olamaz.");
                return false;
            }

            if (!vizeGirildi)
            {
                MessageBox.Show("En azından vize notu girilmelidir.");
                return false;
            }

            return true;
        }

        private string HarfNotuHesapla(double ortalama, out string durum)
        {
            if (ortalama >= 85) { durum = "Geçti"; return "AA"; } // harf notlarının aralılkları
            else if (ortalama >= 70) { durum = "Geçti"; return "BA"; }
            else if (ortalama >= 60) { durum = "Geçti"; return "BB"; }
            else if (ortalama >= 50) { durum = "Geçti"; return "CB"; }
            else if (ortalama >= 40) { durum = "Geçti"; return "CC"; }
            else if (ortalama >= 30) { durum = "Sorumlu Geçti"; return "DC"; }
            else { durum = "Kaldı"; return "FF"; }
        }

        private double HarfNotuDegeri(string harf)
        {
            switch (harf)
            {
                case "AA": return 4.0; //Harf notuna agno değer atanması
                case "BA": return 3.5;
                case "BB": return 3.0;
                case "CB": return 2.5;
                case "CC": return 2.0;
                case "DC": return 1.5;
                case "FF": return 0.0;
                default: return 0.0;
            }
        }

        private void AGNO_Hesapla()
        {
            double toplamPuan = 0;
            int dersSayisi = tablo.Rows.Count;

            foreach (DataRow row in tablo.Rows)
            {
                string harf = row["Harf Notu"].ToString(); // harfnotunu yazdırma
                toplamPuan += HarfNotuDegeri(harf);


            }
            double agno = (dersSayisi == 0) ? 0 : toplamPuan / dersSayisi; // hesaplama adımı
            lblAGNO.Text = $"AGNO:  {agno:0.00}";
        }

        private void Temizle() // text boxların temizlenmesi
        {
            txtDersAdi.Text = "";
            txtVize.Text = "";
            txtFinal.Text = "";

        }
    }
}