
namespace Projet_Gueguen_Csharp
{
    partial class Form_GestionProduitStock
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
            this.labelStatusProduit = new System.Windows.Forms.Label();
            this.bsCategorie = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtidRestau = new System.Windows.Forms.TextBox();
            this.lblNewProd = new System.Windows.Forms.Label();
            this.txtNomProd = new System.Windows.Forms.TextBox();
            this.descri = new System.Windows.Forms.TextBox();
            this.panewProd = new System.Windows.Forms.Panel();
            this.labelCatego = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValideProd = new Guna.UI2.WinForms.Guna2Button();
            this.cbCatego = new System.Windows.Forms.ComboBox();
            this.panelSeuil = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNValidProd = new Guna.UI2.WinForms.Guna2Button();
            this.txtimg_prod = new System.Windows.Forms.TextBox();
            this.txtSeuilMax = new System.Windows.Forms.TextBox();
            this.txtseuilMin = new System.Windows.Forms.TextBox();
            this.txtseuilActuel = new System.Windows.Forms.TextBox();
            this.txtprixHTPROD = new System.Windows.Forms.TextBox();
            this.labelAfterProd = new System.Windows.Forms.Label();
            this.modifProd = new Guna.UI2.WinForms.Guna2Button();
            this.txtidCatego = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).BeginInit();
            this.panewProd.SuspendLayout();
            this.panelSeuil.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatusProduit
            // 
            this.labelStatusProduit.AutoSize = true;
            this.labelStatusProduit.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusProduit.Location = new System.Drawing.Point(12, 9);
            this.labelStatusProduit.Name = "labelStatusProduit";
            this.labelStatusProduit.Size = new System.Drawing.Size(237, 22);
            this.labelStatusProduit.TabIndex = 0;
            this.labelStatusProduit.Text = "Ajout d\'un produit";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(309, 12);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(100, 22);
            this.txtIdProd.TabIndex = 4;
            this.txtIdProd.Visible = false;
            // 
            // txtidRestau
            // 
            this.txtidRestau.Location = new System.Drawing.Point(309, 40);
            this.txtidRestau.Name = "txtidRestau";
            this.txtidRestau.Size = new System.Drawing.Size(100, 22);
            this.txtidRestau.TabIndex = 5;
            this.txtidRestau.Visible = false;
            // 
            // lblNewProd
            // 
            this.lblNewProd.AutoSize = true;
            this.lblNewProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewProd.Location = new System.Drawing.Point(24, 95);
            this.lblNewProd.Name = "lblNewProd";
            this.lblNewProd.Size = new System.Drawing.Size(211, 20);
            this.lblNewProd.TabIndex = 6;
            this.lblNewProd.Text = "Configuration du produit";
            // 
            // txtNomProd
            // 
            this.txtNomProd.Location = new System.Drawing.Point(23, 39);
            this.txtNomProd.Name = "txtNomProd";
            this.txtNomProd.Size = new System.Drawing.Size(100, 22);
            this.txtNomProd.TabIndex = 7;
            this.txtNomProd.TextChanged += new System.EventHandler(this.txtNomProd_TextChanged);
            // 
            // descri
            // 
            this.descri.Location = new System.Drawing.Point(172, 39);
            this.descri.Name = "descri";
            this.descri.Size = new System.Drawing.Size(100, 22);
            this.descri.TabIndex = 9;
            this.descri.TextChanged += new System.EventHandler(this.descri_TextChanged);
            // 
            // panewProd
            // 
            this.panewProd.Controls.Add(this.labelCatego);
            this.panewProd.Controls.Add(this.label2);
            this.panewProd.Controls.Add(this.label1);
            this.panewProd.Controls.Add(this.btnValideProd);
            this.panewProd.Controls.Add(this.cbCatego);
            this.panewProd.Controls.Add(this.txtNomProd);
            this.panewProd.Controls.Add(this.descri);
            this.panewProd.Location = new System.Drawing.Point(28, 134);
            this.panewProd.Name = "panewProd";
            this.panewProd.Size = new System.Drawing.Size(297, 238);
            this.panewProd.TabIndex = 11;
            // 
            // labelCatego
            // 
            this.labelCatego.AutoSize = true;
            this.labelCatego.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCatego.Location = new System.Drawing.Point(95, 85);
            this.labelCatego.Name = "labelCatego";
            this.labelCatego.Size = new System.Drawing.Size(78, 17);
            this.labelCatego.TabIndex = 16;
            this.labelCatego.Text = "Catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Description Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom Produit";
            // 
            // btnValideProd
            // 
            this.btnValideProd.BorderRadius = 20;
            this.btnValideProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValideProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValideProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValideProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValideProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(32)))));
            this.btnValideProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValideProd.ForeColor = System.Drawing.Color.White;
            this.btnValideProd.Location = new System.Drawing.Point(50, 179);
            this.btnValideProd.Name = "btnValideProd";
            this.btnValideProd.Size = new System.Drawing.Size(180, 45);
            this.btnValideProd.TabIndex = 0;
            this.btnValideProd.Text = "Valider";
            this.btnValideProd.Click += new System.EventHandler(this.btnValideProd_Click);
            // 
            // cbCatego
            // 
            this.cbCatego.FormattingEnabled = true;
            this.cbCatego.Location = new System.Drawing.Point(50, 105);
            this.cbCatego.Name = "cbCatego";
            this.cbCatego.Size = new System.Drawing.Size(160, 24);
            this.cbCatego.TabIndex = 12;
            this.cbCatego.SelectedIndexChanged += new System.EventHandler(this.cbCatego_SelectedIndexChanged);
            // 
            // panelSeuil
            // 
            this.panelSeuil.Controls.Add(this.label7);
            this.panelSeuil.Controls.Add(this.label6);
            this.panelSeuil.Controls.Add(this.label5);
            this.panelSeuil.Controls.Add(this.label4);
            this.panelSeuil.Controls.Add(this.label3);
            this.panelSeuil.Controls.Add(this.BTNValidProd);
            this.panelSeuil.Controls.Add(this.txtimg_prod);
            this.panelSeuil.Controls.Add(this.txtSeuilMax);
            this.panelSeuil.Controls.Add(this.txtseuilMin);
            this.panelSeuil.Controls.Add(this.txtseuilActuel);
            this.panelSeuil.Controls.Add(this.txtprixHTPROD);
            this.panelSeuil.Location = new System.Drawing.Point(390, 131);
            this.panelSeuil.Name = "panelSeuil";
            this.panelSeuil.Size = new System.Drawing.Size(404, 241);
            this.panelSeuil.TabIndex = 12;
            this.panelSeuil.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(136, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "img Prod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(212, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "seuil Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "seuil Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "seuil Actu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "PRIX HT PROD";
            // 
            // BTNValidProd
            // 
            this.BTNValidProd.BorderRadius = 20;
            this.BTNValidProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTNValidProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTNValidProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTNValidProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BTNValidProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(32)))));
            this.BTNValidProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNValidProd.ForeColor = System.Drawing.Color.White;
            this.BTNValidProd.Location = new System.Drawing.Point(91, 193);
            this.BTNValidProd.Name = "BTNValidProd";
            this.BTNValidProd.Size = new System.Drawing.Size(180, 45);
            this.BTNValidProd.TabIndex = 17;
            this.BTNValidProd.Text = "Finalisation Produit";
            this.BTNValidProd.Click += new System.EventHandler(this.BTNValidProd_Click);
            // 
            // txtimg_prod
            // 
            this.txtimg_prod.Location = new System.Drawing.Point(124, 150);
            this.txtimg_prod.Name = "txtimg_prod";
            this.txtimg_prod.Size = new System.Drawing.Size(100, 22);
            this.txtimg_prod.TabIndex = 4;
            this.txtimg_prod.TextChanged += new System.EventHandler(this.txtimg_prod_TextChanged);
            // 
            // txtSeuilMax
            // 
            this.txtSeuilMax.Location = new System.Drawing.Point(215, 83);
            this.txtSeuilMax.Name = "txtSeuilMax";
            this.txtSeuilMax.Size = new System.Drawing.Size(100, 22);
            this.txtSeuilMax.TabIndex = 3;
            this.txtSeuilMax.TextChanged += new System.EventHandler(this.txtSeuilMax_TextChanged);
            // 
            // txtseuilMin
            // 
            this.txtseuilMin.Location = new System.Drawing.Point(27, 83);
            this.txtseuilMin.Name = "txtseuilMin";
            this.txtseuilMin.Size = new System.Drawing.Size(100, 22);
            this.txtseuilMin.TabIndex = 2;
            this.txtseuilMin.TextChanged += new System.EventHandler(this.txtseuilMin_TextChanged);
            // 
            // txtseuilActuel
            // 
            this.txtseuilActuel.Location = new System.Drawing.Point(215, 32);
            this.txtseuilActuel.Name = "txtseuilActuel";
            this.txtseuilActuel.Size = new System.Drawing.Size(100, 22);
            this.txtseuilActuel.TabIndex = 1;
            this.txtseuilActuel.TextChanged += new System.EventHandler(this.txtseuilActuel_TextChanged);
            // 
            // txtprixHTPROD
            // 
            this.txtprixHTPROD.Location = new System.Drawing.Point(27, 32);
            this.txtprixHTPROD.Name = "txtprixHTPROD";
            this.txtprixHTPROD.Size = new System.Drawing.Size(100, 22);
            this.txtprixHTPROD.TabIndex = 0;
            this.txtprixHTPROD.TextChanged += new System.EventHandler(this.txtprixHTPROD_TextChanged);
            // 
            // labelAfterProd
            // 
            this.labelAfterProd.AutoSize = true;
            this.labelAfterProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAfterProd.Location = new System.Drawing.Point(404, 97);
            this.labelAfterProd.Name = "labelAfterProd";
            this.labelAfterProd.Size = new System.Drawing.Size(166, 20);
            this.labelAfterProd.TabIndex = 13;
            this.labelAfterProd.Text = "Configuration Prod";
            this.labelAfterProd.Visible = false;
            // 
            // modifProd
            // 
            this.modifProd.BorderRadius = 20;
            this.modifProd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.modifProd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.modifProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.modifProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.modifProd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(32)))));
            this.modifProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modifProd.ForeColor = System.Drawing.Color.White;
            this.modifProd.Location = new System.Drawing.Point(282, 414);
            this.modifProd.Name = "modifProd";
            this.modifProd.Size = new System.Drawing.Size(180, 45);
            this.modifProd.TabIndex = 22;
            this.modifProd.Text = "Produit";
            this.modifProd.Visible = false;
            this.modifProd.Click += new System.EventHandler(this.modifProd_Click);
            // 
            // txtidCatego
            // 
            this.txtidCatego.Location = new System.Drawing.Point(429, 12);
            this.txtidCatego.Name = "txtidCatego";
            this.txtidCatego.Size = new System.Drawing.Size(100, 22);
            this.txtidCatego.TabIndex = 23;
            this.txtidCatego.Visible = false;
            // 
            // Form_GestionProduitStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 523);
            this.Controls.Add(this.txtidCatego);
            this.Controls.Add(this.modifProd);
            this.Controls.Add(this.labelAfterProd);
            this.Controls.Add(this.panelSeuil);
            this.Controls.Add(this.panewProd);
            this.Controls.Add(this.lblNewProd);
            this.Controls.Add(this.txtidRestau);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.labelStatusProduit);
            this.Name = "Form_GestionProduitStock";
            this.Text = "Form_GestionStock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_GestionProduitStock_FormClosed);
            this.Load += new System.EventHandler(this.Form_GestionProduitStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCategorie)).EndInit();
            this.panewProd.ResumeLayout(false);
            this.panewProd.PerformLayout();
            this.panelSeuil.ResumeLayout(false);
            this.panelSeuil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatusProduit;
        private System.Windows.Forms.BindingSource bsCategorie;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.TextBox txtidRestau;
        private System.Windows.Forms.Label lblNewProd;
        private System.Windows.Forms.TextBox txtNomProd;
        private System.Windows.Forms.TextBox descri;
        private System.Windows.Forms.Panel panewProd;
        private System.Windows.Forms.ComboBox cbCatego;
        private System.Windows.Forms.Panel panelSeuil;
        private System.Windows.Forms.Label labelAfterProd;
        private Guna.UI2.WinForms.Guna2Button btnValideProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCatego;
        private System.Windows.Forms.TextBox txtimg_prod;
        private System.Windows.Forms.TextBox txtSeuilMax;
        private System.Windows.Forms.TextBox txtseuilMin;
        private System.Windows.Forms.TextBox txtseuilActuel;
        private System.Windows.Forms.TextBox txtprixHTPROD;
        private Guna.UI2.WinForms.Guna2Button BTNValidProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button modifProd;
        private System.Windows.Forms.TextBox txtidCatego;
    }
}