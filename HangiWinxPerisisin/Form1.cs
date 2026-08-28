using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HangiWinxPerisisin
{
    public partial class Form1 : Form
    {
        int aktifSoru = 0;
        int bloom = 0;
        int stella = 0;
        int musa = 0;
        int tecna = 0;

        System.Media.SoundPlayer arkaPlanMuzigi = new System.Media.SoundPlayer("muzik.wav");



        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }


       
        
        
        
           
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (aktifSoru == 0)
            {
                
                groupBox2.Visible = true;
                button1.Text = "Sonraki Soru ➔";
                aktifSoru = 1;
                return;
            }

           
            if (aktifSoru == 1) 
            {
                groupBox2.Visible = false;
                groupBox3.Location = groupBox2.Location;
                groupBox3.Visible = true;
                aktifSoru = 2;
            }
            else if (aktifSoru == 2) 
            {
                groupBox3.Visible = false;
                groupBox4.Location = groupBox2.Location; 
                groupBox4.Visible = true;
                aktifSoru = 3;
            }
            else if (aktifSoru == 3) 
            {
                groupBox4.Visible = false;
                groupBox5.Location = groupBox2.Location; 
                groupBox5.Visible = true;
                aktifSoru = 4;
            }
            else if (aktifSoru == 4) 
            {
                groupBox5.Visible = false;
                groupBox6.Location = groupBox2.Location; 
                groupBox6.Visible = true;
                aktifSoru = 5;
            }
            else if (aktifSoru == 5) 
            {
                groupBox6.Visible = false;
                groupBox9.Location = groupBox2.Location; 
                groupBox9.Visible = true;
                aktifSoru = 6;
            }
            else if (aktifSoru == 6) 
            {
                groupBox9.Visible = false;
                groupBox8.Location = groupBox2.Location; 
                groupBox8.Visible = true;
                aktifSoru = 7;
            }
            else if (aktifSoru == 7) 
            {
                groupBox8.Visible = false;
                groupBox1.Location = groupBox2.Location; 
                groupBox1.Visible = true;
                button1.Text = "Sonuçları Gör! ✨";
                aktifSoru = 8;
            }
            else if (aktifSoru == 8) 
            {
                groupBox1.Visible = false;
                button1.Visible = false;

               
                if (radioButton8.Checked) bloom++;
                if (radioButton7.Checked) stella++;
                if (radioButton6.Checked) musa++;
                if (radioButton5.Checked) tecna++;

                if (radioButton12.Checked) bloom++;
                if (radioButton11.Checked) stella++;
                if (radioButton10.Checked) musa++;
                if (radioButton9.Checked) tecna++;

                if (radioButton16.Checked) bloom++;
                if (radioButton15.Checked) stella++;
                if (radioButton14.Checked) musa++;
                if (radioButton13.Checked) tecna++;

                if (radioButton20.Checked) bloom++;
                if (radioButton19.Checked) stella++;
                if (radioButton18.Checked) musa++;
                if (radioButton17.Checked) tecna++;

                if (radioButton21.Checked) bloom++;
                if (radioButton22.Checked) stella++;
                if (radioButton23.Checked) musa++;
                if (radioButton24.Checked) tecna++;

                if (radioButton36.Checked) bloom++;
                if (radioButton35.Checked) stella++;
                if (radioButton34.Checked) musa++;
                if (radioButton33.Checked) tecna++;

                if (radioButton32.Checked) bloom++;
                if (radioButton31.Checked) stella++;
                if (radioButton30.Checked) musa++;
                if (radioButton29.Checked) stella++;

                if (radioButton1.Checked) bloom++;
                if (radioButton2.Checked) stella++;
                if (radioButton3.Checked) musa++;
                if (radioButton4.Checked) tecna++;

                // --- KAZANANI BELİRLEME VE GÖRSELLEŞTİRME ---
                int enYuksekPuan = Math.Max(Math.Max(bloom, stella), Math.Max(musa, tecna));

                label1.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                if (enYuksekPuan == stella)
                {
                    label1.Text = "✨ SEN TAM BİR STELLA'SIN! ✨\nEnerjin ve ışıltınla parlıyorsun!";
                    pictureBox1.Image = Properties.Resources.winx_stella;
                }
                else if (enYuksekPuan == tecna)
                {
                    label1.Text = "💻 SEN TAM BİR TECNA'SIN! 💻\nZekan, mantığın ve analitik gücün kusursuz!";
                    pictureBox1.Image = Properties.Resources.winx_tecna;
                }
                else if (enYuksekPuan == bloom)
                {
                    label1.Text = "🔥 SEN TAM BİR BLOOM'SUN! 🔥\nİçindeki ejderha ateşi ve liderlik tutkun hiç sönmüyor!";
                    pictureBox1.Image = Properties.Resources.winx_bloom;
                }
                else if (enYuksekPuan == musa)
                {
                    label1.Text = "🎵 SEN TAM BİR MUSA'SIN! 🎵\nRitim ve müzik senin ruhunda var!";
                    pictureBox1.Image = Properties.Resources.winx_musa;
                }
            }
        }
            
        
        




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                arkaPlanMuzigi.PlayLooping(); // Müzik bitince başa sarıp aralıksız çalar
            }
            catch (Exception)
            {
                // Dosya bulunamazsa oyun hata verip çökmesin diye güvenlik önlemi
            }

            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox8.Visible = false;
            groupBox9.Visible = false;
            groupBox1.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;

            // Butonun ilk yazısı başlangıç için ayarlanır
            button1.Text = "Teste Başla! 🚀";
        }

        private void lblhosgeldin_Click(object sender, EventArgs e)
        {

        }
    }
}