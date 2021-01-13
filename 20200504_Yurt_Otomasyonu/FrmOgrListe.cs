using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200504_Yurt_Otomasyonu
{
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }

        private void FrmOgrListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet3.Ogrenciler' table. You can move, or remove it, as needed.
            this.ogrencilerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet3.Ogrenciler);

        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle frmOgrDuzenle = new FrmOgrDuzenle();
            frmOgrDuzenle.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frmOgrDuzenle.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frmOgrDuzenle.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frmOgrDuzenle.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frmOgrDuzenle.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frmOgrDuzenle.dogumTarihi = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frmOgrDuzenle.bolum = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frmOgrDuzenle.mail = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frmOgrDuzenle.odano = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            frmOgrDuzenle.veliAdSoyad = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            frmOgrDuzenle.veliTelefon = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            frmOgrDuzenle.adres = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            
            frmOgrDuzenle.Show();
        }
    }
}
