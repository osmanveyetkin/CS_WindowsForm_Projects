using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fnl
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            int uzunluk = (int)nudUzunluk.Value; // uzunluğun saklanması

            bool buyuk = chkBuyuk.Checked; // Şifre türleri
            bool kucuk = chkKucuk.Checked;
            bool rakam = chkRakam.Checked;
            bool ozel = chkOzel.Checked;

            if (!buyuk && !kucuk && !rakam && !ozel)
            {
                MessageBox.Show("En az az bir şifreleme tipi seçiniz."); // mutlak seçim şartı
                return;
            }

            string karakterSeti = "";
            if (buyuk) karakterSeti += "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // tipleri
            if (kucuk) karakterSeti += "abcdefghijklmnopqrstuvwxyz";
            if (rakam) karakterSeti += "0123456789";
            if (ozel) karakterSeti += "!@#$%^&*()_+-={}[]|:;<>,.?/";

            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(); // birden fazla stringi birleştirerek yapı oluşturduk

            List<char> garanti = new List<char>();
            if (buyuk) garanti.Add("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[rnd.Next(26)]);
            if (kucuk) garanti.Add("abcdefghijklmnopqrstuvwxyz"[rnd.Next(26)]);
            if (rakam) garanti.Add("0123456789"[rnd.Next(10)]);
            if (ozel) garanti.Add("!@#$%^&*()_+-={}[]|:;<>,.?/"[rnd.Next(28)]); // burda rastegelilik

            for (int i = 0; i < uzunluk - garanti.Count; i++)
            {
                sb.Append(karakterSeti[rnd.Next(karakterSeti.Length)]);  // ekleme
            }

            foreach (char c in garanti)
            {
                sb.Insert(rnd.Next(sb.Length + 1), c); // eklema
            }

            string sifre = sb.ToString(); // şifrenin atanması
            txtSifre.Text = sifre;
            txtAnalizEt.Text = sifre;
            SifreyiAnalizEt(sifre);
            listBoxSonSifreler.Items.Insert(0, sifre);
        }

        private void btnAnalizEt_Click(object sender, EventArgs e)
        {
            SifreyiAnalizEt(txtAnalizEt.Text);
        }

        private void SifreyiAnalizEt(string sifre)
        {
            if (string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Analiz edilecek bir şifre girin."); //boş değer kontrolü
                return;
            }

            int skor = 0;
            HashSet<char> tekrarlar = new HashSet<char>();

            skor += sifre.Length * 2;

            if (sifre.Any(c => char.IsUpper(c))) skor += 10; // sabit skorlar
            if (sifre.Any(c => char.IsLower(c))) skor += 10;
            if (sifre.Any(c => char.IsDigit(c))) skor += 10;
            if (sifre.Any(c => "!@#$%^&*()_+-={}[]|:;<>,.?/".Contains(c))) skor += 10;

            foreach (char c in sifre)
            {
                if (!tekrarlar.Add(c)) skor -= 1; //tekrar eden garflerin aranması
            }

            string[] yayginlar = { "123456", "password", "12345678", "qwerty", "admin" };
            foreach (string y in yayginlar)
            {
                if (sifre.ToLower().Contains(y)) // sabit parolaların tespiti
                {
                    skor -= 50;
                    break;
                }
            }

            skor = Math.Max(0, Math.Min(100, skor));
            progressBar.Value = skor; //verinin bara atanması


            lblSkor.Text = $"Güç Skoru: {skor} / 100";
            lblSeviye.Text = $"Güvenlik Seviyesi: {GuvenlikSeviyesi(skor)}";
            lblKirilma.Text = $"Kırılma süresi tahmini: {KirilmaSuresi(skor)}";
        }

        private string GuvenlikSeviyesi(int skor)
        {
            switch (skor) // puanların derecelendirilmesi
            {
                case int s when s <= 30: return "Çok Zayıf";
                case int s when s <= 50: return "Zayıf";
                case int s when s <= 70: return "Orta";
                case int s when s <= 85: return "Güçlü";
                default: return "Çok Güçlü";
            }
        }

        private string KirilmaSuresi(int skor) // derecelendirme türüne göre çözüm süreleri.
        {
            if (skor <= 30) return "birkaç saniye";
            else if (skor <= 50) return "birkaç dakika";
            else if (skor <= 70) return "birkaç saat";
            else if (skor <= 85) return "günler veya haftalar";
            else return "çok uzun zaman";
        }
    }
}