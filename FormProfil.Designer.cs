
namespace Projet_Gueguen_Csharp
{
    partial class FormProfil
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
            this.panelProfil = new System.Windows.Forms.Panel();
            this.gbProfil = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.RecherchetxtFacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.testTextbox = new System.Windows.Forms.TextBox();
            this.PanProfil = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.labelprenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.panelProfil.SuspendLayout();
            this.gbProfil.SuspendLayout();
            this.PanProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfil
            // 
            this.panelProfil.BackColor = System.Drawing.Color.Transparent;
            this.panelProfil.Controls.Add(this.gbProfil);
            this.panelProfil.Location = new System.Drawing.Point(3, -1);
            this.panelProfil.Name = "panelProfil";
            this.panelProfil.Size = new System.Drawing.Size(796, 531);
            this.panelProfil.TabIndex = 0;
            // 
            // gbProfil
            // 
            this.gbProfil.BackColor = System.Drawing.Color.Transparent;
            this.gbProfil.BorderRadius = 20;
            this.gbProfil.Controls.Add(this.PanProfil);
            this.gbProfil.Controls.Add(this.testTextbox);
            this.gbProfil.Controls.Add(this.btn_Modifier);
            this.gbProfil.Controls.Add(this.RecherchetxtFacture);
            this.gbProfil.Controls.Add(this.label1);
            this.gbProfil.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbProfil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.gbProfil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbProfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbProfil.Location = new System.Drawing.Point(22, 27);
            this.gbProfil.Name = "gbProfil";
            this.gbProfil.Size = new System.Drawing.Size(752, 394);
            this.gbProfil.TabIndex = 2;
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BorderRadius = 20;
            this.btn_Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier.FillColor = System.Drawing.Color.White;
            this.btn_Modifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.ForeColor = System.Drawing.Color.Black;
            this.btn_Modifier.Location = new System.Drawing.Point(303, 330);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier.TabIndex = 3;
            this.btn_Modifier.Text = "Modifier";
            // 
            // RecherchetxtFacture
            // 
            this.RecherchetxtFacture.BorderRadius = 20;
            this.RecherchetxtFacture.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecherchetxtFacture.DefaultText = "Recherche";
            this.RecherchetxtFacture.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RecherchetxtFacture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RecherchetxtFacture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtFacture.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtFacture.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtFacture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecherchetxtFacture.ForeColor = System.Drawing.Color.Black;
            this.RecherchetxtFacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtFacture.Location = new System.Drawing.Point(426, 33);
            this.RecherchetxtFacture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecherchetxtFacture.Name = "RecherchetxtFacture";
            this.RecherchetxtFacture.PasswordChar = '\0';
            this.RecherchetxtFacture.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RecherchetxtFacture.PlaceholderText = "";
            this.RecherchetxtFacture.SelectedText = "";
            this.RecherchetxtFacture.Size = new System.Drawing.Size(305, 48);
            this.RecherchetxtFacture.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PARAMÈTRES PROFIL";
            // 
            // testTextbox
            // 
            this.testTextbox.Location = new System.Drawing.Point(303, 33);
            this.testTextbox.Name = "testTextbox";
            this.testTextbox.Size = new System.Drawing.Size(100, 27);
            this.testTextbox.TabIndex = 4;
            this.testTextbox.Visible = false;
            // 
            // PanProfil
            // 
            this.PanProfil.BackColor = System.Drawing.Color.White;
            this.PanProfil.Controls.Add(this.labelNom);
            this.PanProfil.Controls.Add(this.labelprenom);
            this.PanProfil.Controls.Add(this.txtPrenom);
            this.PanProfil.Controls.Add(this.txtNom);
            this.PanProfil.Location = new System.Drawing.Point(41, 88);
            this.PanProfil.Name = "PanProfil";
            this.PanProfil.Size = new System.Drawing.Size(678, 228);
            this.PanProfil.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(136, 27);
            this.txtNom.TabIndex = 0;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(479, 39);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(136, 27);
            this.txtPrenom.TabIndex = 1;
            // 
            // labelprenom
            // 
            this.labelprenom.AutoSize = true;
            this.labelprenom.Location = new System.Drawing.Point(338, 42);
            this.labelprenom.Name = "labelprenom";
            this.labelprenom.Size = new System.Drawing.Size(126, 20);
            this.labelprenom.TabIndex = 2;
            this.labelprenom.Text = "Prénom Dirigeant";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(16, 42);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(108, 20);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom Dirigeant";
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.panelProfil);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.panelProfil.ResumeLayout(false);
            this.gbProfil.ResumeLayout(false);
            this.gbProfil.PerformLayout();
            this.PanProfil.ResumeLayout(false);
            this.PanProfil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProfil;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier;
        private Guna.UI2.WinForms.Guna2TextBox RecherchetxtFacture;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2GroupBox gbProfil;
        private System.Windows.Forms.TextBox testTextbox;
        private System.Windows.Forms.Panel PanProfil;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelprenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
    }
}