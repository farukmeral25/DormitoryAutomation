using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

        public string id,ad,soyad,TC,telefon,dogumTarihi,bolum,mail,odano,veliAdSoyad,veliTelefon,adres;

     

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Ogrenciler set OgrAd = @p2 , OgrSoyAd = @p3,OgrTc = @p4,OgrTelefon = @p5,OgrDogumTarihi = @p6,OgrBolum = @p7,OgrMail = @p8,OgrOdaNo = @p9,OgrVeliAdSoyad = @p10,OgrVeliTelefon = @p11,ogrVeliAdres = @p12 where OgrId = @p1", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtOgrId.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p4", msktxtTC.Text);
                sqlCommand.Parameters.AddWithValue("@p5", msktxtTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@p6", msktxtDogumTarihi.Text);
                sqlCommand.Parameters.AddWithValue("@p7", cbxBolum.Text);
                sqlCommand.Parameters.AddWithValue("@p8", txtMail.Text);
                sqlCommand.Parameters.AddWithValue("@p9", cbxOdaNo.Text);
                sqlCommand.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p11", msktxtVeliTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@p12", rchtxtAdres.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Kayıt Güncellendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Güncellenemedi.");
            }
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                //Öğrenci Silme
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Delete From Ogrenciler where OgrId = @p1", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtOgrId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Öğrenci Silindi");
            }
            catch (Exception)
            {
                MessageBox.Show("Öğrenci silme işlemi başarısız.");
            }


            //Oda Kontenjan Arttırma
            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Update YurtOdalar set OdaAktifMi = OdaAktifMi - 1 where odaNo=@p2",sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@p2",cbxOdaNo.Text);
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
            
           
        }
        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrId.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            msktxtTC.Text = TC;
            msktxtTelefon.Text = telefon;
            msktxtDogumTarihi.Text = dogumTarihi;
            cbxBolum.Text = bolum;
            txtMail.Text = mail;
            cbxOdaNo.Text = odano;
            txtVeliAdSoyad.Text = veliAdSoyad;
            msktxtVeliTelefon.Text = veliTelefon;
            rchtxtAdres.Text = adres;

            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select OdaNo From YurtOdalar where OdaKapasite != OdaAktifMi ", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                cbxOdaNo.Items.Add(sqlDataReader[0].ToString());
            }
            sqlConnection.Close();

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select BolumAdi From Bolumler", sqlConnection);
            SqlDataReader read = sqlCommand.ExecuteReader();
            while (read.Read())
            {
                cbxBolum.Items.Add(read[0].ToString());
            }
            sqlConnection.Close();

        }
    }
}
