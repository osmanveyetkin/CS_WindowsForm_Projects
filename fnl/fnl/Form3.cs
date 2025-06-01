using System;
using System.Windows.Forms;

namespace fnl
{
    public partial class Form3 : Form
    {
        private string secilenDosyaYolu = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); // Dosya seçici oluşturuldu
            ofd.Filter = "Desteklenen Medya|*.mp3;*.mp4;*.avi;*.wmv|Tüm Dosyalar|*.*";

            if(ofd.ShowDialog() == DialogResult.OK) //SEÇİLEN MEDYA ATANDI 
            {
                secilenDosyaYolu = ofd.FileName;
                lblSecilen.Text = "Seçilen Dosya:" + System.IO.Path.GetFileName(secilenDosyaYolu);
                axWindowsMediaPlayer1.URL = secilenDosyaYolu;

            }

            
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(secilenDosyaYolu)) // başlatıcı
                axWindowsMediaPlayer1.Ctlcontrols.play();


        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause(); // duraklatma methodu
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop(); //  durdurma methodu

        }
    }
}