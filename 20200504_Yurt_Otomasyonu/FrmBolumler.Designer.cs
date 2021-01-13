namespace _20200504_Yurt_Otomasyonu
{
    partial class FrmBolumler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbEkle = new System.Windows.Forms.PictureBox();
            this.pcbSil = new System.Windows.Forms.PictureBox();
            this.pcbDuzenle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumId = new System.Windows.Forms.TextBox();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBYURTOTOMASYONUDataSet = new _20200504_Yurt_Otomasyonu.DBYURTOTOMASYONUDataSet();
            this.bolumlerTableAdapter = new _20200504_Yurt_Otomasyonu.DBYURTOTOMASYONUDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBYURTOTOMASYONUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbEkle
            // 
            this.pcbEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbEkle.Image")));
            this.pcbEkle.Location = new System.Drawing.Point(224, 41);
            this.pcbEkle.Name = "pcbEkle";
            this.pcbEkle.Size = new System.Drawing.Size(50, 43);
            this.pcbEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbEkle.TabIndex = 0;
            this.pcbEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbEkle, "Bölüm Ekle");
            this.pcbEkle.Click += new System.EventHandler(this.pcbEkle_Click);
            // 
            // pcbSil
            // 
            this.pcbSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbSil.Image")));
            this.pcbSil.Location = new System.Drawing.Point(280, 41);
            this.pcbSil.Name = "pcbSil";
            this.pcbSil.Size = new System.Drawing.Size(50, 43);
            this.pcbSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSil.TabIndex = 1;
            this.pcbSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbSil, "Bölüm Sil");
            this.pcbSil.Click += new System.EventHandler(this.pcbSil_Click);
            // 
            // pcbDuzenle
            // 
            this.pcbDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuzenle.Image")));
            this.pcbDuzenle.Location = new System.Drawing.Point(336, 41);
            this.pcbDuzenle.Name = "pcbDuzenle";
            this.pcbDuzenle.Size = new System.Drawing.Size(50, 43);
            this.pcbDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDuzenle.TabIndex = 2;
            this.pcbDuzenle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbDuzenle, "Bölüm Güncelle");
            this.pcbDuzenle.Click += new System.EventHandler(this.pcbDuzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm Id:";
            // 
            // txtBolumId
            // 
            this.txtBolumId.Enabled = false;
            this.txtBolumId.Location = new System.Drawing.Point(93, 33);
            this.txtBolumId.Name = "txtBolumId";
            this.txtBolumId.Size = new System.Drawing.Size(100, 20);
            this.txtBolumId.TabIndex = 4;
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(93, 70);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(100, 20);
            this.txtBolumAd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Ad:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumIdDataGridViewTextBoxColumn,
            this.bolumAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 190);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumIdDataGridViewTextBoxColumn
            // 
            this.bolumIdDataGridViewTextBoxColumn.DataPropertyName = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.HeaderText = "BolumId";
            this.bolumIdDataGridViewTextBoxColumn.Name = "bolumIdDataGridViewTextBoxColumn";
            this.bolumIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdiDataGridViewTextBoxColumn
            // 
            this.bolumAdiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdiDataGridViewTextBoxColumn.DataPropertyName = "BolumAdi";
            this.bolumAdiDataGridViewTextBoxColumn.HeaderText = "BolumAdi";
            this.bolumAdiDataGridViewTextBoxColumn.Name = "bolumAdiDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.dBYURTOTOMASYONUDataSet;
            // 
            // dBYURTOTOMASYONUDataSet
            // 
            this.dBYURTOTOMASYONUDataSet.DataSetName = "DBYURTOTOMASYONUDataSet";
            this.dBYURTOTOMASYONUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(396, 299);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbDuzenle);
            this.Controls.Add(this.pcbSil);
            this.Controls.Add(this.pcbEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBolumler";
            this.Text = "FrmBolumler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBYURTOTOMASYONUDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbEkle;
        private System.Windows.Forms.PictureBox pcbSil;
        private System.Windows.Forms.PictureBox pcbDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumId;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBYURTOTOMASYONUDataSet dBYURTOTOMASYONUDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private DBYURTOTOMASYONUDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}