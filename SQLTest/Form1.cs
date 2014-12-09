using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// veritabanı işlemleri için SQLClient namespace eklenir.
using System.Data.SqlClient;

namespace SQLTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection baglanti;

        public void PersonelGetir()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand komut = new SqlCommand("SELECT * FROM Personel ORDER BY ID", baglanti);

            SqlDataAdapter tablo = new SqlDataAdapter(komut);

            DataTable veriler = new DataTable();

            tablo.Fill(veriler);

            Liste.DataSource = veriler;

            baglanti.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih.Format = DateTimePickerFormat.Custom;
            Tarih.CustomFormat = "yyyy-MM-dd";
            
            baglanti = new SqlConnection("Data Source=PC\\SA; Initial Catalog=ders_vt;User Id=sa;Password=1234; Integrated Security=true");
            PersonelGetir();
        
        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            bool durum;
            if (Onay.Checked)
            {
                durum = true;
            }
            else
            {
                durum = false;
            }

            string ad = Ad.Text;
            string soyad = Soyad.Text;
            int yas = int.Parse(Yas.Text);
            string tarih = Tarih.Text;

            try
            {
                SqlCommand ekleme_komutu = new SqlCommand("INSERT INTO Personel (Ad, Soyad, Yas, Tarih, Onay) VALUES (@Ad, @Soyad, @Yas, @Tarih, @Onay)", baglanti);

                

                ekleme_komutu.Parameters.AddWithValue("@Ad", ad);
                ekleme_komutu.Parameters.AddWithValue("@Soyad", soyad);
                ekleme_komutu.Parameters.AddWithValue("@Yas", yas);
                ekleme_komutu.Parameters.AddWithValue("@Tarih", tarih);
                ekleme_komutu.Parameters.AddWithValue("@Onay", durum);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                ekleme_komutu.ExecuteNonQuery();

                baglanti.Close();

                PersonelGetir();

                MessageBox.Show("Eklendi.");

            }
            catch (SqlException)
            {
                MessageBox.Show("Bir hata oluştu. Veri eklenemedi.");
            }

        }

        private void GuncelleButon_Click(object sender, EventArgs e)
        {

            bool durum;
            if (Onay.Checked)
            {
                durum = true;
            }
            else
            {
                durum = false;
            }

            string ad = Ad.Text;
            string soyad = Soyad.Text;
            int yas = int.Parse(Yas.Text);
            string tarih = Tarih.Text;

            try
            {
                SqlCommand ekleme_komutu = new SqlCommand("UPDATE Personel SET Ad=@Ad, Soyad=@Soyad,Yas=@Yas,Tarih=@Tarih,Onay=@Onay WHERE ID=@ID", baglanti);


                ekleme_komutu.Parameters.AddWithValue("@ID",Liste.CurrentRow.Cells[0].Value);
                ekleme_komutu.Parameters.AddWithValue("@Ad", ad);
                ekleme_komutu.Parameters.AddWithValue("@Soyad", soyad);
                ekleme_komutu.Parameters.AddWithValue("@Yas", yas);
                ekleme_komutu.Parameters.AddWithValue("@Tarih", tarih);
                ekleme_komutu.Parameters.AddWithValue("@Onay", durum);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                ekleme_komutu.ExecuteNonQuery();

                baglanti.Close();

                PersonelGetir();

                MessageBox.Show("Güncellendi.");

            }
            catch (SqlException)
            {
                MessageBox.Show("Bir hata oluştu. Veri eklenemedi.");
            }



        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sil = new SqlCommand("DELETE FROM Personel WHERE ID=@ID",baglanti);
                sil.Parameters.AddWithValue("@ID", Liste.CurrentRow.Cells[0].Value);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                sil.ExecuteNonQuery();
                baglanti.Close();
                PersonelGetir();
                MessageBox.Show("Kayıt Silindi.");
            }
            catch (SqlException)
            {
                MessageBox.Show("Bir hata oluştu, veri silinemedi.");
            }
        }
    }
}
