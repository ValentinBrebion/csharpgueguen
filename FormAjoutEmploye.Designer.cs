
namespace Projet_Gueguen_Csharp
{
    partial class FormAjoutEmploye
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
            this.labelAjoutServeur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtNaiss = new System.Windows.Forms.DateTimePicker();
            this.labelDateNaiss = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtArriveServeur = new System.Windows.Forms.DateTimePicker();
            this.CheckMdpServeur = new System.Windows.Forms.CheckBox();
            this.labelMdpServeur = new System.Windows.Forms.Label();
            this.txtMdpServeur = new System.Windows.Forms.TextBox();
            this.labelTelServeur = new System.Windows.Forms.Label();
            this.txtTelServeur = new System.Windows.Forms.TextBox();
            this.txtMailServeur = new System.Windows.Forms.TextBox();
            this.labelMailServeur = new System.Windows.Forms.Label();
            this.txtPrenomServeur = new System.Windows.Forms.TextBox();
            this.labelPrenomServeur = new System.Windows.Forms.Label();
            this.labelNomServeur = new System.Windows.Forms.Label();
            this.txtNomServeur = new System.Windows.Forms.TextBox();
            this.btnValiderAjoutServ = new Guna.UI2.WinForms.Guna2Button();
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAjoutServeur
            // 
            this.labelAjoutServeur.AutoSize = true;
            this.labelAjoutServeur.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAjoutServeur.Location = new System.Drawing.Point(12, 28);
            this.labelAjoutServeur.Name = "labelAjoutServeur";
            this.labelAjoutServeur.Size = new System.Drawing.Size(186, 22);
            this.labelAjoutServeur.TabIndex = 1;
            this.labelAjoutServeur.Text = "Ajout Serveur";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtNaiss);
            this.panel1.Controls.Add(this.labelDateNaiss);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtArriveServeur);
            this.panel1.Controls.Add(this.CheckMdpServeur);
            this.panel1.Controls.Add(this.labelMdpServeur);
            this.panel1.Controls.Add(this.txtMdpServeur);
            this.panel1.Controls.Add(this.labelTelServeur);
            this.panel1.Controls.Add(this.txtTelServeur);
            this.panel1.Controls.Add(this.txtMailServeur);
            this.panel1.Controls.Add(this.labelMailServeur);
            this.panel1.Controls.Add(this.txtPrenomServeur);
            this.panel1.Controls.Add(this.labelPrenomServeur);
            this.panel1.Controls.Add(this.labelNomServeur);
            this.panel1.Controls.Add(this.txtNomServeur);
            this.panel1.Location = new System.Drawing.Point(16, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 313);
            this.panel1.TabIndex = 7;
            // 
            // dtNaiss
            // 
            this.dtNaiss.Location = new System.Drawing.Point(169, 90);
            this.dtNaiss.Name = "dtNaiss";
            this.dtNaiss.Size = new System.Drawing.Size(237, 22);
            this.dtNaiss.TabIndex = 16;
            this.dtNaiss.ValueChanged += new System.EventHandler(this.dtNaiss_ValueChanged);
            // 
            // labelDateNaiss
            // 
            this.labelDateNaiss.AutoSize = true;
            this.labelDateNaiss.Location = new System.Drawing.Point(166, 70);
            this.labelDateNaiss.Name = "labelDateNaiss";
            this.labelDateNaiss.Size = new System.Drawing.Size(126, 17);
            this.labelDateNaiss.TabIndex = 15;
            this.labelDateNaiss.Text = "Date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date arrivé Serveur";
            // 
            // dtArriveServeur
            // 
            this.dtArriveServeur.Location = new System.Drawing.Point(169, 35);
            this.dtArriveServeur.Name = "dtArriveServeur";
            this.dtArriveServeur.Size = new System.Drawing.Size(240, 22);
            this.dtArriveServeur.TabIndex = 11;
            this.dtArriveServeur.ValueChanged += new System.EventHandler(this.dtArriveServeur_ValueChanged);
            // 
            // CheckMdpServeur
            // 
            this.CheckMdpServeur.AutoSize = true;
            this.CheckMdpServeur.Location = new System.Drawing.Point(150, 271);
            this.CheckMdpServeur.Name = "CheckMdpServeur";
            this.CheckMdpServeur.Size = new System.Drawing.Size(18, 17);
            this.CheckMdpServeur.TabIndex = 10;
            this.CheckMdpServeur.UseVisualStyleBackColor = true;
            this.CheckMdpServeur.CheckedChanged += new System.EventHandler(this.CheckMdpServeur_CheckedChanged);
            // 
            // labelMdpServeur
            // 
            this.labelMdpServeur.AutoSize = true;
            this.labelMdpServeur.Location = new System.Drawing.Point(14, 251);
            this.labelMdpServeur.Name = "labelMdpServeur";
            this.labelMdpServeur.Size = new System.Drawing.Size(245, 17);
            this.labelMdpServeur.TabIndex = 9;
            this.labelMdpServeur.Text = "Cliquez pour modifier le mot de passe";
            // 
            // txtMdpServeur
            // 
            this.txtMdpServeur.Location = new System.Drawing.Point(17, 271);
            this.txtMdpServeur.Name = "txtMdpServeur";
            this.txtMdpServeur.PasswordChar = '*';
            this.txtMdpServeur.Size = new System.Drawing.Size(100, 22);
            this.txtMdpServeur.TabIndex = 8;
            this.txtMdpServeur.Visible = false;
            // 
            // labelTelServeur
            // 
            this.labelTelServeur.AutoSize = true;
            this.labelTelServeur.Location = new System.Drawing.Point(14, 197);
            this.labelTelServeur.Name = "labelTelServeur";
            this.labelTelServeur.Size = new System.Drawing.Size(130, 17);
            this.labelTelServeur.TabIndex = 7;
            this.labelTelServeur.Text = "Téléphone Serveur";
            // 
            // txtTelServeur
            // 
            this.txtTelServeur.Location = new System.Drawing.Point(17, 217);
            this.txtTelServeur.Name = "txtTelServeur";
            this.txtTelServeur.Size = new System.Drawing.Size(127, 22);
            this.txtTelServeur.TabIndex = 6;
            this.txtTelServeur.TextChanged += new System.EventHandler(this.txtTelServeur_TextChanged);
            // 
            // txtMailServeur
            // 
            this.txtMailServeur.Location = new System.Drawing.Point(17, 153);
            this.txtMailServeur.Name = "txtMailServeur";
            this.txtMailServeur.Size = new System.Drawing.Size(170, 22);
            this.txtMailServeur.TabIndex = 5;
            this.txtMailServeur.TextChanged += new System.EventHandler(this.txtMailServeur_TextChanged);
            // 
            // labelMailServeur
            // 
            this.labelMailServeur.AutoSize = true;
            this.labelMailServeur.Location = new System.Drawing.Point(14, 133);
            this.labelMailServeur.Name = "labelMailServeur";
            this.labelMailServeur.Size = new System.Drawing.Size(87, 17);
            this.labelMailServeur.TabIndex = 4;
            this.labelMailServeur.Text = "Mail Serveur";
            // 
            // txtPrenomServeur
            // 
            this.txtPrenomServeur.Location = new System.Drawing.Point(17, 80);
            this.txtPrenomServeur.Name = "txtPrenomServeur";
            this.txtPrenomServeur.Size = new System.Drawing.Size(100, 22);
            this.txtPrenomServeur.TabIndex = 3;
            this.txtPrenomServeur.TextChanged += new System.EventHandler(this.txtPrenomServeur_TextChanged);
            // 
            // labelPrenomServeur
            // 
            this.labelPrenomServeur.AutoSize = true;
            this.labelPrenomServeur.Location = new System.Drawing.Point(14, 60);
            this.labelPrenomServeur.Name = "labelPrenomServeur";
            this.labelPrenomServeur.Size = new System.Drawing.Size(111, 17);
            this.labelPrenomServeur.TabIndex = 2;
            this.labelPrenomServeur.Text = "Prénom Serveur";
            // 
            // labelNomServeur
            // 
            this.labelNomServeur.AutoSize = true;
            this.labelNomServeur.Location = new System.Drawing.Point(14, 15);
            this.labelNomServeur.Name = "labelNomServeur";
            this.labelNomServeur.Size = new System.Drawing.Size(109, 17);
            this.labelNomServeur.TabIndex = 1;
            this.labelNomServeur.Text = "Nom du serveur";
            // 
            // txtNomServeur
            // 
            this.txtNomServeur.Location = new System.Drawing.Point(17, 35);
            this.txtNomServeur.Name = "txtNomServeur";
            this.txtNomServeur.Size = new System.Drawing.Size(100, 22);
            this.txtNomServeur.TabIndex = 0;
            this.txtNomServeur.TextChanged += new System.EventHandler(this.txtNomServeur_TextChanged);
            // 
            // btnValiderAjoutServ
            // 
            this.btnValiderAjoutServ.BorderRadius = 10;
            this.btnValiderAjoutServ.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderAjoutServ.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderAjoutServ.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValiderAjoutServ.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValiderAjoutServ.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValiderAjoutServ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValiderAjoutServ.ForeColor = System.Drawing.Color.White;
            this.btnValiderAjoutServ.Location = new System.Drawing.Point(129, 398);
            this.btnValiderAjoutServ.Name = "btnValiderAjoutServ";
            this.btnValiderAjoutServ.Size = new System.Drawing.Size(128, 35);
            this.btnValiderAjoutServ.TabIndex = 9;
            this.btnValiderAjoutServ.Text = "Valider";
            this.btnValiderAjoutServ.Click += new System.EventHandler(this.btnValiderAjoutEmp_Click);
            // 
            // txtIdServ
            // 
            this.txtIdServ.Location = new System.Drawing.Point(344, 13);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.Size = new System.Drawing.Size(100, 22);
            this.txtIdServ.TabIndex = 10;
            this.txtIdServ.Visible = false;
            // 
            // FormAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 458);
            this.Controls.Add(this.txtIdServ);
            this.Controls.Add(this.btnValiderAjoutServ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAjoutServeur);
            this.Name = "FormAjoutEmploye";
            this.Text = "FormAjoutEmploye";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutEmploye_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAjoutServeur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrenomServeur;
        private System.Windows.Forms.Label labelPrenomServeur;
        private System.Windows.Forms.Label labelNomServeur;
        private System.Windows.Forms.TextBox txtNomServeur;
        public Guna.UI2.WinForms.Guna2Button btnValiderAjoutServ;
        private System.Windows.Forms.TextBox txtMailServeur;
        private System.Windows.Forms.Label labelMailServeur;
        private System.Windows.Forms.TextBox txtTelServeur;
        private System.Windows.Forms.Label labelTelServeur;
        private System.Windows.Forms.TextBox txtMdpServeur;
        private System.Windows.Forms.Label labelMdpServeur;
        private System.Windows.Forms.CheckBox CheckMdpServeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtArriveServeur;
        private System.Windows.Forms.DateTimePicker dtNaiss;
        private System.Windows.Forms.Label labelDateNaiss;
        private System.Windows.Forms.TextBox txtIdServ;
    }
}