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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            //Kasadaki Toplam Para
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select Sum(OdemeMiktar) From Kasa",sqlConnection);
            SqlDataReader read = sqlCommand.ExecuteReader();
            while (read.Read())
            {
                lblPara.Text = read[0].ToString() + " TL";
            }
            sqlConnection.Close();

            //Tekrarsız Olarak Ayları Listeleme
            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Select distinct (OdemeAy) from Kasa",sqlConnection);
            SqlDataReader reader = sqlCommand1.ExecuteReader();
            while (reader.Read())
            {
                cbxAy.Items.Add(reader[0].ToString());
            }
            sqlConnection.Close();

            //Grafiklere Veri Tabanından Veri Çekme
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("select OdemeAy, sum(OdemeMiktar) From Kasa group By OdemeAy",sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            while (sqlDataReader.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(sqlDataReader[0],sqlDataReader[1]) ;
            }
            sqlConnection.Close();
        
        
        }

        private void cbxAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select sum (OdemeMiktar) from Kasa where OdemeAy = @p1",sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1",cbxAy.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblAyKazanc.Text = sqlDataReader[0].ToString();
            }
            sqlConnection.Close();
        }
    }
}
