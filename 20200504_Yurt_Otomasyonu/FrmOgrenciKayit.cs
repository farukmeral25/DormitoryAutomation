using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");


        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme Komutları
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select BolumAdi From Bolumler", sqlConnection);
            SqlDataReader read = sqlCommand.ExecuteReader();
            while (read.Read())
            {
                cbxBolum.Items.Add(read[0].ToString());
            }
            sqlConnection.Close();

            //Boş Odaları Listeleme
            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select OdaNo From YurtOdalar where OdaKapasite != OdaAktifMi ",sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbxOdaNo.Items.Add(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into Ogrenciler (OgrAd,OgrSoyad,OgrTc,OgrTelefon,OgrDogumTarihi,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@P1", txtOgrAd.Text);
                sqlCommand.Parameters.AddWithValue("@P2", txtOgrSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P3", msktxtTC.Text);
                sqlCommand.Parameters.AddWithValue("@P4", msktxtTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@P5", msktxtDogumTarihi.Text);
                sqlCommand.Parameters.AddWithValue("@P6", cbxBolum.Text);
                sqlCommand.Parameters.AddWithValue("@P7", txtMail.Text);
                sqlCommand.Parameters.AddWithValue("@P8", cbxOdaNo.Text);
                sqlCommand.Parameters.AddWithValue("@P9", txtVeliAdSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P10", msktxtVeliTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@P11", rchtxtAdres.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kayıt Başarılı.");

                sqlConnection.Open();
                SqlCommand sqlCommand2 = new SqlCommand("Select OgrId From Ogrenciler",sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lblOgrId.Text = sqlDataReader[0].ToString();
                }
                sqlConnection.Close();
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("Insert Into Borclar (OgrId,OgrAd,OgrSoyad) values (@Q1,@Q2,@Q3)",sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@Q1", lblOgrId.Text);
                sqlCommand1.Parameters.AddWithValue("@Q2", txtOgrAd.Text);
                sqlCommand1.Parameters.AddWithValue("@Q3", txtOgrSoyad.Text);
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Başarısız.");
            }

            //Öğrenci oda kontenjanı Arttırma

            sqlConnection.Open();
            SqlCommand komut = new SqlCommand("Update YurtOdalar set OdaAktifMi = OdaAktifMi+1 where OdaNo = @Q4",sqlConnection);
            komut.Parameters.AddWithValue("@Q4",cbxOdaNo.Text);
            komut.ExecuteNonQuery();
            sqlConnection.Close();
            

        }
    }
}
