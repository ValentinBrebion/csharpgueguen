
namespace Projet_Gueguen_Csharp
{
    partial class Form_Connexion_Gueguen
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Connexion_Gueguen));
            this.GBconn = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GBAdmin = new System.Windows.Forms.GroupBox();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.btnConnexion = new Guna.UI2.WinForms.Guna2Button();
            this.GBServeur = new System.Windows.Forms.GroupBox();
            this.checkserveur = new System.Windows.Forms.CheckBox();
            this.btnConnServeur = new Guna.UI2.WinForms.Guna2Button();
            this.txt_pass_serveur = new System.Windows.Forms.TextBox();
            this.txt_id_serveur = new System.Windows.Forms.TextBox();
            this.btnServeurgb = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdmingb = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelRestau = new System.Windows.Forms.Panel();
            this.labelChoixRestau = new System.Windows.Forms.Label();
            this.buttonValidRestau = new Guna.UI2.WinForms.Guna2Button();
            this.cbRestau = new System.Windows.Forms.ComboBox();
            this.menuGueguen = new System.Windows.Forms.MenuStrip();
            this.gestionFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panConn = new System.Windows.Forms.Panel();
            this.txtidServeur = new System.Windows.Forms.TextBox();
            this.txtidrestau = new System.Windows.Forms.TextBox();
            this.labelAfterConn = new System.Windows.Forms.Label();
            this.txtBoxIdConnexion = new System.Windows.Forms.TextBox();
            this.panAfterConn = new System.Windows.Forms.Panel();
            this.labelNomRestau = new System.Windows.Forms.Label();
            this.labelnomdirigeant = new System.Windows.Forms.Label();
            this.nomrestau = new System.Windows.Forms.Label();
            this.labelafteronn = new System.Windows.Forms.Label();
            this.bsRestau = new System.Windows.Forms.BindingSource(this.components);
            this.GBconn.SuspendLayout();
            this.GBAdmin.SuspendLayout();
            this.GBServeur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelRestau.SuspendLayout();
            this.menuGueguen.SuspendLayout();
            this.panConn.SuspendLayout();
            this.panAfterConn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestau)).BeginInit();
            this.SuspendLayout();
            // 
            // GBconn
            // 
            this.GBconn.BackColor = System.Drawing.Color.Transparent;
            this.GBconn.BorderColor = System.Drawing.Color.Black;
            this.GBconn.BorderRadius = 25;
            this.GBconn.Controls.Add(this.GBAdmin);
            this.GBconn.Controls.Add(this.GBServeur);
            this.GBconn.Controls.Add(this.btnServeurgb);
            this.GBconn.Controls.Add(this.btnAdmingb);
            this.GBconn.Controls.Add(this.guna2PictureBox1);
            this.GBconn.Controls.Add(this.panelRestau);
            this.GBconn.CustomBorderColor = System.Drawing.Color.White;
            this.GBconn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBconn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GBconn.Location = new System.Drawing.Point(140, 52);
            this.GBconn.Name = "GBconn";
            this.GBconn.Size = new System.Drawing.Size(546, 374);
            this.GBconn.TabIndex = 0;
            // 
            // GBAdmin
            // 
            this.GBAdmin.Controls.Add(this.checkBoxPass);
            this.GBAdmin.Controls.Add(this.txt_id);
            this.GBAdmin.Controls.Add(this.txt_pass);
            this.GBAdmin.Controls.Add(this.btnConnexion);
            this.GBAdmin.Location = new System.Drawing.Point(155, 149);
            this.GBAdmin.Name = "GBAdmin";
            this.GBAdmin.Size = new System.Drawing.Size(292, 210);
            this.GBAdmin.TabIndex = 5;
            this.GBAdmin.TabStop = false;
            this.GBAdmin.Visible = false;
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.AutoSize = true;
            this.checkBoxPass.Location = new System.Drawing.Point(216, 108);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPass.TabIndex = 4;
            this.checkBoxPass.UseVisualStyleBackColor = true;
            this.checkBoxPass.CheckedChanged += new System.EventHandler(this.checkBoxPass_CheckedChanged);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(14, 27);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(220, 27);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "Identifiant Admin";
            this.txt_id.Click += new System.EventHandler(this.txt_id_Click_1);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(14, 108);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(220, 27);
            this.txt_pass.TabIndex = 2;
            this.txt_pass.Text = "Mot de passe";
            this.txt_pass.Click += new System.EventHandler(this.txt_pass_Click_1);
            // 
            // btnConnexion
            // 
            this.btnConnexion.BorderRadius = 10;
            this.btnConnexion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnexion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnexion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnexion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnexion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnexion.ForeColor = System.Drawing.Color.White;
            this.btnConnexion.Location = new System.Drawing.Point(56, 150);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(150, 36);
            this.btnConnexion.TabIndex = 1;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // GBServeur
            // 
            this.GBServeur.Controls.Add(this.checkserveur);
            this.GBServeur.Controls.Add(this.btnConnServeur);
            this.GBServeur.Controls.Add(this.txt_pass_serveur);
            this.GBServeur.Controls.Add(this.txt_id_serveur);
            this.GBServeur.Location = new System.Drawing.Point(370, 143);
            this.GBServeur.Name = "GBServeur";
            this.GBServeur.Size = new System.Drawing.Size(292, 210);
            this.GBServeur.TabIndex = 8;
            this.GBServeur.TabStop = false;
            this.GBServeur.Visible = false;
            // 
            // checkserveur
            // 
            this.checkserveur.AutoSize = true;
            this.checkserveur.Location = new System.Drawing.Point(228, 93);
            this.checkserveur.Name = "checkserveur";
            this.checkserveur.Size = new System.Drawing.Size(18, 17);
            this.checkserveur.TabIndex = 4;
            this.checkserveur.UseVisualStyleBackColor = true;
            this.checkserveur.CheckedChanged += new System.EventHandler(this.checkserveur_CheckedChanged);
            // 
            // btnConnServeur
            // 
            this.btnConnServeur.BorderRadius = 10;
            this.btnConnServeur.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnServeur.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnServeur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnServeur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnServeur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnConnServeur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnServeur.ForeColor = System.Drawing.Color.White;
            this.btnConnServeur.Location = new System.Drawing.Point(68, 135);
            this.btnConnServeur.Name = "btnConnServeur";
            this.btnConnServeur.Size = new System.Drawing.Size(150, 36);
            this.btnConnServeur.TabIndex = 3;
            this.btnConnServeur.Text = "Connexion";
            this.btnConnServeur.Click += new System.EventHandler(this.btnConnServeur_Click);
            // 
            // txt_pass_serveur
            // 
            this.txt_pass_serveur.Location = new System.Drawing.Point(34, 87);
            this.txt_pass_serveur.Name = "txt_pass_serveur";
            this.txt_pass_serveur.PasswordChar = '*';
            this.txt_pass_serveur.Size = new System.Drawing.Size(225, 27);
            this.txt_pass_serveur.TabIndex = 1;
            this.txt_pass_serveur.Text = "Mot de passe";
            this.txt_pass_serveur.Click += new System.EventHandler(this.txt_pass_serveur_Click);
            // 
            // txt_id_serveur
            // 
            this.txt_id_serveur.Location = new System.Drawing.Point(34, 27);
            this.txt_id_serveur.Name = "txt_id_serveur";
            this.txt_id_serveur.Size = new System.Drawing.Size(225, 27);
            this.txt_id_serveur.TabIndex = 0;
            this.txt_id_serveur.Text = "identifiant Serveur";
            this.txt_id_serveur.Click += new System.EventHandler(this.txt_id_serveur_Click);
            // 
            // btnServeurgb
            // 
            this.btnServeurgb.BorderRadius = 10;
            this.btnServeurgb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnServeurgb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnServeurgb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnServeurgb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnServeurgb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnServeurgb.ForeColor = System.Drawing.Color.White;
            this.btnServeurgb.Location = new System.Drawing.Point(275, 102);
            this.btnServeurgb.Name = "btnServeurgb";
            this.btnServeurgb.Size = new System.Drawing.Size(142, 35);
            this.btnServeurgb.TabIndex = 7;
            this.btnServeurgb.Text = "Serveur";
            this.btnServeurgb.Click += new System.EventHandler(this.btnServeurgb_Click);
            // 
            // btnAdmingb
            // 
            this.btnAdmingb.BorderRadius = 10;
            this.btnAdmingb.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmingb.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmingb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmingb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmingb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdmingb.ForeColor = System.Drawing.Color.White;
            this.btnAdmingb.Location = new System.Drawing.Point(72, 102);
            this.btnAdmingb.Name = "btnAdmingb";
            this.btnAdmingb.Size = new System.Drawing.Size(142, 35);
            this.btnAdmingb.TabIndex = 6;
            this.btnAdmingb.Text = "Administrateur";
            this.btnAdmingb.Click += new System.EventHandler(this.btnAdmingb_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Projet_Gueguen_Csharp.Properties.Resources.logo_gueguen_remove;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(181, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(168, 86);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            // 
            // panelRestau
            // 
            this.panelRestau.Controls.Add(this.labelChoixRestau);
            this.panelRestau.Controls.Add(this.buttonValidRestau);
            this.panelRestau.Controls.Add(this.cbRestau);
            this.panelRestau.Location = new System.Drawing.Point(14, 149);
            this.panelRestau.Name = "panelRestau";
            this.panelRestau.Size = new System.Drawing.Size(515, 124);
            this.panelRestau.TabIndex = 8;
            this.panelRestau.Visible = false;
            // 
            // labelChoixRestau
            // 
            this.labelChoixRestau.AutoSize = true;
            this.labelChoixRestau.Location = new System.Drawing.Point(185, 11);
            this.labelChoixRestau.Name = "labelChoixRestau";
            this.labelChoixRestau.Size = new System.Drawing.Size(184, 20);
            this.labelChoixRestau.TabIndex = 12;
            this.labelChoixRestau.Text = "Choisissez votre restaurant";
            // 
            // buttonValidRestau
            // 
            this.buttonValidRestau.BorderRadius = 10;
            this.buttonValidRestau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonValidRestau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonValidRestau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonValidRestau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonValidRestau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.buttonValidRestau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonValidRestau.ForeColor = System.Drawing.Color.White;
            this.buttonValidRestau.Location = new System.Drawing.Point(214, 81);
            this.buttonValidRestau.Name = "buttonValidRestau";
            this.buttonValidRestau.Size = new System.Drawing.Size(123, 29);
            this.buttonValidRestau.TabIndex = 11;
            this.buttonValidRestau.Text = "Valider";
            this.buttonValidRestau.Click += new System.EventHandler(this.buttonValidRestau_Click);
            // 
            // cbRestau
            // 
            this.cbRestau.FormattingEnabled = true;
            this.cbRestau.Location = new System.Drawing.Point(85, 45);
            this.cbRestau.Name = "cbRestau";
            this.cbRestau.Size = new System.Drawing.Size(305, 28);
            this.cbRestau.TabIndex = 10;
            this.cbRestau.Text = "Choisir un restaurant";
            // 
            // menuGueguen
            // 
            this.menuGueguen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGueguen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionFacturesToolStripMenuItem,
            this.gestionStockToolStripMenuItem,
            this.gestionCommandesToolStripMenuItem,
            this.statistiquesToolStripMenuItem,
            this.gestionEmployésToolStripMenuItem,
            this.ProfilToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuGueguen.Location = new System.Drawing.Point(0, 0);
            this.menuGueguen.Name = "menuGueguen";
            this.menuGueguen.Size = new System.Drawing.Size(793, 28);
            this.menuGueguen.TabIndex = 2;
            this.menuGueguen.Text = "menuStrip1";
            this.menuGueguen.Visible = false;
            // 
            // gestionFacturesToolStripMenuItem
            // 
            this.gestionFacturesToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionFacturesToolStripMenuItem.Name = "gestionFacturesToolStripMenuItem";
            this.gestionFacturesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.gestionFacturesToolStripMenuItem.Text = "Gestion Factures";
            this.gestionFacturesToolStripMenuItem.Click += new System.EventHandler(this.gestionFacturesToolStripMenuItem_Click);
            // 
            // gestionStockToolStripMenuItem
            // 
            this.gestionStockToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.gestionStockToolStripMenuItem.Name = "gestionStockToolStripMenuItem";
            this.gestionStockToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.gestionStockToolStripMenuItem.Text = "Gestion Stock";
            this.gestionStockToolStripMenuItem.Click += new System.EventHandler(this.gestionStockToolStripMenuItem_Click);
            // 
            // gestionCommandesToolStripMenuItem
            // 
            this.gestionCommandesToolStripMenuItem.Name = "gestionCommandesToolStripMenuItem";
            this.gestionCommandesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.gestionCommandesToolStripMenuItem.Text = "Gestion Commandes";
            this.gestionCommandesToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandesToolStripMenuItem_Click);
            // 
            // statistiquesToolStripMenuItem
            // 
            this.statistiquesToolStripMenuItem.Name = "statistiquesToolStripMenuItem";
            this.statistiquesToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.statistiquesToolStripMenuItem.Text = "Statistiques";
            this.statistiquesToolStripMenuItem.Click += new System.EventHandler(this.statistiquesToolStripMenuItem_Click);
            // 
            // gestionEmployésToolStripMenuItem
            // 
            this.gestionEmployésToolStripMenuItem.Name = "gestionEmployésToolStripMenuItem";
            this.gestionEmployésToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.gestionEmployésToolStripMenuItem.Text = "Gestion Employés";
            this.gestionEmployésToolStripMenuItem.Click += new System.EventHandler(this.gestionEmployésToolStripMenuItem_Click);
            // 
            // ProfilToolStripMenuItem
            // 
            this.ProfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deconnexionToolStripMenuItem});
            this.ProfilToolStripMenuItem.Name = "ProfilToolStripMenuItem";
            this.ProfilToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ProfilToolStripMenuItem.Text = "Profil";
            this.ProfilToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // deconnexionToolStripMenuItem
            // 
            this.deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            this.deconnexionToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.deconnexionToolStripMenuItem.Text = "Deconnexion";
            this.deconnexionToolStripMenuItem.Click += new System.EventHandler(this.deconnexionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // panConn
            // 
            this.panConn.BackColor = System.Drawing.Color.Transparent;
            this.panConn.Controls.Add(this.txtidServeur);
            this.panConn.Controls.Add(this.txtidrestau);
            this.panConn.Controls.Add(this.labelAfterConn);
            this.panConn.Controls.Add(this.txtBoxIdConnexion);
            this.panConn.Controls.Add(this.GBconn);
            this.panConn.Controls.Add(this.panAfterConn);
            this.panConn.Location = new System.Drawing.Point(1, 29);
            this.panConn.Name = "panConn";
            this.panConn.Size = new System.Drawing.Size(793, 453);
            this.panConn.TabIndex = 3;
            // 
            // txtidServeur
            // 
            this.txtidServeur.Location = new System.Drawing.Point(690, 52);
            this.txtidServeur.Name = "txtidServeur";
            this.txtidServeur.Size = new System.Drawing.Size(100, 22);
            this.txtidServeur.TabIndex = 5;
            this.txtidServeur.Visible = false;
            // 
            // txtidrestau
            // 
            this.txtidrestau.Location = new System.Drawing.Point(680, 18);
            this.txtidrestau.Name = "txtidrestau";
            this.txtidrestau.Size = new System.Drawing.Size(100, 22);
            this.txtidrestau.TabIndex = 3;
            this.txtidrestau.Visible = false;
            // 
            // labelAfterConn
            // 
            this.labelAfterConn.AutoSize = true;
            this.labelAfterConn.Location = new System.Drawing.Point(157, 18);
            this.labelAfterConn.Name = "labelAfterConn";
            this.labelAfterConn.Size = new System.Drawing.Size(0, 17);
            this.labelAfterConn.TabIndex = 2;
            this.labelAfterConn.Visible = false;
            // 
            // txtBoxIdConnexion
            // 
            this.txtBoxIdConnexion.Location = new System.Drawing.Point(20, 18);
            this.txtBoxIdConnexion.Name = "txtBoxIdConnexion";
            this.txtBoxIdConnexion.Size = new System.Drawing.Size(100, 22);
            this.txtBoxIdConnexion.TabIndex = 1;
            this.txtBoxIdConnexion.Visible = false;
            // 
            // panAfterConn
            // 
            this.panAfterConn.BackColor = System.Drawing.Color.White;
            this.panAfterConn.Controls.Add(this.labelNomRestau);
            this.panAfterConn.Controls.Add(this.labelnomdirigeant);
            this.panAfterConn.Controls.Add(this.nomrestau);
            this.panAfterConn.Controls.Add(this.labelafteronn);
            this.panAfterConn.Location = new System.Drawing.Point(252, 3);
            this.panAfterConn.Name = "panAfterConn";
            this.panAfterConn.Size = new System.Drawing.Size(314, 192);
            this.panAfterConn.TabIndex = 4;
            this.panAfterConn.Visible = false;
            // 
            // labelNomRestau
            // 
            this.labelNomRestau.AutoSize = true;
            this.labelNomRestau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomRestau.Location = new System.Drawing.Point(49, 122);
            this.labelNomRestau.Name = "labelNomRestau";
            this.labelNomRestau.Size = new System.Drawing.Size(66, 24);
            this.labelNomRestau.TabIndex = 6;
            this.labelNomRestau.Text = "label1";
            // 
            // labelnomdirigeant
            // 
            this.labelnomdirigeant.AutoSize = true;
            this.labelnomdirigeant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomdirigeant.Location = new System.Drawing.Point(177, 16);
            this.labelnomdirigeant.Name = "labelnomdirigeant";
            this.labelnomdirigeant.Size = new System.Drawing.Size(85, 29);
            this.labelnomdirigeant.TabIndex = 5;
            this.labelnomdirigeant.Text = "label1";
            // 
            // nomrestau
            // 
            this.nomrestau.AutoSize = true;
            this.nomrestau.Location = new System.Drawing.Point(40, 89);
            this.nomrestau.Name = "nomrestau";
            this.nomrestau.Size = new System.Drawing.Size(236, 17);
            this.nomrestau.TabIndex = 5;
            this.nomrestau.Text = "Nom du restaurant que vous gérez :";
            // 
            // labelafteronn
            // 
            this.labelafteronn.AutoSize = true;
            this.labelafteronn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelafteronn.Location = new System.Drawing.Point(20, 19);
            this.labelafteronn.Name = "labelafteronn";
            this.labelafteronn.Size = new System.Drawing.Size(114, 25);
            this.labelafteronn.TabIndex = 5;
            this.labelafteronn.Text = "Bienvenue";
            // 
            // Form_Connexion_Gueguen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 483);
            this.Controls.Add(this.panConn);
            this.Controls.Add(this.menuGueguen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Connexion_Gueguen";
            this.Text = "Form_Connexion_Gueguen";
            this.GBconn.ResumeLayout(false);
            this.GBAdmin.ResumeLayout(false);
            this.GBAdmin.PerformLayout();
            this.GBServeur.ResumeLayout(false);
            this.GBServeur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelRestau.ResumeLayout(false);
            this.panelRestau.PerformLayout();
            this.menuGueguen.ResumeLayout(false);
            this.menuGueguen.PerformLayout();
            this.panConn.ResumeLayout(false);
            this.panConn.PerformLayout();
            this.panAfterConn.ResumeLayout(false);
            this.panAfterConn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRestau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GBconn;
        private System.Windows.Forms.TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2Button btnConnexion;
        private System.Windows.Forms.TextBox txt_id;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.CheckBox checkBoxPass;
        private System.Windows.Forms.MenuStrip menuGueguen;
        private System.Windows.Forms.ToolStripMenuItem gestionFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deconnexionToolStripMenuItem;
        private System.Windows.Forms.Panel panConn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox GBAdmin;
        private Guna.UI2.WinForms.Guna2Button btnAdmingb;
        private Guna.UI2.WinForms.Guna2Button btnServeurgb;
        private System.Windows.Forms.GroupBox GBServeur;
        private System.Windows.Forms.TextBox txt_id_serveur;
        private System.Windows.Forms.TextBox txt_pass_serveur;
        private Guna.UI2.WinForms.Guna2Button btnConnServeur;
        private System.Windows.Forms.CheckBox checkserveur;
        public System.Windows.Forms.TextBox txtBoxIdConnexion;
        private System.Windows.Forms.BindingSource bsRestau;
        private System.Windows.Forms.Panel panelRestau;
        private Guna.UI2.WinForms.Guna2Button buttonValidRestau;
        private System.Windows.Forms.ComboBox cbRestau;
        private System.Windows.Forms.Label labelAfterConn;
        public System.Windows.Forms.TextBox txtidrestau;
        private System.Windows.Forms.Panel panAfterConn;
        private System.Windows.Forms.Label labelafteronn;
        private System.Windows.Forms.Label nomrestau;
        private System.Windows.Forms.Label labelnomdirigeant;
        private System.Windows.Forms.Label labelNomRestau;
        private System.Windows.Forms.Label labelChoixRestau;
        public System.Windows.Forms.TextBox txtidServeur;
    }
}

