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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = DBYURTOTOMASYONU; Integrated Security = True");

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet6.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Insert Into Personel(PersonelAdSoyad,PersonelDepartmani) values (@p1,@p2)", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2", txtPersonelDepartmani.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı.");
                this.personelTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet6.Personel);
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
                SqlCommand sqlCommand = new SqlCommand("Delete From Personel where PersonelId = @p1", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtPersonelId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Silme İşlemi Başarılı.");
                this.personelTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet6.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Başarısız.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtPersonelId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtPersonelAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtPersonelDepartmani.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Update Personel set PersonelAdSoyad = @p1 , PersonelDepartmani = @p2 where PersonelId = @p3 ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@p1", txtPersonelAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2",txtPersonelDepartmani.Text);
                sqlCommand.Parameters.AddWithValue("@p3",txtPersonelId.Text);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı.");
                this.personelTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet6.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız.");
            }
        }
    }
}
