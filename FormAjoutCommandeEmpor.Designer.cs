
namespace Projet_Gueguen_Csharp
{
    partial class FormAjoutCommandeEmpor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbPaiement = new System.Windows.Forms.ComboBox();
            this.btnValiderEmporter = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtModePaiement = new System.Windows.Forms.TextBox();
            this.labelMoyenPaie = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.textboxClient = new System.Windows.Forms.TextBox();
            this.labelResultat = new System.Windows.Forms.Label();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.bsPaiement = new System.Windows.Forms.BindingSource(this.components);
            this.txtNumCom = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaiement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Commande A Emporter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(47, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(47, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paiement";
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(50, 123);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(121, 24);
            this.cbClient.TabIndex = 1;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // cbPaiement
            // 
            this.cbPaiement.FormattingEnabled = true;
            this.cbPaiement.Location = new System.Drawing.Point(51, 195);
            this.cbPaiement.Name = "cbPaiement";
            this.cbPaiement.Size = new System.Drawing.Size(121, 24);
            this.cbPaiement.TabIndex = 1;
            this.cbPaiement.SelectedIndexChanged += new System.EventHandler(this.cbPaiement_SelectedIndexChanged);
            // 
            // btnValiderEmporter
            // 
            this.btnValiderEmporter.BorderRadius = 10;
            this.btnValiderEmporter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderEmporter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderEmporter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValiderEmporter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValiderEmporter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValiderEmporter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValiderEmporter.ForeColor = System.Drawing.Color.White;
            this.btnValiderEmporter.Location = new System.Drawing.Point(86, 267);
            this.btnValiderEmporter.Name = "btnValiderEmporter";
            this.btnValiderEmporter.Size = new System.Drawing.Size(128, 35);
            this.btnValiderEmporter.TabIndex = 5;
            this.btnValiderEmporter.Text = "Valider";
            this.btnValiderEmporter.Click += new System.EventHandler(this.btnValiderEmporter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtModePaiement);
            this.panel1.Controls.Add(this.labelMoyenPaie);
            this.panel1.Controls.Add(this.labelClient);
            this.panel1.Controls.Add(this.textboxClient);
            this.panel1.Location = new System.Drawing.Point(192, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 155);
            this.panel1.TabIndex = 6;
            // 
            // txtModePaiement
            // 
            this.txtModePaiement.Enabled = false;
            this.txtModePaiement.Location = new System.Drawing.Point(17, 80);
            this.txtModePaiement.Name = "txtModePaiement";
            this.txtModePaiement.Size = new System.Drawing.Size(100, 22);
            this.txtModePaiement.TabIndex = 3;
            // 
            // labelMoyenPaie
            // 
            this.labelMoyenPaie.AutoSize = true;
            this.labelMoyenPaie.Location = new System.Drawing.Point(14, 60);
            this.labelMoyenPaie.Name = "labelMoyenPaie";
            this.labelMoyenPaie.Size = new System.Drawing.Size(113, 17);
            this.labelMoyenPaie.TabIndex = 2;
            this.labelMoyenPaie.Text = "Moyen Paiement";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(14, 13);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(70, 17);
            this.labelClient.TabIndex = 1;
            this.labelClient.Text = "nomClient";
            // 
            // textboxClient
            // 
            this.textboxClient.Enabled = false;
            this.textboxClient.Location = new System.Drawing.Point(17, 35);
            this.textboxClient.Name = "textboxClient";
            this.textboxClient.Size = new System.Drawing.Size(100, 22);
            this.textboxClient.TabIndex = 0;
            // 
            // labelResultat
            // 
            this.labelResultat.AutoSize = true;
            this.labelResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultat.Location = new System.Drawing.Point(343, 67);
            this.labelResultat.Name = "labelResultat";
            this.labelResultat.Size = new System.Drawing.Size(79, 20);
            this.labelResultat.TabIndex = 7;
            this.labelResultat.Text = "Résultat";
            // 
            // bsClient
            // 
            this.bsClient.CurrentChanged += new System.EventHandler(this.bsClient_CurrentChanged);
            // 
            // bsPaiement
            // 
            this.bsPaiement.CurrentChanged += new System.EventHandler(this.bsPaiement_CurrentChanged);
            // 
            // txtNumCom
            // 
            this.txtNumCom.Location = new System.Drawing.Point(347, 13);
            this.txtNumCom.Name = "txtNumCom";
            this.txtNumCom.Size = new System.Drawing.Size(50, 22);
            this.txtNumCom.TabIndex = 8;
            this.txtNumCom.Visible = false;
            // 
            // FormAjoutCommandeEmpor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 331);
            this.Controls.Add(this.txtNumCom);
            this.Controls.Add(this.labelResultat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnValiderEmporter);
            this.Controls.Add(this.cbPaiement);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAjoutCommandeEmpor";
            this.Text = "FormAjoutCommandeEmpor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutCommandeEmpor_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutCommandeEmpor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPaiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbPaiement;
        public Guna.UI2.WinForms.Guna2Button btnValiderEmporter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textboxClient;
        private System.Windows.Forms.Label labelResultat;
        private System.Windows.Forms.Label labelMoyenPaie;
        private System.Windows.Forms.TextBox txtModePaiement;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.BindingSource bsPaiement;
        private System.Windows.Forms.TextBox txtNumCom;
    }
}