
namespace Projet_Gueguen_Csharp
{
    partial class Statistiques_Gueguen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel_stat = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_nomProd = new System.Windows.Forms.DataGridView();
            this.dgv_nbProduit = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_choixPeriode = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dvg_commandeSurPlace = new System.Windows.Forms.DataGridView();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dgvCommandeAemporter = new System.Windows.Forms.DataGridView();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.bsBestProd = new System.Windows.Forms.BindingSource(this.components);
            this.bsNomProd = new System.Windows.Forms.BindingSource(this.components);
            this.bsCommandeSurPlace = new System.Windows.Forms.BindingSource(this.components);
            this.bsCommandeAemporter = new System.Windows.Forms.BindingSource(this.components);
            this.panel_stat.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nomProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nbProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_commandeSurPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeAemporter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBestProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNomProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommandeSurPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommandeAemporter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_stat
            // 
            this.panel_stat.BackColor = System.Drawing.Color.Transparent;
            this.panel_stat.Controls.Add(this.tabControl1);
            this.panel_stat.Controls.Add(this.guna2GroupBox1);
            this.panel_stat.Location = new System.Drawing.Point(1, 0);
            this.panel_stat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_stat.Name = "panel_stat";
            this.panel_stat.Size = new System.Drawing.Size(895, 561);
            this.panel_stat.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv_nomProd);
            this.tabPage1.Controls.Add(this.dgv_nbProduit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbb_choixPeriode);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(832, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produit le plus commandé";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(769, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aucune commande n\'as été faites durant cette période. ";
            this.label3.Visible = false;
            // 
            // dgv_nomProd
            // 
            this.dgv_nomProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nomProd.Location = new System.Drawing.Point(60, 337);
            this.dgv_nomProd.Name = "dgv_nomProd";
            this.dgv_nomProd.RowHeadersWidth = 62;
            this.dgv_nomProd.RowTemplate.Height = 28;
            this.dgv_nomProd.Size = new System.Drawing.Size(84, 53);
            this.dgv_nomProd.TabIndex = 6;
            this.dgv_nomProd.Visible = false;
            // 
            // dgv_nbProduit
            // 
            this.dgv_nbProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nbProduit.Location = new System.Drawing.Point(606, 349);
            this.dgv_nbProduit.Name = "dgv_nbProduit";
            this.dgv_nbProduit.RowHeadersWidth = 62;
            this.dgv_nbProduit.RowTemplate.Height = 28;
            this.dgv_nbProduit.Size = new System.Drawing.Size(203, 38);
            this.dgv_nbProduit.TabIndex = 5;
            this.dgv_nbProduit.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choix de la date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 26);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(445, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choix de la période ";
            // 
            // cbb_choixPeriode
            // 
            this.cbb_choixPeriode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_choixPeriode.FormattingEnabled = true;
            this.cbb_choixPeriode.Location = new System.Drawing.Point(652, 23);
            this.cbb_choixPeriode.Name = "cbb_choixPeriode";
            this.cbb_choixPeriode.Size = new System.Drawing.Size(121, 28);
            this.cbb_choixPeriode.TabIndex = 1;
            this.cbb_choixPeriode.SelectedIndexChanged += new System.EventHandler(this.cbb_choixPeriode_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 71);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(820, 277);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dvg_commandeSurPlace);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.dgvCommandeAemporter);
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(832, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nombre de commande";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre de commande";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(769, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aucune commande n\'as été faites durant cette période. ";
            this.label4.Visible = false;
            // 
            // dvg_commandeSurPlace
            // 
            this.dvg_commandeSurPlace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_commandeSurPlace.Location = new System.Drawing.Point(139, 197);
            this.dvg_commandeSurPlace.Name = "dvg_commandeSurPlace";
            this.dvg_commandeSurPlace.RowHeadersWidth = 62;
            this.dvg_commandeSurPlace.RowTemplate.Height = 28;
            this.dvg_commandeSurPlace.Size = new System.Drawing.Size(43, 118);
            this.dvg_commandeSurPlace.TabIndex = 3;
            this.dvg_commandeSurPlace.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(239, 26);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dgvCommandeAemporter
            // 
            this.dgvCommandeAemporter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommandeAemporter.Location = new System.Drawing.Point(49, 197);
            this.dgvCommandeAemporter.Name = "dgvCommandeAemporter";
            this.dgvCommandeAemporter.RowHeadersWidth = 62;
            this.dgvCommandeAemporter.RowTemplate.Height = 28;
            this.dgvCommandeAemporter.Size = new System.Drawing.Size(52, 118);
            this.dgvCommandeAemporter.TabIndex = 1;
            this.dgvCommandeAemporter.Visible = false;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(251, 35);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "s1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(575, 355);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(26, 34);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(846, 492);
            this.guna2GroupBox1.TabIndex = 2;
            // 
            // Statistiques_Gueguen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel_stat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Statistiques_Gueguen";
            this.Text = "Statistiques_Gueguen";
            this.Load += new System.EventHandler(this.Statistiques_Gueguen_Load);
            this.panel_stat.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nomProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nbProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_commandeSurPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommandeAemporter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBestProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNomProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommandeSurPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCommandeAemporter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_stat;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.BindingSource bsBestProd;
        private System.Windows.Forms.BindingSource bsNomProd;
        private System.Windows.Forms.BindingSource bsCommandeSurPlace;
        private System.Windows.Forms.BindingSource bsCommandeAemporter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_nomProd;
        private System.Windows.Forms.DataGridView dgv_nbProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_choixPeriode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvg_commandeSurPlace;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgvCommandeAemporter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}