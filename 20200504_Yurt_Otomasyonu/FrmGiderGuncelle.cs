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
using System.Data;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, dogalgaz, gida, personelgider, internet, diger,id;
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderId.Text = id;
            txtElektrik.Text = elektrik;
            txtSu.Text = su;
            txtPersonelGideri.Text = personelgider;
            txtDiger.Text = diger;
            txtDogalgaz.Text = dogalgaz;
            txtInternet.Text = internet;
            txtGida.Text = gida;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,Internet=@p4,Gida=@p5,PersonelGideri=@p6,Diger=@p7 where OdemeId = @p0", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p0", txtGiderId.Text);
                sqlCommand.Parameters.AddWithValue("@p1", txtElektrik.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSu.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtInternet.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtGida.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtPersonelGideri.Text);
                sqlCommand.Parameters.AddWithValue("@p7", txtDiger.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı.");
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız.");
            }
            

        }

    }
}
