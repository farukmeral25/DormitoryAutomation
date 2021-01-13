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
using System.Net.Http.Headers;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class frmYoneticiIslemleri : Form
    {
        public frmYoneticiIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void lblKullaniciSifre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet5.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into Admin(YoneticiAd,YoneticiSifre) values (@p1,@p2)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı.");
                this.adminTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme İşlemi Başarısız.");
            }
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Delete From Admin where YoneticiId = @p1", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtKullaniciId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");
                this.adminTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirilemedi.");
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKullaniciId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where YoneticiId = @p3", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtSifre.Text);
                sqlCommand.Parameters.AddWithValue("@p3", txtKullaniciId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Güncelleme Başarılı.");
                this.adminTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet5.Admin);

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız.");
            }
            

        }
    }
}
