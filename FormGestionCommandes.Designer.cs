
namespace Projet_Gueguen_Csharp
{
    partial class FormGestionCommandes
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
            this.lblEtatDatagridview = new System.Windows.Forms.Label();
            this.panAEmporter = new System.Windows.Forms.Panel();
            this.dtCommandeEmport = new System.Windows.Forms.DataGridView();
            this.BtnRéglerNote = new Guna.UI2.WinForms.Guna2Button();
            this.btn_EditEmport = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ArchiveraEmport = new Guna.UI2.WinForms.Guna2Button();
            this.labelCommande = new System.Windows.Forms.Label();
            this.labelComande = new System.Windows.Forms.Label();
            this.dtCommande = new System.Windows.Forms.DataGridView();
            this.btn_Archiversurplace = new Guna.UI2.WinForms.Guna2Button();
            this.btn_EditNote = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AEmporter = new Guna.UI2.WinForms.Guna2Button();
            this.btn_surPlace = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Commander = new Guna.UI2.WinForms.Guna2Button();
            this.RecherchetxtFacture = new Guna.UI2.WinForms.Guna2TextBox();
            this.BSCommandeSurPlace = new System.Windows.Forms.BindingSource(this.components);
            this.BSCommandeAEmporter = new System.Windows.Forms.BindingSource(this.components);
            this.guna2GroupBox1.SuspendLayout();
            this.panAEmporter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandeEmport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCommandeSurPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCommandeAEmporter)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.lblEtatDatagridview);
            this.guna2GroupBox1.Controls.Add(this.panAEmporter);
            this.guna2GroupBox1.Controls.Add(this.labelCommande);
            this.guna2GroupBox1.Controls.Add(this.labelComande);
            this.guna2GroupBox1.Controls.Add(this.dtCommande);
            this.guna2GroupBox1.Controls.Add(this.btn_Archiversurplace);
            this.guna2GroupBox1.Controls.Add(this.btn_EditNote);
            this.guna2GroupBox1.Controls.Add(this.btn_AEmporter);
            this.guna2GroupBox1.Controls.Add(this.btn_surPlace);
            this.guna2GroupBox1.Controls.Add(this.btn_Commander);
            this.guna2GroupBox1.Controls.Add(this.RecherchetxtFacture);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(24, 28);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(752, 410);
            this.guna2GroupBox1.TabIndex = 3;
            // 
            // lblEtatDatagridview
            // 
            this.lblEtatDatagridview.AutoSize = true;
            this.lblEtatDatagridview.Location = new System.Drawing.Point(41, 133);
            this.lblEtatDatagridview.Name = "lblEtatDatagridview";
            this.lblEtatDatagridview.Size = new System.Drawing.Size(13, 20);
            this.lblEtatDatagridview.TabIndex = 15;
            this.lblEtatDatagridview.Text = "l";
            this.lblEtatDatagridview.Visible = false;
            // 
            // panAEmporter
            // 
            this.panAEmporter.Controls.Add(this.dtCommandeEmport);
            this.panAEmporter.Controls.Add(this.BtnRéglerNote);
            this.panAEmporter.Controls.Add(this.btn_EditEmport);
            this.panAEmporter.Controls.Add(this.btn_ArchiveraEmport);
            this.panAEmporter.Location = new System.Drawing.Point(45, 86);
            this.panAEmporter.Name = "panAEmporter";
            this.panAEmporter.Size = new System.Drawing.Size(690, 321);
            this.panAEmporter.TabIndex = 14;
            this.panAEmporter.Visible = false;
            // 
            // dtCommandeEmport
            // 
            this.dtCommandeEmport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCommandeEmport.Location = new System.Drawing.Point(86, 31);
            this.dtCommandeEmport.Name = "dtCommandeEmport";
            this.dtCommandeEmport.RowHeadersWidth = 51;
            this.dtCommandeEmport.RowTemplate.Height = 24;
            this.dtCommandeEmport.Size = new System.Drawing.Size(511, 150);
            this.dtCommandeEmport.TabIndex = 17;
            // 
            // BtnRéglerNote
            // 
            this.BtnRéglerNote.BorderRadius = 20;
            this.BtnRéglerNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRéglerNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRéglerNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRéglerNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRéglerNote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.BtnRéglerNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnRéglerNote.ForeColor = System.Drawing.Color.White;
            this.BtnRéglerNote.Location = new System.Drawing.Point(69, 209);
            this.BtnRéglerNote.Name = "BtnRéglerNote";
            this.BtnRéglerNote.Size = new System.Drawing.Size(180, 45);
            this.BtnRéglerNote.TabIndex = 16;
            this.BtnRéglerNote.Text = "Régler la note";
            this.BtnRéglerNote.Click += new System.EventHandler(this.BtnRéglerNote_Click);
            // 
            // btn_EditEmport
            // 
            this.btn_EditEmport.BorderRadius = 20;
            this.btn_EditEmport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditEmport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditEmport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EditEmport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EditEmport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_EditEmport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EditEmport.ForeColor = System.Drawing.Color.White;
            this.btn_EditEmport.Location = new System.Drawing.Point(396, 209);
            this.btn_EditEmport.Name = "btn_EditEmport";
            this.btn_EditEmport.Size = new System.Drawing.Size(180, 45);
            this.btn_EditEmport.TabIndex = 15;
            this.btn_EditEmport.Text = "Editer Note";
            this.btn_EditEmport.Click += new System.EventHandler(this.btn_EditEmport_Click);
            // 
            // btn_ArchiveraEmport
            // 
            this.btn_ArchiveraEmport.BorderRadius = 20;
            this.btn_ArchiveraEmport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ArchiveraEmport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ArchiveraEmport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ArchiveraEmport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ArchiveraEmport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_ArchiveraEmport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ArchiveraEmport.ForeColor = System.Drawing.Color.White;
            this.btn_ArchiveraEmport.Location = new System.Drawing.Point(252, 260);
            this.btn_ArchiveraEmport.Name = "btn_ArchiveraEmport";
            this.btn_ArchiveraEmport.Size = new System.Drawing.Size(180, 45);
            this.btn_ArchiveraEmport.TabIndex = 13;
            this.btn_ArchiveraEmport.Text = "Archiver";
            this.btn_ArchiveraEmport.Click += new System.EventHandler(this.btn_ArchiveraEmport_Click);
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelCommande.Location = new System.Drawing.Point(295, 45);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(19, 25);
            this.labelCommande.TabIndex = 12;
            this.labelCommande.Text = "t";
            this.labelCommande.Visible = false;
            // 
            // labelComande
            // 
            this.labelComande.AutoSize = true;
            this.labelComande.Location = new System.Drawing.Point(330, 49);
            this.labelComande.Name = "labelComande";
            this.labelComande.Size = new System.Drawing.Size(0, 20);
            this.labelComande.TabIndex = 11;
            this.labelComande.Visible = false;
            // 
            // dtCommande
            // 
            this.dtCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCommande.Location = new System.Drawing.Point(94, 86);
            this.dtCommande.Name = "dtCommande";
            this.dtCommande.RowHeadersWidth = 51;
            this.dtCommande.RowTemplate.Height = 24;
            this.dtCommande.Size = new System.Drawing.Size(600, 201);
            this.dtCommande.TabIndex = 10;
            // 
            // btn_Archiversurplace
            // 
            this.btn_Archiversurplace.BorderRadius = 20;
            this.btn_Archiversurplace.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Archiversurplace.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Archiversurplace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Archiversurplace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Archiversurplace.FillColor = System.Drawing.Color.White;
            this.btn_Archiversurplace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Archiversurplace.ForeColor = System.Drawing.Color.Black;
            this.btn_Archiversurplace.Location = new System.Drawing.Point(282, 346);
            this.btn_Archiversurplace.Name = "btn_Archiversurplace";
            this.btn_Archiversurplace.Size = new System.Drawing.Size(180, 45);
            this.btn_Archiversurplace.TabIndex = 9;
            this.btn_Archiversurplace.Text = "Archiver";
            this.btn_Archiversurplace.Click += new System.EventHandler(this.btn_Archiversurplace_Click);
            // 
            // btn_EditNote
            // 
            this.btn_EditNote.BorderRadius = 20;
            this.btn_EditNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_EditNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_EditNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_EditNote.FillColor = System.Drawing.Color.White;
            this.btn_EditNote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_EditNote.ForeColor = System.Drawing.Color.Black;
            this.btn_EditNote.Location = new System.Drawing.Point(447, 300);
            this.btn_EditNote.Name = "btn_EditNote";
            this.btn_EditNote.Size = new System.Drawing.Size(180, 45);
            this.btn_EditNote.TabIndex = 8;
            this.btn_EditNote.Text = "Editer Note";
            this.btn_EditNote.Click += new System.EventHandler(this.btn_EditNote_Click);
            // 
            // btn_AEmporter
            // 
            this.btn_AEmporter.BorderRadius = 10;
            this.btn_AEmporter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AEmporter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AEmporter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AEmporter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AEmporter.FillColor = System.Drawing.Color.White;
            this.btn_AEmporter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AEmporter.ForeColor = System.Drawing.Color.Black;
            this.btn_AEmporter.Location = new System.Drawing.Point(163, 24);
            this.btn_AEmporter.Name = "btn_AEmporter";
            this.btn_AEmporter.Size = new System.Drawing.Size(116, 45);
            this.btn_AEmporter.TabIndex = 7;
            this.btn_AEmporter.Text = "A Emporter";
            this.btn_AEmporter.Click += new System.EventHandler(this.btn_AEmporter_Click);
            // 
            // btn_surPlace
            // 
            this.btn_surPlace.BorderRadius = 10;
            this.btn_surPlace.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_surPlace.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_surPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_surPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_surPlace.FillColor = System.Drawing.Color.White;
            this.btn_surPlace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_surPlace.ForeColor = System.Drawing.Color.Black;
            this.btn_surPlace.Location = new System.Drawing.Point(41, 24);
            this.btn_surPlace.Name = "btn_surPlace";
            this.btn_surPlace.Size = new System.Drawing.Size(116, 45);
            this.btn_surPlace.TabIndex = 6;
            this.btn_surPlace.Text = "Sur Place";
            this.btn_surPlace.Click += new System.EventHandler(this.btn_surPlace_Click);
            // 
            // btn_Commander
            // 
            this.btn_Commander.BorderRadius = 20;
            this.btn_Commander.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Commander.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Commander.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Commander.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Commander.FillColor = System.Drawing.Color.White;
            this.btn_Commander.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Commander.ForeColor = System.Drawing.Color.Black;
            this.btn_Commander.Location = new System.Drawing.Point(134, 300);
            this.btn_Commander.Name = "btn_Commander";
            this.btn_Commander.Size = new System.Drawing.Size(180, 45);
            this.btn_Commander.TabIndex = 3;
            this.btn_Commander.Text = "Commander";
            this.btn_Commander.Click += new System.EventHandler(this.btn_Commander_Click);
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
            this.RecherchetxtFacture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RecherchetxtFacture.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtFacture.Location = new System.Drawing.Point(426, 21);
            this.RecherchetxtFacture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecherchetxtFacture.Name = "RecherchetxtFacture";
            this.RecherchetxtFacture.PasswordChar = '\0';
            this.RecherchetxtFacture.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RecherchetxtFacture.PlaceholderText = "";
            this.RecherchetxtFacture.SelectedText = "";
            this.RecherchetxtFacture.Size = new System.Drawing.Size(305, 48);
            this.RecherchetxtFacture.TabIndex = 1;
            // 
            // FormGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2GroupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionCommandes";
            this.Text = "FormGestionCommandes";
            this.Load += new System.EventHandler(this.FormGestionCommandes_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panAEmporter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtCommandeEmport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCommande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCommandeSurPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSCommandeAEmporter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Commander;
        private Guna.UI2.WinForms.Guna2TextBox RecherchetxtFacture;
        private Guna.UI2.WinForms.Guna2Button btn_surPlace;
        private Guna.UI2.WinForms.Guna2Button btn_AEmporter;
        private Guna.UI2.WinForms.Guna2Button btn_Archiversurplace;
        private Guna.UI2.WinForms.Guna2Button btn_EditNote;
        private System.Windows.Forms.BindingSource BSCommandeSurPlace;
        public System.Windows.Forms.DataGridView dtCommande;
        private System.Windows.Forms.BindingSource BSCommandeAEmporter;
        private System.Windows.Forms.Label labelComande;
        private System.Windows.Forms.Label labelCommande;
        private Guna.UI2.WinForms.Guna2Button btn_ArchiveraEmport;
        private System.Windows.Forms.Panel panAEmporter;
        private Guna.UI2.WinForms.Guna2Button btn_EditEmport;
        private System.Windows.Forms.Label lblEtatDatagridview;
        private Guna.UI2.WinForms.Guna2Button BtnRéglerNote;
        public System.Windows.Forms.DataGridView dtCommandeEmport;
    }
}