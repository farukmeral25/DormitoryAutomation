namespace _20200504_Yurt_Otomasyonu
{
    partial class FrmGelirIstatistik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirIstatistik));
            this.lblKasadakiPara = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.cbxAy = new System.Windows.Forms.ComboBox();
            this.lblAySecin = new System.Windows.Forms.Label();
            this.lblAyKazanc = new System.Windows.Forms.Label();
            this.lblsecilenAy = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKasadakiPara
            // 
            this.lblKasadakiPara.AutoSize = true;
            this.lblKasadakiPara.Location = new System.Drawing.Point(274, 12);
            this.lblKasadakiPara.Name = "lblKasadakiPara";
            this.lblKasadakiPara.Size = new System.Drawing.Size(82, 13);
            this.lblKasadakiPara.TabIndex = 0;
            this.lblKasadakiPara.Text = "Kasadaki Para :";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(362, 12);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(13, 13);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "0";
            // 
            // cbxAy
            // 
            this.cbxAy.FormattingEnabled = true;
            this.cbxAy.Location = new System.Drawing.Point(70, 9);
            this.cbxAy.Name = "cbxAy";
            this.cbxAy.Size = new System.Drawing.Size(131, 21);
            this.cbxAy.TabIndex = 2;
            this.cbxAy.SelectedIndexChanged += new System.EventHandler(this.cbxAy_SelectedIndexChanged);
            // 
            // lblAySecin
            // 
            this.lblAySecin.AutoSize = true;
            this.lblAySecin.Location = new System.Drawing.Point(12, 12);
            this.lblAySecin.Name = "lblAySecin";
            this.lblAySecin.Size = new System.Drawing.Size(52, 13);
            this.lblAySecin.TabIndex = 3;
            this.lblAySecin.Text = "Ay Seçin:";
            // 
            // lblAyKazanc
            // 
            this.lblAyKazanc.AutoSize = true;
            this.lblAyKazanc.Location = new System.Drawing.Point(362, 40);
            this.lblAyKazanc.Name = "lblAyKazanc";
            this.lblAyKazanc.Size = new System.Drawing.Size(13, 13);
            this.lblAyKazanc.TabIndex = 5;
            this.lblAyKazanc.Text = "0";
            // 
            // lblsecilenAy
            // 
            this.lblsecilenAy.AutoSize = true;
            this.lblsecilenAy.Location = new System.Drawing.Point(274, 40);
            this.lblsecilenAy.Name = "lblsecilenAy";
            this.lblsecilenAy.Size = new System.Drawing.Size(60, 13);
            this.lblsecilenAy.TabIndex = 4;
            this.lblsecilenAy.Text = "Seçilen Ay:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 89);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Aylık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(402, 195);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // FrmGelirIstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(426, 296);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblAyKazanc);
            this.Controls.Add(this.lblsecilenAy);
            this.Controls.Add(this.lblAySecin);
            this.Controls.Add(this.cbxAy);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblKasadakiPara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGelirIstatistik";
            this.Text = "FrmGelirIstatistik";
            this.Load += new System.EventHandler(this.FrmGelirIstatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKasadakiPara;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.ComboBox cbxAy;
        private System.Windows.Forms.Label lblAySecin;
        private System.Windows.Forms.Label lblAyKazanc;
        private System.Windows.Forms.Label lblsecilenAy;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}