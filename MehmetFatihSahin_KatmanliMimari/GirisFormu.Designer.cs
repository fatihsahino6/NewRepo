namespace MehmetFatihSahin_KatmanliMimari
{
    partial class GirisFormu
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
            this.kadi = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girisyap = new System.Windows.Forms.Button();
            this.giriskodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(151, 64);
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(100, 22);
            this.kadi.TabIndex = 0;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(151, 110);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 22);
            this.sifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // girisyap
            // 
            this.girisyap.Location = new System.Drawing.Point(114, 172);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(91, 34);
            this.girisyap.TabIndex = 4;
            this.girisyap.Text = "Giriş Yap";
            this.girisyap.UseVisualStyleBackColor = true;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click);
            // 
            // giriskodu
            // 
            this.giriskodu.Location = new System.Drawing.Point(151, 23);
            this.giriskodu.Name = "giriskodu";
            this.giriskodu.Size = new System.Drawing.Size(100, 22);
            this.giriskodu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giris Kodu";
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giriskodu);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.kadi);
            this.Name = "GirisFormu";
            this.Text = "MEHMET FATIH SAHIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.TextBox giriskodu;
        private System.Windows.Forms.Label label3;
    }
}

