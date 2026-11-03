
namespace Projet_Gueguen_Csharp
{
    partial class FormGestionEmploye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_employe = new System.Windows.Forms.Panel();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_listemp = new System.Windows.Forms.Label();
            this.btn_Supprimer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Modifier = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Ajouter = new Guna.UI2.WinForms.Guna2Button();
            this.dtEmploye = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RecherchetxtEmploye = new Guna.UI2.WinForms.Guna2TextBox();
            this.bsServeur = new System.Windows.Forms.BindingSource(this.components);
            this.Panel_employe.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmploye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServeur)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_employe
            // 
            this.Panel_employe.BackColor = System.Drawing.Color.Transparent;
            this.Panel_employe.Controls.Add(this.guna2GroupBox1);
            this.Panel_employe.Location = new System.Drawing.Point(0, -1);
            this.Panel_employe.Name = "Panel_employe";
            this.Panel_employe.Size = new System.Drawing.Size(801, 530);
            this.Panel_employe.TabIndex = 0;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.Controls.Add(this.lbl_listemp);
            this.guna2GroupBox1.Controls.Add(this.btn_Supprimer);
            this.guna2GroupBox1.Controls.Add(this.btn_Modifier);
            this.guna2GroupBox1.Controls.Add(this.btn_Ajouter);
            this.guna2GroupBox1.Controls.Add(this.dtEmploye);
            this.guna2GroupBox1.Controls.Add(this.RecherchetxtEmploye);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(24, 28);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(752, 410);
            this.guna2GroupBox1.TabIndex = 4;
            // 
            // lbl_listemp
            // 
            this.lbl_listemp.AutoSize = true;
            this.lbl_listemp.ForeColor = System.Drawing.Color.Black;
            this.lbl_listemp.Location = new System.Drawing.Point(38, 34);
            this.lbl_listemp.Name = "lbl_listemp";
            this.lbl_listemp.Size = new System.Drawing.Size(149, 20);
            this.lbl_listemp.TabIndex = 10;
            this.lbl_listemp.Text = "LISTE DES EMPLOYÉS";
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.BorderRadius = 20;
            this.btn_Supprimer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Supprimer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Supprimer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Supprimer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Supprimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Supprimer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Supprimer.Location = new System.Drawing.Point(282, 346);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(180, 45);
            this.btn_Supprimer.TabIndex = 9;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.BorderRadius = 20;
            this.btn_Modifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Modifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Modifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Modifier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Modifier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Modifier.Location = new System.Drawing.Point(447, 300);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(180, 45);
            this.btn_Modifier.TabIndex = 8;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.BorderRadius = 20;
            this.btn_Ajouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Ajouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Ajouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Ajouter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btn_Ajouter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Ajouter.Location = new System.Drawing.Point(134, 300);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(180, 45);
            this.btn_Ajouter.TabIndex = 3;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // dtEmploye
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtEmploye.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtEmploye.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtEmploye.ColumnHeadersHeight = 4;
            this.dtEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtEmploye.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtEmploye.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtEmploye.Location = new System.Drawing.Point(41, 88);
            this.dtEmploye.Name = "dtEmploye";
            this.dtEmploye.RowHeadersVisible = false;
            this.dtEmploye.RowHeadersWidth = 51;
            this.dtEmploye.RowTemplate.Height = 24;
            this.dtEmploye.Size = new System.Drawing.Size(690, 206);
            this.dtEmploye.TabIndex = 2;
            this.dtEmploye.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtEmploye.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtEmploye.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtEmploye.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtEmploye.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtEmploye.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtEmploye.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtEmploye.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtEmploye.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtEmploye.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEmploye.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtEmploye.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtEmploye.ThemeStyle.HeaderStyle.Height = 4;
            this.dtEmploye.ThemeStyle.ReadOnly = false;
            this.dtEmploye.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtEmploye.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtEmploye.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEmploye.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dtEmploye.ThemeStyle.RowsStyle.Height = 24;
            this.dtEmploye.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtEmploye.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RecherchetxtEmploye
            // 
            this.RecherchetxtEmploye.BorderRadius = 20;
            this.RecherchetxtEmploye.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RecherchetxtEmploye.DefaultText = "Recherche";
            this.RecherchetxtEmploye.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RecherchetxtEmploye.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RecherchetxtEmploye.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtEmploye.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RecherchetxtEmploye.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtEmploye.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RecherchetxtEmploye.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RecherchetxtEmploye.Location = new System.Drawing.Point(426, 21);
            this.RecherchetxtEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RecherchetxtEmploye.Name = "RecherchetxtEmploye";
            this.RecherchetxtEmploye.PasswordChar = '\0';
            this.RecherchetxtEmploye.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RecherchetxtEmploye.PlaceholderText = "";
            this.RecherchetxtEmploye.SelectedText = "";
            this.RecherchetxtEmploye.Size = new System.Drawing.Size(305, 48);
            this.RecherchetxtEmploye.TabIndex = 1;
            this.RecherchetxtEmploye.TextChanged += new System.EventHandler(this.RecherchetxtEmploye_TextChanged);
            // 
            // FormGestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Gueguen_Csharp.Properties.Resources.fond_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 530);
            this.Controls.Add(this.Panel_employe);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionEmploye";
            this.Text = "FormGestionEmploye";
            this.Load += new System.EventHandler(this.FormGestionEmploye_Load);
            this.Panel_employe.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmploye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_employe;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Supprimer;
        private Guna.UI2.WinForms.Guna2Button btn_Modifier;
        private Guna.UI2.WinForms.Guna2Button btn_Ajouter;
        public Guna.UI2.WinForms.Guna2DataGridView dtEmploye;
        private Guna.UI2.WinForms.Guna2TextBox RecherchetxtEmploye;
        private System.Windows.Forms.Label lbl_listemp;
        private System.Windows.Forms.BindingSource bsServeur;
    }
}