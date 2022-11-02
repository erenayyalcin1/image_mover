using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Mode degistirme butonuna basildikca size modunu degistiriyorum sirasiyla  autosize centerimage zoom normal strechimage autosize
        /// </summary>

        private void BTN_mode_degistirme_Click(object sender, EventArgs e)


        {
            
            byte a = (byte)PB_Fotograf_Alani.SizeMode; //Anlik olarak pictureboxun size modu
            if (a==4)
            {
                a = 0;   // 5 . opsiyon olmadigi icin 0 a geri donecek 
            }
            else
            {
                a += 1;  // a yi birer artirir.
            }
            //a artik yeni size modun sayisini temsil eder.

            PB_Fotograf_Alani.SizeMode = (PictureBoxSizeMode)a;
           
        }

        private void BTN_foto_yukle_Click(object sender, EventArgs e)
        {
            PB_Fotograf_Alani.Image = FotoIslemleri.FotoSectirtVeGetir();// kullaniciya bir fotograf sectirir ve fotografi alana atar.


        }
        /// <summary>
        /// Yuksekligi 10 artiracak.
        /// </summary>
        private void BTN_Yuksekligi_Artirir_Click(object sender, EventArgs e)
        {

            // picture boksimin sizenin yuksekligini yukseklik ya atayacagim 
            int yukseklik = PB_Fotograf_Alani.Size.Height;
            // picture baksin sizenin genisligi b ye atanacak
            int genislik = PB_Fotograf_Alani.Size.Width;
            Size YeniSize= new Size(genislik, yukseklik + 10);// PB_Fotograf_Alani'in yeni size'ini ifade eder.
            PB_Fotograf_Alani.MaximumSize = YeniSize;
            PB_Fotograf_Alani.Size = YeniSize;
        }
        /// <summary>
        /// Yuksekligi 10 azaltacak.
        /// </summary>
        private void BTN_Yuksekligi_Azaltir_Click(object sender, EventArgs e)
        {
            //fotograf alaninin genisligini genislige atadik.
            int genislik = PB_Fotograf_Alani.Size.Width;
            //fotograf alaninin yuksekligini yukseklige atadik.
            int yukseklik = PB_Fotograf_Alani.Size.Height; 
            Size YeniSize= new Size(genislik, yukseklik - 10); //size in icinden yeni size olusturduk.
            PB_Fotograf_Alani.MaximumSize = YeniSize;
            PB_Fotograf_Alani.Size = YeniSize;
        }
        /// <summary>
        /// Genisligi 10 artiracak.
        /// </summary>
        private void BTN_Genisligi_Artirir_Click(object sender, EventArgs e)
        {
            //fotograf alanin genisligini genislige atadik
            int genislik = PB_Fotograf_Alani.Size.Width;
            // fotograf alanindan yuksekligi yukseklige atadik 
            int yukseklik = PB_Fotograf_Alani.Size.Height;
            Size YeniSize = new Size(genislik + 10, yukseklik);
            PB_Fotograf_Alani.MaximumSize = YeniSize;
            PB_Fotograf_Alani.Size = YeniSize;
        }
        /// <summary>
        /// Genisligi 10 azaltacak
        /// </summary>
        private void BTN_Genisligi_Azaltir_Click(object sender, EventArgs e)
        {
            //Fotograf alanin genisligini genisligine atadik.
            int genislik = PB_Fotograf_Alani.Size.Width;
            //Fotograf alanin yuksekligini yukseklige atadik.
            int yukseklik = PB_Fotograf_Alani.Size.Height;
            Size YeniSize = new Size(genislik-10, yukseklik);
            PB_Fotograf_Alani.MaximumSize = YeniSize;
            PB_Fotograf_Alani.Size = YeniSize;
        }

        private void BTN_sag_Click(object sender, EventArgs e)
        {
            //fotograf alaninda ki lokasyonun x degerini x e atadim.
            int x = PB_Fotograf_Alani.Location.X;
            //fotograf alaninda ki lokasyonun y degerini y e atadim.
            int y = PB_Fotograf_Alani.Location.Y;

            //sag butona tikladigimda picturebox 10 piksel saga kayar.
            PB_Fotograf_Alani.Location = new Point(x+10, y);
        }

        private void BTN_sol_Click(object sender, EventArgs e)
        {
            //fotograf alaninda ki lokasyonun x degerini x e atar.
            int x = PB_Fotograf_Alani.Location.X;
            //fotograf alaninda ki lokasyonun y degerini y e atar.
            int y = PB_Fotograf_Alani.Location.Y;

            // sol butona tikladiginda pictureBox 10 piksel sola kayar 
            PB_Fotograf_Alani.Location = new Point(x - 10, y);
        }

        private void BTN_alt_Click(object sender, EventArgs e)
        {
            //fotograf alaninda ki lokasyonun x degerini x e atar.
            int x = PB_Fotograf_Alani.Location.X;
            //fotograf alaninda ki lokasyonun y degerini y e atar.
            int y = PB_Fotograf_Alani.Location.Y;

            // alt butona  tiklandiginda picture box 10 piksel alt kisma kayar.
            PB_Fotograf_Alani.Location = new Point(x, y + 10);
        }

        private void BTN_YUKARI_Click(object sender, EventArgs e)
        {
            //fotograf alaninda ki lokasyonun x degerini x e atar.
            int x = PB_Fotograf_Alani.Location.X;
            //fotograf alaninda ki lokasyonun y degerini y e atar.
            int y = PB_Fotograf_Alani.Location.Y;

            // ust butona  tiklandiginda picture box 10 piksel ust kisma kayar.
            PB_Fotograf_Alani.Location = new Point(x, y - 10);
        }

        private void PB_Fotograf_Alani_SizeChanged(object sender, EventArgs e)
        {
            //Label_Text.Text = PB_Fotograf_Alani.Size.Width + "," + PB_Fotograf_Alani.Size.Height;
            Label_Size.Text = $"{PB_Fotograf_Alani.Size.Width},{PB_Fotograf_Alani.Size.Height}";
        }

        private void PB_Fotograf_Alani_LocationChanged(object sender, EventArgs e)
        {
            Label_Location.Text = $"x:{PB_Fotograf_Alani.Location.X},y:{PB_Fotograf_Alani.Location.Y}";// x:10 , y:20
        }
    }
    // Örnek kullanım: FotoIslemleri.FotoSectirtVeGetir()
    public class FotoIslemleri
    {
        /// <summary>
        /// Kullanıcıya bir fotoğraf seçtirir ve seçtiği fotoğrafı döndürür. Eğer kullanıcı bir fotoğraf seçmezse NULL DÖNDÜRÜR.
        /// </summary>
        /// <returns>Kullanıcı bir fotoğraf seçerse, seçtiği fotoğrafı döndürür. Eğer seçmezse NULL Döndürür.</returns>
        public static Image FotoSectirtVeGetir()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "jpg dosyalari (.jpg)|*.jpg|png dosyalari (.png)|*.png|jpeg dosyalari (.jpeg)|*.jpeg";
            openFileDialog.Title = "BIR FOTOGRAF SECINIZ.";

            return openFileDialog.ShowDialog() == DialogResult.OK ? Image.FromFile(openFileDialog.FileName) : null;
        }
    }
}
