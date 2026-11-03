
namespace Projet_Gueguen_Csharp
{
    partial class FormGestionStock
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
            this.btnArchivProd = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnArchiverProd = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjoutProduit = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifProduit = new Guna.UI2.WinForms.Guna2Button();
            this.dtStock = new System.Windows.Forms.DataGridView();
            this.lbl_quantite = new System.Windows.Forms.Label();
            this.txtQTE = new System.Windows.Forms.TextBox();
            this.btn_Commander = new Guna.UI2.WinForms.Guna2Button();
            this.RecherchetxtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.panelGestionStock = new System.Windows.Forms.Panel();
            this.bsStock = new System.Windows.Forms.BindingSource(this.components);
            this.btnArchivProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).BeginInit();
            this.panelGestionStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArchivProd
            // 
            this.btnArchivProd.BackColor = System.Drawing.Color.Transparent;
            this.btnArchivProd.BorderRadius = 20;
            this.btnArchivProd.Controls.Add(this.btnArchiverProd);
            this.btnArchivProd.Controls.Add(this.btnAjoutProduit);
            this.btnArchivProd.Controls.Add(this.btnModifProduit);
            this.btnArchivProd.Controls.Add(this.dtStock);
            this.btnArchivProd.Controls.Add(this.lbl_quantite);
            this.btnArchivProd.Controls.Add(this.txtQTE);
            this.btnArchivProd.Controls.Add(this.btn_Commander);
            this.btnArchivProd.Controls.Add(this.RecherchetxtStock);
            this.btnArchivProd.Controls.Add(this.labelStock);
            this.btnArchivProd.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnArchivProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnArchivProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnArchivProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnArchivProd.Location = new System.Drawing.Point(23, 25);
            this.btnArchivProd.Name = "btnArchivProd";
            this.btnArchivProd.Size = new System.Drawing.Size(752, 413);
            this.btnArchivProd.TabIndex = 2;
            // 
            // btnArchiverProd
            // 
            this.btnArchiverProd.BorderRadius = 20;
            this.btnArchiverProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnArchiverProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnArchiverProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnArchiverProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnArchiverProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnArchiverProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiverProd.ForeColor = System.Drawing.Color.White;
            this.btnArchiverProd.Location = new System.Drawing.Point(288, 335);
            this.btnArchiverProd.Name = "btnArchiverProd";
            this.btnArchiverProd.Size = new System.Drawing.Size(180, 45);
            this.btnArchiverProd.TabIndex = 9;
            this.btnArchiverProd.Text = "Archiver";
            this.btnArchiverProd.Click += new System.EventHandler(this.btnArchiverProd_Click);
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.BorderRadius = 20;
            this.btnAjoutProduit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjoutProduit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjoutProduit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjoutProduit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjoutProduit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnAjoutProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutProduit.ForeColor = System.Drawing.Color.White;
            this.btnAjoutProduit.Location = new System.Drawing.Point(41, 313);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(180, 45);
            this.btnAjoutProduit.TabIndex = 8;
            this.btnAjoutProduit.Text = "Ajout Produit";
            this.btnAjoutProduit.Click += new System.EventHandler(this.btnAjoutProduit_Click);
            // 
            // btnModifProduit
            // 
            this.btnModifProduit.BorderRadius = 20;
            this.btnModifProduit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifProduit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifProduit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifProduit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifProduit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnModifProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifProduit.ForeColor = System.Drawing.Color.White;
            this.btnModifProduit.Location = new System.Drawing.Point(41, 364);
            this.btnModifProduit.Name = "btnModifProduit";
            this.btnModifProduit.Size = new System.Drawing.Size(180, 45);
            this.btnModifProduit.TabIndex = 7;
            this.btnModifProduit.Text = "Modifier Produit";
            this.btnModifProduit.Click += new System.EventHandler(this.btnModifProduit_Click);
            // 
            // dtStock
            // 
            this.dtStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStock.Location = new System.Drawing.Point(41, 93);
            this.dtStock.Name = "dtStock";
            this.dtStock.RowHeadersWidth = 51;
            this.dtStock.RowTemplate.Height = 24;
            this.dtStock.Size = new System.Drawing.Size(678, 214);
            this.dtStock.TabIndex = 6;
            // 
            // lbl_quantite
            // 
            this.lbl_quantite.AutoSize = true;
            this.lbl_quantite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantite.ForeColor = System.Drawing.Color.Black;
            this.lbl_quantite.Location = new System.Drawing.Point(503, 314);
            this.lbl_quantite.Name = "lbl_quantite";
            this.lbl_quantite.Size = new System.Drawing.Size(85, 20);
            this.lbl_quantite.TabIndex = 5;
            this.lbl_quantite.Text = "QUANTITÉ";
            // 
            // txtQTE
            // 
            this.txtQTE.Location = new System.Drawing.Point(594, 311);
            this.txtQTE.Name = "txtQTE";
            this.txtQTE.Size = new System.Drawing.Size(82, 27);
            this.txtQTE.TabIndex = 4;
            // 
            // btn_Commander
            // 
            this.btn_Commander.BorderRadius = 20;
            this.btn_Commander.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Commander.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Commander.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Commander.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Commander.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Commander.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Commander.ForeColor = System.Drawing.Color.White;
            this.btn_Commander.Location = new System.Drawing.Point(539, 344);
            this.btn_Commander.Name = "btn_Commander";
            this.btn_Commander.Size = new System.Drawing.Size(180, 45);
            this.btn_Commander.TabIndex = 3;
            this.btn_Commander.Text = "Commander";
            this.btn_Commander.Click += new System.EventHandler(this.btn_Commander_Click);
            // 
            // RecherchetxtStock
            // 
            this.RecherchetxtStock.BorderRadius = 20;
            this.RecherchetxtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecherchetxtStock.DefaultText = "Recherche";
            this.RecherchetxtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RecherchetxtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RecherchetxtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RecherchetxtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtStock.Location = new System.Drawing.Point(426, 21);
            this.RecherchetxtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecherchetxtStock.Name = "RecherchetxtStock";
            this.RecherchetxtStock.PasswordChar = '\0';
            this.RecherchetxtStock.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RecherchetxtStock.PlaceholderText = "";
            this.RecherchetxtStock.SelectedText = "";
            this.RecherchetxtStock.Size = new System.Drawing.Size(305, 48);
            this.RecherchetxtStock.TabIndex = 1;
            this.RecherchetxtStock.TextChanged += new System.EventHandler(this.RecherchetxtStock_TextChanged);
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.Color.Black;
            this.labelStock.Location = new System.Drawing.Point(37, 61);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(123, 20);
            this.labelStock.TabIndex = 0;
            this.labelStock.Text = "LISTE DES STOCK";
            // 
            // panelGestionStock
            // 
            this.panelGestionStock.BackColor = System.Drawing.Color.Transparent;
            this.panelGestionStock.Controls.Add(this.btnArchivProd);
            this.panelGestionStock.Location = new System.Drawing.Point(2, -1);
            this.panelGestionStock.Name = "panelGestionStock";
            this.panelGestionStock.Size = new System.Drawing.Size(792, 519);
            this.panelGestionStock.TabIndex = 3;
            // 
            // FormGestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 530);
            this.Controls.Add(this.panelGestionStock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionStock";
            this.Text = "FormGestionStock";
            this.Load += new System.EventHandler(this.FormGestionStock_Load);
            this.btnArchivProd.ResumeLayout(false);
            this.btnArchivProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStock)).EndInit();
            this.panelGestionStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox btnArchivProd;
        private System.Windows.Forms.Label lbl_quantite;
        private System.Windows.Forms.TextBox txtQTE;
        private Guna.UI2.WinForms.Guna2Button btn_Commander;
        private Guna.UI2.WinForms.Guna2TextBox RecherchetxtStock;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Panel panelGestionStock;
        private System.Windows.Forms.BindingSource bsStock;
        public System.Windows.Forms.DataGridView dtStock;
        private Guna.UI2.WinForms.Guna2Button btnAjoutProduit;
        private Guna.UI2.WinForms.Guna2Button btnModifProduit;
        private Guna.UI2.WinForms.Guna2Button btnArchiverProd;
    }
}