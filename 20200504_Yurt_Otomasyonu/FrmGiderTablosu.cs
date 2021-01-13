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
    public partial class FrmGiderTablosu : Form
    {
        public FrmGiderTablosu()
        {
            InitializeComponent();
        }

        private void FrmGiderTablosu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBYURTOTOMASYONUDataSet4.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.dBYURTOTOMASYONUDataSet4.Giderler);

        }
        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmGiderGuncelle frmGiderGuncelle = new FrmGiderGuncelle();
            frmGiderGuncelle.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frmGiderGuncelle.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frmGiderGuncelle.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frmGiderGuncelle.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frmGiderGuncelle.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frmGiderGuncelle.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frmGiderGuncelle.personelgider = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frmGiderGuncelle.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frmGiderGuncelle.Show();
        }
    }
}
