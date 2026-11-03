
namespace Projet_Gueguen_Csharp
{
    partial class FormGestionFacture
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelEtat = new System.Windows.Forms.Label();
            this.cbCommande = new System.Windows.Forms.ComboBox();
            this.dtFacture = new System.Windows.Forms.DataGridView();
            this.btn_Archiver = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Payer = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.bsFacture = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacture)).BeginInit();
            this.panelConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.labelEtat);
            this.guna2GroupBox1.Controls.Add(this.cbCommande);
            this.guna2GroupBox1.Controls.Add(this.dtFacture);
            this.guna2GroupBox1.Controls.Add(this.btn_Archiver);
            this.guna2GroupBox1.Controls.Add(this.btn_Payer);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(24, 26);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(752, 414);
            this.guna2GroupBox1.TabIndex = 1;
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.Location = new System.Drawing.Point(304, 75);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(13, 20);
            this.labelEtat.TabIndex = 7;
            this.labelEtat.Text = "l";
            this.labelEtat.Visible = false;
            // 
            // cbCommande
            // 
            this.cbCommande.FormattingEnabled = true;
            this.cbCommande.Items.AddRange(new object[] {
            "Commande sur place",
            "Commande à emporter"});
            this.cbCommande.Location = new System.Drawing.Point(465, 67);
            this.cbCommande.Name = "cbCommande";
            this.cbCommande.Size = new System.Drawing.Size(202, 28);
            this.cbCommande.TabIndex = 6;
            this.cbCommande.SelectedIndexChanged += new System.EventHandler(this.cbCommande_SelectedIndexChanged);
            // 
            // dtFacture
            // 
            this.dtFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFacture.Location = new System.Drawing.Point(59, 116);
            this.dtFacture.Name = "dtFacture";
            this.dtFacture.RowHeadersWidth = 51;
            this.dtFacture.RowTemplate.Height = 24;
            this.dtFacture.Size = new System.Drawing.Size(608, 196);
            this.dtFacture.TabIndex = 5;
            // 
            // btn_Archiver
            // 
            this.btn_Archiver.BorderRadius = 20;
            this.btn_Archiver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Archiver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Archiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Archiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Archiver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Archiver.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archiver.ForeColor = System.Drawing.Color.White;
            this.btn_Archiver.Location = new System.Drawing.Point(465, 337);
            this.btn_Archiver.Name = "btn_Archiver";
            this.btn_Archiver.Size = new System.Drawing.Size(159, 45);
            this.btn_Archiver.TabIndex = 4;
            this.btn_Archiver.Text = "Archiver";
            this.btn_Archiver.Click += new System.EventHandler(this.btn_Archiver_Click);
            // 
            // btn_Payer
            // 
            this.btn_Payer.BorderRadius = 20;
            this.btn_Payer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Payer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Payer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Payer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Payer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Payer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payer.ForeColor = System.Drawing.Color.White;
            this.btn_Payer.Location = new System.Drawing.Point(155, 337);
            this.btn_Payer.Name = "btn_Payer";
            this.btn_Payer.Size = new System.Drawing.Size(180, 45);
            this.btn_Payer.TabIndex = 3;
            this.btn_Payer.Text = "Payer";
            this.btn_Payer.Click += new System.EventHandler(this.btn_Payer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTE DES FACTURES";
            // 
            // panelConnexion
            // 
            this.panelConnexion.BackColor = System.Drawing.Color.Transparent;
            this.panelConnexion.Controls.Add(this.guna2GroupBox1);
            this.panelConnexion.Location = new System.Drawing.Point(0, -1);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(794, 533);
            this.panelConnexion.TabIndex = 2;
            // 
            // FormGestionFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 530);
            this.Controls.Add(this.panelConnexion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionFacture";
            this.Text = "FormDashBoardGueguen";
            this.Load += new System.EventHandler(this.FormGestionFacture_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacture)).EndInit();
            this.panelConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsFacture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_Archiver;
        private Guna.UI2.WinForms.Guna2Button btn_Payer;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.BindingSource bsFacture;
        public System.Windows.Forms.DataGridView dtFacture;
        private System.Windows.Forms.ComboBox cbCommande;
        private System.Windows.Forms.Label labelEtat;
    }
}