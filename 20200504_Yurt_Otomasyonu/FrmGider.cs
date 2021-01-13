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
using System.Linq.Expressions;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into Giderler(Elektrik,Su,Dogalgaz,Internet,Gida,PersonelGideri,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtElektrik.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSu.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                sqlCommand.Parameters.AddWithValue("@p4", txtInternet.Text);
                sqlCommand.Parameters.AddWithValue("@p5", txtGida.Text);
                sqlCommand.Parameters.AddWithValue("@p6", txtPersonelGideri.Text);
                sqlCommand.Parameters.AddWithValue("@p7", txtDiger.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Giderler Eklendi");

            }
            catch (Exception)
            {

                MessageBox.Show("Giderler Eklenemedi.");
                
            }
            

        }
    }
}
