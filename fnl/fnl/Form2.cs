using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fnl
{
    public partial class Form2 : Form
    {
        private List<string> resimYollari = new List<string>();
        private int aktifIndex = 0;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            string downloadsYolu = @"C:\Users\osmny\Downloads";

            if (Directory.Exists(downloadsYolu)) // PC üzeirndne belirli diizndeki klasöre ait tüm resim türleri tespit edildi
            {
                string[] dosyalar = Directory.GetFiles(downloadsYolu, ".") // .uzantıları filtrelendi
                    .Where(s => s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                    .ToArray();

                resimYollari.Clear();
                resimYollari.AddRange(dosyalar);
                aktifIndex = 0;


                if ( resimYollari.Count > 0) { //klasörde resim varmı kontrol edildi
                    ResmiGoster();
                }
                else
                {
                    MessageBox.Show("Downloads klasöründe resim bulunamadı.", "Bilgi", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information );
                }


            }
            else
            {// varolamayan klasör seçilirse tespit edildi
                MessageBox.Show("Downloads klasör bulunamadı.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }
        private void ResmiGoster() //Resimleri eşleştiren ve atayan method
        {
            if (resimYollari.Count == 0) return;

            pictureBox1.ImageLocation = resimYollari[aktifIndex];
            lblDosyaAdi.Text = Path.GetFileName(resimYollari[aktifIndex]);
        }

        private void btnIleri_Click(object sender, EventArgs e) //İleri Butonu
        {
            if (resimYollari.Count == 0) return;

            aktifIndex = (aktifIndex + 1) % resimYollari.Count;
            ResmiGoster();
        }

        private void btnGeri_Click(object sender, EventArgs e) // geri butonu
        {
            if (resimYollari.Count == 0) return;

            aktifIndex = (aktifIndex - 1) % resimYollari.Count;
            ResmiGoster();
        }

        private void btnBaslat_Click(object sender, EventArgs e) // timerı butona basınca başlatıyor
        {
            timer1.Start();
           
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnIleri.PerformClick(); // ileri butonunun özellikleri çekildi.
        }
    }
}
