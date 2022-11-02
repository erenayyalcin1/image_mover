
namespace odev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_YUKARI = new System.Windows.Forms.Button();
            this.BTN_sag = new System.Windows.Forms.Button();
            this.BTN_alt = new System.Windows.Forms.Button();
            this.BTN_sol = new System.Windows.Forms.Button();
            this.PB_Fotograf_Alani = new System.Windows.Forms.PictureBox();
            this.BTN_mode_degistirme = new System.Windows.Forms.Button();
            this.BTN_foto_yukle = new System.Windows.Forms.Button();
            this.BTN_Yuksekligi_Artirir = new System.Windows.Forms.Button();
            this.BTN_Genisligi_Artirir = new System.Windows.Forms.Button();
            this.BTN_Yuksekligi_Azaltir = new System.Windows.Forms.Button();
            this.BTN_Genisligi_Azaltir = new System.Windows.Forms.Button();
            this.Label_Size = new System.Windows.Forms.Label();
            this.Label_Location = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fotograf_Alani)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_YUKARI
            // 
            this.BTN_YUKARI.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.BTN_YUKARI.Location = new System.Drawing.Point(108, 278);
            this.BTN_YUKARI.Name = "BTN_YUKARI";
            this.BTN_YUKARI.Size = new System.Drawing.Size(75, 23);
            this.BTN_YUKARI.TabIndex = 0;
            this.BTN_YUKARI.Text = "^";
            this.BTN_YUKARI.UseVisualStyleBackColor = true;
            this.BTN_YUKARI.Click += new System.EventHandler(this.BTN_YUKARI_Click);
            // 
            // BTN_sag
            // 
            this.BTN_sag.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.BTN_sag.Location = new System.Drawing.Point(181, 315);
            this.BTN_sag.Name = "BTN_sag";
            this.BTN_sag.Size = new System.Drawing.Size(75, 23);
            this.BTN_sag.TabIndex = 1;
            this.BTN_sag.Text = "->";
            this.BTN_sag.UseVisualStyleBackColor = true;
            this.BTN_sag.Click += new System.EventHandler(this.BTN_sag_Click);
            // 
            // BTN_alt
            // 
            this.BTN_alt.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.BTN_alt.Location = new System.Drawing.Point(108, 358);
            this.BTN_alt.Name = "BTN_alt";
            this.BTN_alt.Size = new System.Drawing.Size(75, 23);
            this.BTN_alt.TabIndex = 2;
            this.BTN_alt.Text = "V";
            this.BTN_alt.UseVisualStyleBackColor = true;
            this.BTN_alt.Click += new System.EventHandler(this.BTN_alt_Click);
            // 
            // BTN_sol
            // 
            this.BTN_sol.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.BTN_sol.Location = new System.Drawing.Point(33, 315);
            this.BTN_sol.Name = "BTN_sol";
            this.BTN_sol.Size = new System.Drawing.Size(75, 23);
            this.BTN_sol.TabIndex = 3;
            this.BTN_sol.Text = "<-";
            this.BTN_sol.UseVisualStyleBackColor = true;
            this.BTN_sol.Click += new System.EventHandler(this.BTN_sol_Click);
            // 
            // PB_Fotograf_Alani
            // 
            this.PB_Fotograf_Alani.Location = new System.Drawing.Point(300, 12);
            this.PB_Fotograf_Alani.MaximumSize = new System.Drawing.Size(238, 202);
            this.PB_Fotograf_Alani.Name = "PB_Fotograf_Alani";
            this.PB_Fotograf_Alani.Size = new System.Drawing.Size(238, 202);
            this.PB_Fotograf_Alani.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB_Fotograf_Alani.TabIndex = 4;
            this.PB_Fotograf_Alani.TabStop = false;
            this.PB_Fotograf_Alani.LocationChanged += new System.EventHandler(this.PB_Fotograf_Alani_LocationChanged);
            this.PB_Fotograf_Alani.SizeChanged += new System.EventHandler(this.PB_Fotograf_Alani_SizeChanged);
            // 
            // BTN_mode_degistirme
            // 
            this.BTN_mode_degistirme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_mode_degistirme.Location = new System.Drawing.Point(383, 290);
            this.BTN_mode_degistirme.Name = "BTN_mode_degistirme";
            this.BTN_mode_degistirme.Size = new System.Drawing.Size(118, 48);
            this.BTN_mode_degistirme.TabIndex = 5;
            this.BTN_mode_degistirme.Text = "Mode Degistir";
            this.BTN_mode_degistirme.UseVisualStyleBackColor = true;
            this.BTN_mode_degistirme.Click += new System.EventHandler(this.BTN_mode_degistirme_Click);
            // 
            // BTN_foto_yukle
            // 
            this.BTN_foto_yukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_foto_yukle.Location = new System.Drawing.Point(383, 358);
            this.BTN_foto_yukle.Name = "BTN_foto_yukle";
            this.BTN_foto_yukle.Size = new System.Drawing.Size(118, 54);
            this.BTN_foto_yukle.TabIndex = 6;
            this.BTN_foto_yukle.Text = "Foto Yukle";
            this.BTN_foto_yukle.UseVisualStyleBackColor = true;
            this.BTN_foto_yukle.Click += new System.EventHandler(this.BTN_foto_yukle_Click);
            // 
            // BTN_Yuksekligi_Artirir
            // 
            this.BTN_Yuksekligi_Artirir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Yuksekligi_Artirir.Location = new System.Drawing.Point(548, 290);
            this.BTN_Yuksekligi_Artirir.Name = "BTN_Yuksekligi_Artirir";
            this.BTN_Yuksekligi_Artirir.Size = new System.Drawing.Size(95, 48);
            this.BTN_Yuksekligi_Artirir.TabIndex = 7;
            this.BTN_Yuksekligi_Artirir.Text = "Yuksekligi Artirir";
            this.BTN_Yuksekligi_Artirir.UseVisualStyleBackColor = true;
            this.BTN_Yuksekligi_Artirir.Click += new System.EventHandler(this.BTN_Yuksekligi_Artirir_Click);
            // 
            // BTN_Genisligi_Artirir
            // 
            this.BTN_Genisligi_Artirir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Genisligi_Artirir.Location = new System.Drawing.Point(669, 290);
            this.BTN_Genisligi_Artirir.Name = "BTN_Genisligi_Artirir";
            this.BTN_Genisligi_Artirir.Size = new System.Drawing.Size(90, 48);
            this.BTN_Genisligi_Artirir.TabIndex = 8;
            this.BTN_Genisligi_Artirir.Text = "Genisligi Artirir";
            this.BTN_Genisligi_Artirir.UseVisualStyleBackColor = true;
            this.BTN_Genisligi_Artirir.Click += new System.EventHandler(this.BTN_Genisligi_Artirir_Click);
            // 
            // BTN_Yuksekligi_Azaltir
            // 
            this.BTN_Yuksekligi_Azaltir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Yuksekligi_Azaltir.Location = new System.Drawing.Point(548, 357);
            this.BTN_Yuksekligi_Azaltir.Name = "BTN_Yuksekligi_Azaltir";
            this.BTN_Yuksekligi_Azaltir.Size = new System.Drawing.Size(95, 55);
            this.BTN_Yuksekligi_Azaltir.TabIndex = 9;
            this.BTN_Yuksekligi_Azaltir.Text = "Yuksekligi azaltir";
            this.BTN_Yuksekligi_Azaltir.UseVisualStyleBackColor = true;
            this.BTN_Yuksekligi_Azaltir.Click += new System.EventHandler(this.BTN_Yuksekligi_Azaltir_Click);
            // 
            // BTN_Genisligi_Azaltir
            // 
            this.BTN_Genisligi_Azaltir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Genisligi_Azaltir.Location = new System.Drawing.Point(669, 357);
            this.BTN_Genisligi_Azaltir.Name = "BTN_Genisligi_Azaltir";
            this.BTN_Genisligi_Azaltir.Size = new System.Drawing.Size(90, 55);
            this.BTN_Genisligi_Azaltir.TabIndex = 10;
            this.BTN_Genisligi_Azaltir.Text = "Genisligi azaltir";
            this.BTN_Genisligi_Azaltir.UseVisualStyleBackColor = true;
            this.BTN_Genisligi_Azaltir.Click += new System.EventHandler(this.BTN_Genisligi_Azaltir_Click);
            // 
            // Label_Size
            // 
            this.Label_Size.AutoSize = true;
            this.Label_Size.Location = new System.Drawing.Point(12, 9);
            this.Label_Size.Name = "Label_Size";
            this.Label_Size.Size = new System.Drawing.Size(0, 17);
            this.Label_Size.TabIndex = 11;
            this.Label_Size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Location = new System.Drawing.Point(13, 30);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(0, 17);
            this.Label_Location.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.Label_Location);
            this.Controls.Add(this.Label_Size);
            this.Controls.Add(this.BTN_Genisligi_Azaltir);
            this.Controls.Add(this.BTN_Yuksekligi_Azaltir);
            this.Controls.Add(this.BTN_Genisligi_Artirir);
            this.Controls.Add(this.BTN_Yuksekligi_Artirir);
            this.Controls.Add(this.BTN_foto_yukle);
            this.Controls.Add(this.BTN_mode_degistirme);
            this.Controls.Add(this.PB_Fotograf_Alani);
            this.Controls.Add(this.BTN_sol);
            this.Controls.Add(this.BTN_alt);
            this.Controls.Add(this.BTN_sag);
            this.Controls.Add(this.BTN_YUKARI);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Fotograf_Alani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_YUKARI;
        private System.Windows.Forms.Button BTN_sag;
        private System.Windows.Forms.Button BTN_sol;
        private System.Windows.Forms.PictureBox PB_Fotograf_Alani;
        private System.Windows.Forms.Button BTN_mode_degistirme;
        private System.Windows.Forms.Button BTN_foto_yukle;
        private System.Windows.Forms.Button BTN_Yuksekligi_Artirir;
        private System.Windows.Forms.Button BTN_Genisligi_Artirir;
        private System.Windows.Forms.Button BTN_Yuksekligi_Azaltir;
        private System.Windows.Forms.Button BTN_Genisligi_Azaltir;
        private System.Windows.Forms.Label Label_Size;
        private System.Windows.Forms.Button BTN_alt;
        private System.Windows.Forms.Label Label_Location;
    }
}

