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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtKalan.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); 
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            //Ödenen tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(txtOdenen.Text);
            kalan = Convert.ToInt32(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();

            //Yeni Tutarı veritabanına ekleme

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Borclar set OgrKalanBorc = @P1 where OgrId=@P2", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@P1",txtKalan.Text);
            sqlCommand.Parameters.AddWithValue("@P2",txtOgrId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Borç Ödendi.");
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtOgrId.Text = "";
            txtOdenenAy.Text = "";
            txtOdenen.Text = "";
            txtKalan.Text = "";


            this.borclarTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet2.Borclar);

            //Kasa Tablosuna Ekleme Yapma
            sqlConnection.Open();
            SqlCommand sqlCommand1 = new SqlCommand("Insert Into Kasa(OdemeAy,OdemeMiktar) values (@k1,@k2)",sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@k1",txtOdenenAy.Text);
            sqlCommand1.Parameters.AddWithValue("@k2",txtOdenen.Text);
            sqlCommand1.ExecuteNonQuery();
            sqlConnection.Close();
        
        }
    }
}
