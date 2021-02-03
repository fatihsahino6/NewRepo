using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehmetFatihSahin_KatmanliMimari
{
    public partial class OgrenciEkleSilGuncelle : Form
    {
        SqlConnection baglanti2 = new SqlConnection("Data Source=localhost;Initial Catalog=Ogrenci;Integrated Security=True");

        public OgrenciEkleSilGuncelle()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if(baglanti2.State==ConnectionState.Closed)
            {
                baglanti2.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti2;
                cmd.CommandText = "INSERT INTO Ogrenci(Ad,Soyad,Agno) VALUES('" + txt_Ad.Text + "','" + txt_Soyad + "','" + txt_not.Text + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti2.Close();
                Listele();
                MessageBox.Show("Kayıt Başarılı");
            }
        }
        void Listele()
        {
            if(baglanti2.State==ConnectionState.Closed)
            {
                baglanti2.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = baglanti2;
                cmd.CommandText = "Select * From Ogrenci";
                SqlDataAdapter adpr = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpr.Fill(ds, "Ogrenci");
                dataGridView1.DataSource = ds.Tables["Ogrenci"];
                baglanti2.Close();
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(baglanti2.State==ConnectionState.Closed)
            {
                baglanti2.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Delete * From Ogrenci";
                cmd.Parameters.AddWithValue("@Ad", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti2.Close();
                MessageBox.Show("Kayıt Silinmiştir");
                Listele();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if(baglanti2.State==ConnectionState.Closed)
            {
                baglanti2.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Ogrenci set Ad='" + txt_Ad.Text + "',Soyad='" + txt_Soyad.Text + "',Agno='" + txt_not.Text + "')";
                cmd.Parameters.AddWithValue("@Ad", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti2.Close();
                Listele();
            }
        }
    }
}
