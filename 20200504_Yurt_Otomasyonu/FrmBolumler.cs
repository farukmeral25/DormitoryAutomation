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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet.Bolumler);

        }


        private void pcbEkle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into Bolumler(BolumAdi) values (@P1)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@P1", txtBolumAd.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Bölüm Eklendi.");
                this.bolumlerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Bölüm Eklenemedi.");
            }
            
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Delete From Bolumler where BolumId = @P1", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@P1", txtBolumId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirilemedi.");
            }

        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBolumId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBolumAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Bolumler set BolumAdi = @P1 where BolumId = @P2", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@P2", txtBolumId.Text);
                sqlCommand.Parameters.AddWithValue("@P1", txtBolumAd.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
                this.bolumlerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Gerçekleştirilemedi.");
            }

        }
    }
}
