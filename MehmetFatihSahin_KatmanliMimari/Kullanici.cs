using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehmetFatihSahin_KatmanliMimari
{
    class Kullanici
    {
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Ogrenci;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        OgrenciEkleSilGuncelle Ogr = new OgrenciEkleSilGuncelle();
        
        
        public SqlDataReader Kullanicii(TextBox giriskodu, TextBox kadi,TextBox Sifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "Select * from Kullanici where KullaniciAdi='"+kadi.Text+"' ";
            read = komut.ExecuteReader();
            if(read.Read()==true)
            {
                if (Sifre.Text==read["Sifre"].ToString())
                {
                    MessageBox.Show("Giriş Yapıldı");
                    Ogr.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Lütfen Sifreinizi Kontorl edin");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Kontorl edin");
            }
            baglanti.Close();
            return read;
        }
    }
}
