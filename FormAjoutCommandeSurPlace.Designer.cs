
namespace Projet_Gueguen_Csharp
{
    partial class FormAjoutCommandeSurPlace
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
            this.labelSP = new System.Windows.Forms.Label();
            this.cbClientSP = new System.Windows.Forms.ComboBox();
            this.labelClientSP = new System.Windows.Forms.Label();
            this.labelMoyenPaieSP = new System.Windows.Forms.Label();
            this.cbMoyenPaieSP = new System.Windows.Forms.ComboBox();
            this.cbServeur = new System.Windows.Forms.ComboBox();
            this.labelNomServeur = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.cbTableSP = new System.Windows.Forms.ComboBox();
            this.btnValiderSP = new Guna.UI2.WinForms.Guna2Button();
            this.panelAsseoir = new System.Windows.Forms.Panel();
            this.textIdClientAsseoir = new System.Windows.Forms.TextBox();
            this.btnValidAsseoir = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.labelAsseoir = new System.Windows.Forms.Label();
            this.bsClient = new System.Windows.Forms.BindingSource(this.components);
            this.bsMoyenPaiement = new System.Windows.Forms.BindingSource(this.components);
            this.bsServeur = new System.Windows.Forms.BindingSource(this.components);
            this.bsTable = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdClient = new System.Windows.Forms.TextBox();
            this.panelCreaCommande = new System.Windows.Forms.Panel();
            this.panelAftAsseoir = new System.Windows.Forms.Panel();
            this.BtnFinCommandSP = new Guna.UI2.WinForms.Guna2Button();
            this.txtNomCliSP = new System.Windows.Forms.TextBox();
            this.labelNomClient = new System.Windows.Forms.Label();
            this.labelCommandeSP = new System.Windows.Forms.Label();
            this.txtNomTable = new System.Windows.Forms.TextBox();
            this.labelNomTable = new System.Windows.Forms.Label();
            this.txtMoyPaieRes = new System.Windows.Forms.TextBox();
            this.labelMoyPaie = new System.Windows.Forms.Label();
            this.txtNomServeur = new System.Windows.Forms.TextBox();
            this.panelssClient = new System.Windows.Forms.Panel();
            this.pansscliaftaasseoir = new System.Windows.Forms.Panel();
            this.btnfinssclient = new Guna.UI2.WinForms.Guna2Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbserveurSsClient = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSSclientAsseoir = new System.Windows.Forms.Panel();
            this.btnValideAsseoirSScli = new Guna.UI2.WinForms.Guna2Button();
            this.textClientId = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtableSansClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtClient = new System.Windows.Forms.DataGridView();
            this.bsClientDataGrid = new System.Windows.Forms.BindingSource(this.components);
            this.RechercheNomClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSansClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnComandConClient = new Guna.UI2.WinForms.Guna2Button();
            this.panelAsseoir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoyenPaiement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTable)).BeginInit();
            this.panelCreaCommande.SuspendLayout();
            this.panelAftAsseoir.SuspendLayout();
            this.panelssClient.SuspendLayout();
            this.pansscliaftaasseoir.SuspendLayout();
            this.panelSSclientAsseoir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSP.Location = new System.Drawing.Point(14, 11);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(256, 22);
            this.labelSP.TabIndex = 1;
            this.labelSP.Text = "Commande sur place";
            // 
            // cbClientSP
            // 
            this.cbClientSP.FormattingEnabled = true;
            this.cbClientSP.Location = new System.Drawing.Point(515, 96);
            this.cbClientSP.Name = "cbClientSP";
            this.cbClientSP.Size = new System.Drawing.Size(121, 24);
            this.cbClientSP.TabIndex = 2;
            this.cbClientSP.Visible = false;
            this.cbClientSP.SelectedIndexChanged += new System.EventHandler(this.cbClientSP_SelectedIndexChanged);
            // 
            // labelClientSP
            // 
            this.labelClientSP.AutoSize = true;
            this.labelClientSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelClientSP.Location = new System.Drawing.Point(551, 62);
            this.labelClientSP.Name = "labelClientSP";
            this.labelClientSP.Size = new System.Drawing.Size(58, 20);
            this.labelClientSP.TabIndex = 3;
            this.labelClientSP.Text = "Client";
            this.labelClientSP.Visible = false;
            // 
            // labelMoyenPaieSP
            // 
            this.labelMoyenPaieSP.AutoSize = true;
            this.labelMoyenPaieSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoyenPaieSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelMoyenPaieSP.Location = new System.Drawing.Point(496, 125);
            this.labelMoyenPaieSP.Name = "labelMoyenPaieSP";
            this.labelMoyenPaieSP.Size = new System.Drawing.Size(171, 20);
            this.labelMoyenPaieSP.TabIndex = 4;
            this.labelMoyenPaieSP.Text = "Moyen de paiement";
            this.labelMoyenPaieSP.Visible = false;
            // 
            // cbMoyenPaieSP
            // 
            this.cbMoyenPaieSP.FormattingEnabled = true;
            this.cbMoyenPaieSP.Location = new System.Drawing.Point(536, 155);
            this.cbMoyenPaieSP.Name = "cbMoyenPaieSP";
            this.cbMoyenPaieSP.Size = new System.Drawing.Size(121, 24);
            this.cbMoyenPaieSP.TabIndex = 5;
            this.cbMoyenPaieSP.Visible = false;
            this.cbMoyenPaieSP.SelectedIndexChanged += new System.EventHandler(this.cbMoyenPaieSP_SelectedIndexChanged);
            // 
            // cbServeur
            // 
            this.cbServeur.FormattingEnabled = true;
            this.cbServeur.Location = new System.Drawing.Point(24, 216);
            this.cbServeur.Name = "cbServeur";
            this.cbServeur.Size = new System.Drawing.Size(121, 24);
            this.cbServeur.TabIndex = 6;
            this.cbServeur.SelectedIndexChanged += new System.EventHandler(this.cbServeur_SelectedIndexChanged);
            // 
            // labelNomServeur
            // 
            this.labelNomServeur.AutoSize = true;
            this.labelNomServeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomServeur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelNomServeur.Location = new System.Drawing.Point(22, 189);
            this.labelNomServeur.Name = "labelNomServeur";
            this.labelNomServeur.Size = new System.Drawing.Size(142, 20);
            this.labelNomServeur.TabIndex = 7;
            this.labelNomServeur.Text = "Nom du serveur";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelTable.Location = new System.Drawing.Point(14, 123);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(141, 20);
            this.labelTable.TabIndex = 8;
            this.labelTable.Text = "Nom de la table";
            // 
            // cbTableSP
            // 
            this.cbTableSP.FormattingEnabled = true;
            this.cbTableSP.Location = new System.Drawing.Point(25, 149);
            this.cbTableSP.Name = "cbTableSP";
            this.cbTableSP.Size = new System.Drawing.Size(121, 24);
            this.cbTableSP.TabIndex = 9;
            this.cbTableSP.SelectedIndexChanged += new System.EventHandler(this.cbTableSP_SelectedIndexChanged);
            // 
            // btnValiderSP
            // 
            this.btnValiderSP.BorderRadius = 10;
            this.btnValiderSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValiderSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValiderSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValiderSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValiderSP.ForeColor = System.Drawing.Color.White;
            this.btnValiderSP.Location = new System.Drawing.Point(58, 351);
            this.btnValiderSP.Name = "btnValiderSP";
            this.btnValiderSP.Size = new System.Drawing.Size(128, 35);
            this.btnValiderSP.TabIndex = 11;
            this.btnValiderSP.Text = "Valider";
            this.btnValiderSP.Visible = false;
            this.btnValiderSP.Click += new System.EventHandler(this.btnValiderSP_Click);
            // 
            // panelAsseoir
            // 
            this.panelAsseoir.Controls.Add(this.textIdClientAsseoir);
            this.panelAsseoir.Controls.Add(this.btnValidAsseoir);
            this.panelAsseoir.Controls.Add(this.txtNomClient);
            this.panelAsseoir.Controls.Add(this.labelClient);
            this.panelAsseoir.Controls.Add(this.cbTableSP);
            this.panelAsseoir.Controls.Add(this.labelTable);
            this.panelAsseoir.Controls.Add(this.labelAsseoir);
            this.panelAsseoir.Location = new System.Drawing.Point(18, 48);
            this.panelAsseoir.Name = "panelAsseoir";
            this.panelAsseoir.Size = new System.Drawing.Size(254, 274);
            this.panelAsseoir.TabIndex = 12;
            // 
            // textIdClientAsseoir
            // 
            this.textIdClientAsseoir.Location = new System.Drawing.Point(181, 12);
            this.textIdClientAsseoir.Name = "textIdClientAsseoir";
            this.textIdClientAsseoir.Size = new System.Drawing.Size(61, 22);
            this.textIdClientAsseoir.TabIndex = 16;
            // 
            // btnValidAsseoir
            // 
            this.btnValidAsseoir.BorderRadius = 20;
            this.btnValidAsseoir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValidAsseoir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValidAsseoir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValidAsseoir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValidAsseoir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValidAsseoir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValidAsseoir.ForeColor = System.Drawing.Color.White;
            this.btnValidAsseoir.Location = new System.Drawing.Point(62, 194);
            this.btnValidAsseoir.Name = "btnValidAsseoir";
            this.btnValidAsseoir.Size = new System.Drawing.Size(121, 34);
            this.btnValidAsseoir.TabIndex = 15;
            this.btnValidAsseoir.Text = "Valider";
            this.btnValidAsseoir.Click += new System.EventHandler(this.btnValidAsseoir_Click);
            // 
            // txtNomClient
            // 
            this.txtNomClient.Enabled = false;
            this.txtNomClient.Location = new System.Drawing.Point(25, 84);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(140, 22);
            this.txtNomClient.TabIndex = 14;
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelClient.Location = new System.Drawing.Point(14, 54);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(125, 20);
            this.labelClient.TabIndex = 13;
            this.labelClient.Text = "Nom du client";
            // 
            // labelAsseoir
            // 
            this.labelAsseoir.AutoSize = true;
            this.labelAsseoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsseoir.Location = new System.Drawing.Point(6, 14);
            this.labelAsseoir.Name = "labelAsseoir";
            this.labelAsseoir.Size = new System.Drawing.Size(133, 20);
            this.labelAsseoir.TabIndex = 0;
            this.labelAsseoir.Text = "Config Asseoir";
            // 
            // bsClient
            // 
            this.bsClient.CurrentChanged += new System.EventHandler(this.bsClient_CurrentChanged);
            // 
            // bsMoyenPaiement
            // 
            this.bsMoyenPaiement.CurrentChanged += new System.EventHandler(this.bsMoyenPaiement_CurrentChanged);
            // 
            // bsServeur
            // 
            this.bsServeur.CurrentChanged += new System.EventHandler(this.bsServeur_CurrentChanged);
            // 
            // bsTable
            // 
            this.bsTable.CurrentChanged += new System.EventHandler(this.bsTable_CurrentChanged);
            // 
            // txtIdClient
            // 
            this.txtIdClient.Location = new System.Drawing.Point(515, 26);
            this.txtIdClient.Name = "txtIdClient";
            this.txtIdClient.Size = new System.Drawing.Size(61, 22);
            this.txtIdClient.TabIndex = 13;
            this.txtIdClient.Visible = false;
            // 
            // panelCreaCommande
            // 
            this.panelCreaCommande.Controls.Add(this.panelAftAsseoir);
            this.panelCreaCommande.Controls.Add(this.labelSP);
            this.panelCreaCommande.Controls.Add(this.btnValiderSP);
            this.panelCreaCommande.Controls.Add(this.panelAsseoir);
            this.panelCreaCommande.Controls.Add(this.txtIdClient);
            this.panelCreaCommande.Controls.Add(this.txtMoyPaieRes);
            this.panelCreaCommande.Controls.Add(this.labelMoyPaie);
            this.panelCreaCommande.Controls.Add(this.labelClientSP);
            this.panelCreaCommande.Controls.Add(this.cbClientSP);
            this.panelCreaCommande.Controls.Add(this.cbMoyenPaieSP);
            this.panelCreaCommande.Controls.Add(this.labelMoyenPaieSP);
            this.panelCreaCommande.Controls.Add(this.txtNomServeur);
            this.panelCreaCommande.Location = new System.Drawing.Point(685, 23);
            this.panelCreaCommande.Name = "panelCreaCommande";
            this.panelCreaCommande.Size = new System.Drawing.Size(724, 408);
            this.panelCreaCommande.TabIndex = 14;
            this.panelCreaCommande.Visible = false;
            // 
            // panelAftAsseoir
            // 
            this.panelAftAsseoir.Controls.Add(this.BtnFinCommandSP);
            this.panelAftAsseoir.Controls.Add(this.txtNomCliSP);
            this.panelAftAsseoir.Controls.Add(this.labelNomClient);
            this.panelAftAsseoir.Controls.Add(this.labelCommandeSP);
            this.panelAftAsseoir.Controls.Add(this.txtNomTable);
            this.panelAftAsseoir.Controls.Add(this.labelNomTable);
            this.panelAftAsseoir.Controls.Add(this.labelNomServeur);
            this.panelAftAsseoir.Controls.Add(this.cbServeur);
            this.panelAftAsseoir.Location = new System.Drawing.Point(320, 26);
            this.panelAftAsseoir.Name = "panelAftAsseoir";
            this.panelAftAsseoir.Size = new System.Drawing.Size(347, 319);
            this.panelAftAsseoir.TabIndex = 21;
            this.panelAftAsseoir.Visible = false;
            // 
            // BtnFinCommandSP
            // 
            this.BtnFinCommandSP.BorderRadius = 20;
            this.BtnFinCommandSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFinCommandSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFinCommandSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFinCommandSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFinCommandSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.BtnFinCommandSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFinCommandSP.ForeColor = System.Drawing.Color.White;
            this.BtnFinCommandSP.Location = new System.Drawing.Point(86, 251);
            this.BtnFinCommandSP.Name = "BtnFinCommandSP";
            this.BtnFinCommandSP.Size = new System.Drawing.Size(180, 45);
            this.BtnFinCommandSP.TabIndex = 23;
            this.BtnFinCommandSP.Text = "Finalisation de la commande";
            this.BtnFinCommandSP.Click += new System.EventHandler(this.BtnFinCommandSP_Click);
            // 
            // txtNomCliSP
            // 
            this.txtNomCliSP.Enabled = false;
            this.txtNomCliSP.Location = new System.Drawing.Point(24, 143);
            this.txtNomCliSP.Name = "txtNomCliSP";
            this.txtNomCliSP.Size = new System.Drawing.Size(100, 22);
            this.txtNomCliSP.TabIndex = 22;
            // 
            // labelNomClient
            // 
            this.labelNomClient.AutoSize = true;
            this.labelNomClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelNomClient.Location = new System.Drawing.Point(20, 119);
            this.labelNomClient.Name = "labelNomClient";
            this.labelNomClient.Size = new System.Drawing.Size(125, 20);
            this.labelNomClient.TabIndex = 21;
            this.labelNomClient.Text = "Nom du client";
            // 
            // labelCommandeSP
            // 
            this.labelCommandeSP.AutoSize = true;
            this.labelCommandeSP.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommandeSP.Location = new System.Drawing.Point(8, 17);
            this.labelCommandeSP.Name = "labelCommandeSP";
            this.labelCommandeSP.Size = new System.Drawing.Size(258, 22);
            this.labelCommandeSP.TabIndex = 2;
            this.labelCommandeSP.Text = "Passer la commande";
            // 
            // txtNomTable
            // 
            this.txtNomTable.Enabled = false;
            this.txtNomTable.Location = new System.Drawing.Point(24, 82);
            this.txtNomTable.Name = "txtNomTable";
            this.txtNomTable.Size = new System.Drawing.Size(140, 22);
            this.txtNomTable.TabIndex = 20;
            // 
            // labelNomTable
            // 
            this.labelNomTable.AutoSize = true;
            this.labelNomTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.labelNomTable.Location = new System.Drawing.Point(20, 59);
            this.labelNomTable.Name = "labelNomTable";
            this.labelNomTable.Size = new System.Drawing.Size(99, 20);
            this.labelNomTable.TabIndex = 19;
            this.labelNomTable.Text = "Nom Table";
            // 
            // txtMoyPaieRes
            // 
            this.txtMoyPaieRes.Enabled = false;
            this.txtMoyPaieRes.Location = new System.Drawing.Point(342, 62);
            this.txtMoyPaieRes.Name = "txtMoyPaieRes";
            this.txtMoyPaieRes.Size = new System.Drawing.Size(140, 22);
            this.txtMoyPaieRes.TabIndex = 16;
            this.txtMoyPaieRes.Visible = false;
            // 
            // labelMoyPaie
            // 
            this.labelMoyPaie.AutoSize = true;
            this.labelMoyPaie.Location = new System.Drawing.Point(339, 31);
            this.labelMoyPaie.Name = "labelMoyPaie";
            this.labelMoyPaie.Size = new System.Drawing.Size(132, 17);
            this.labelMoyPaie.TabIndex = 15;
            this.labelMoyPaie.Text = "Moyen de paiement";
            this.labelMoyPaie.Visible = false;
            // 
            // txtNomServeur
            // 
            this.txtNomServeur.Enabled = false;
            this.txtNomServeur.Location = new System.Drawing.Point(266, 79);
            this.txtNomServeur.Name = "txtNomServeur";
            this.txtNomServeur.Size = new System.Drawing.Size(140, 22);
            this.txtNomServeur.TabIndex = 22;
            this.txtNomServeur.Visible = false;
            // 
            // panelssClient
            // 
            this.panelssClient.Controls.Add(this.pansscliaftaasseoir);
            this.panelssClient.Controls.Add(this.label4);
            this.panelssClient.Controls.Add(this.panelSSclientAsseoir);
            this.panelssClient.Location = new System.Drawing.Point(685, 26);
            this.panelssClient.Name = "panelssClient";
            this.panelssClient.Size = new System.Drawing.Size(699, 362);
            this.panelssClient.TabIndex = 19;
            this.panelssClient.Visible = false;
            // 
            // pansscliaftaasseoir
            // 
            this.pansscliaftaasseoir.Controls.Add(this.btnfinssclient);
            this.pansscliaftaasseoir.Controls.Add(this.textBox3);
            this.pansscliaftaasseoir.Controls.Add(this.label5);
            this.pansscliaftaasseoir.Controls.Add(this.label6);
            this.pansscliaftaasseoir.Controls.Add(this.textBox4);
            this.pansscliaftaasseoir.Controls.Add(this.label7);
            this.pansscliaftaasseoir.Controls.Add(this.label8);
            this.pansscliaftaasseoir.Controls.Add(this.cbserveurSsClient);
            this.pansscliaftaasseoir.Location = new System.Drawing.Point(314, 32);
            this.pansscliaftaasseoir.Name = "pansscliaftaasseoir";
            this.pansscliaftaasseoir.Size = new System.Drawing.Size(347, 319);
            this.pansscliaftaasseoir.TabIndex = 22;
            this.pansscliaftaasseoir.Visible = false;
            // 
            // btnfinssclient
            // 
            this.btnfinssclient.BorderRadius = 20;
            this.btnfinssclient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfinssclient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfinssclient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfinssclient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfinssclient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnfinssclient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnfinssclient.ForeColor = System.Drawing.Color.White;
            this.btnfinssclient.Location = new System.Drawing.Point(86, 251);
            this.btnfinssclient.Name = "btnfinssclient";
            this.btnfinssclient.Size = new System.Drawing.Size(180, 45);
            this.btnfinssclient.TabIndex = 23;
            this.btnfinssclient.Text = "Finalisation de la commande";
            this.btnfinssclient.Click += new System.EventHandler(this.btnfinssclient_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(24, 143);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nom du client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Passer la commande";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(24, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 22);
            this.textBox4.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label7.Location = new System.Drawing.Point(20, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nom Table";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label8.Location = new System.Drawing.Point(22, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nom du serveur";
            // 
            // cbserveurSsClient
            // 
            this.cbserveurSsClient.FormattingEnabled = true;
            this.cbserveurSsClient.Location = new System.Drawing.Point(24, 216);
            this.cbserveurSsClient.Name = "cbserveurSsClient";
            this.cbserveurSsClient.Size = new System.Drawing.Size(121, 24);
            this.cbserveurSsClient.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(333, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Commande sur place Speed";
            // 
            // panelSSclientAsseoir
            // 
            this.panelSSclientAsseoir.Controls.Add(this.btnValideAsseoirSScli);
            this.panelSSclientAsseoir.Controls.Add(this.textClientId);
            this.panelSSclientAsseoir.Controls.Add(this.textBox2);
            this.panelSSclientAsseoir.Controls.Add(this.label1);
            this.panelSSclientAsseoir.Controls.Add(this.cbtableSansClient);
            this.panelSSclientAsseoir.Controls.Add(this.label2);
            this.panelSSclientAsseoir.Controls.Add(this.label3);
            this.panelSSclientAsseoir.Location = new System.Drawing.Point(40, 40);
            this.panelSSclientAsseoir.Name = "panelSSclientAsseoir";
            this.panelSSclientAsseoir.Size = new System.Drawing.Size(254, 274);
            this.panelSSclientAsseoir.TabIndex = 13;
            // 
            // btnValideAsseoirSScli
            // 
            this.btnValideAsseoirSScli.BorderRadius = 20;
            this.btnValideAsseoirSScli.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValideAsseoirSScli.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValideAsseoirSScli.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValideAsseoirSScli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValideAsseoirSScli.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValideAsseoirSScli.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValideAsseoirSScli.ForeColor = System.Drawing.Color.White;
            this.btnValideAsseoirSScli.Location = new System.Drawing.Point(45, 206);
            this.btnValideAsseoirSScli.Name = "btnValideAsseoirSScli";
            this.btnValideAsseoirSScli.Size = new System.Drawing.Size(137, 40);
            this.btnValideAsseoirSScli.TabIndex = 17;
            this.btnValideAsseoirSScli.Text = "Valider";
            this.btnValideAsseoirSScli.Click += new System.EventHandler(this.btnValideAsseoirSScli_Click);
            // 
            // textClientId
            // 
            this.textClientId.Location = new System.Drawing.Point(181, 12);
            this.textClientId.Name = "textClientId";
            this.textClientId.Size = new System.Drawing.Size(61, 22);
            this.textClientId.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(25, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom du client";
            // 
            // cbtableSansClient
            // 
            this.cbtableSansClient.FormattingEnabled = true;
            this.cbtableSansClient.Location = new System.Drawing.Point(25, 149);
            this.cbtableSansClient.Name = "cbtableSansClient";
            this.cbtableSansClient.Size = new System.Drawing.Size(121, 24);
            this.cbtableSansClient.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom de la table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Config Asseoir";
            // 
            // dtClient
            // 
            this.dtClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClient.Location = new System.Drawing.Point(45, 85);
            this.dtClient.Name = "dtClient";
            this.dtClient.RowHeadersWidth = 51;
            this.dtClient.RowTemplate.Height = 24;
            this.dtClient.Size = new System.Drawing.Size(511, 230);
            this.dtClient.TabIndex = 15;
            // 
            // RechercheNomClient
            // 
            this.RechercheNomClient.BorderRadius = 20;
            this.RechercheNomClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RechercheNomClient.DefaultText = "Recherche";
            this.RechercheNomClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RechercheNomClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RechercheNomClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RechercheNomClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RechercheNomClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RechercheNomClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RechercheNomClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RechercheNomClient.Location = new System.Drawing.Point(251, 23);
            this.RechercheNomClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RechercheNomClient.Name = "RechercheNomClient";
            this.RechercheNomClient.PasswordChar = '\0';
            this.RechercheNomClient.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RechercheNomClient.PlaceholderText = "";
            this.RechercheNomClient.SelectedText = "";
            this.RechercheNomClient.Size = new System.Drawing.Size(305, 48);
            this.RechercheNomClient.TabIndex = 16;
            this.RechercheNomClient.TextChanged += new System.EventHandler(this.RechercheNomClient_TextChanged);
            // 
            // btnSansClient
            // 
            this.btnSansClient.BorderRadius = 20;
            this.btnSansClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSansClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSansClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSansClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSansClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnSansClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSansClient.ForeColor = System.Drawing.Color.White;
            this.btnSansClient.Location = new System.Drawing.Point(329, 351);
            this.btnSansClient.Name = "btnSansClient";
            this.btnSansClient.Size = new System.Drawing.Size(180, 45);
            this.btnSansClient.TabIndex = 17;
            this.btnSansClient.Text = "Commander Sans Client";
            this.btnSansClient.Click += new System.EventHandler(this.btnSansClient_Click);
            // 
            // btnComandConClient
            // 
            this.btnComandConClient.BorderRadius = 20;
            this.btnComandConClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnComandConClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnComandConClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnComandConClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnComandConClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnComandConClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnComandConClient.ForeColor = System.Drawing.Color.White;
            this.btnComandConClient.Location = new System.Drawing.Point(77, 351);
            this.btnComandConClient.Name = "btnComandConClient";
            this.btnComandConClient.Size = new System.Drawing.Size(180, 45);
            this.btnComandConClient.TabIndex = 18;
            this.btnComandConClient.Text = "Commander Avec Client";
            this.btnComandConClient.Click += new System.EventHandler(this.btnComandConClient_Click);
            // 
            // FormAjoutCommandeSurPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 579);
            this.Controls.Add(this.panelssClient);
            this.Controls.Add(this.btnComandConClient);
            this.Controls.Add(this.btnSansClient);
            this.Controls.Add(this.RechercheNomClient);
            this.Controls.Add(this.dtClient);
            this.Controls.Add(this.panelCreaCommande);
            this.Name = "FormAjoutCommandeSurPlace";
            this.Text = "FormAjoutCommandeSurPlace";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAjoutCommandeSurPlace_FormClosed);
            this.Load += new System.EventHandler(this.FormAjoutCommandeSurPlace_Load);
            this.panelAsseoir.ResumeLayout(false);
            this.panelAsseoir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMoyenPaiement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsServeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTable)).EndInit();
            this.panelCreaCommande.ResumeLayout(false);
            this.panelCreaCommande.PerformLayout();
            this.panelAftAsseoir.ResumeLayout(false);
            this.panelAftAsseoir.PerformLayout();
            this.panelssClient.ResumeLayout(false);
            this.panelssClient.PerformLayout();
            this.pansscliaftaasseoir.ResumeLayout(false);
            this.pansscliaftaasseoir.PerformLayout();
            this.panelSSclientAsseoir.ResumeLayout(false);
            this.panelSSclientAsseoir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsClientDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.ComboBox cbClientSP;
        private System.Windows.Forms.Label labelClientSP;
        private System.Windows.Forms.Label labelMoyenPaieSP;
        private System.Windows.Forms.ComboBox cbMoyenPaieSP;
        private System.Windows.Forms.ComboBox cbServeur;
        private System.Windows.Forms.Label labelNomServeur;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.ComboBox cbTableSP;
        private Guna.UI2.WinForms.Guna2Button btnValiderSP;
        private System.Windows.Forms.Panel panelAsseoir;
        private System.Windows.Forms.Label labelAsseoir;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.BindingSource bsClient;
        private System.Windows.Forms.BindingSource bsMoyenPaiement;
        private System.Windows.Forms.BindingSource bsServeur;
        private System.Windows.Forms.BindingSource bsTable;
        private System.Windows.Forms.TextBox txtIdClient;
        private System.Windows.Forms.Panel panelCreaCommande;
        private System.Windows.Forms.DataGridView dtClient;
        private System.Windows.Forms.BindingSource bsClientDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox RechercheNomClient;
        private Guna.UI2.WinForms.Guna2Button btnSansClient;
        private Guna.UI2.WinForms.Guna2Button btnComandConClient;
        private System.Windows.Forms.TextBox txtNomTable;
        private System.Windows.Forms.Label labelNomTable;
        private System.Windows.Forms.TextBox txtMoyPaieRes;
        private System.Windows.Forms.Label labelMoyPaie;
        private Guna.UI2.WinForms.Guna2Button btnValidAsseoir;
        private System.Windows.Forms.TextBox textIdClientAsseoir;
        private System.Windows.Forms.Panel panelAftAsseoir;
        private System.Windows.Forms.Label labelCommandeSP;
        private System.Windows.Forms.Label labelNomClient;
        private System.Windows.Forms.TextBox txtNomCliSP;
        private System.Windows.Forms.TextBox txtNomServeur;
        private Guna.UI2.WinForms.Guna2Button BtnFinCommandSP;
        private System.Windows.Forms.Panel panelssClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelSSclientAsseoir;
        private Guna.UI2.WinForms.Guna2Button btnValideAsseoirSScli;
        private System.Windows.Forms.TextBox textClientId;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtableSansClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pansscliaftaasseoir;
        private Guna.UI2.WinForms.Guna2Button btnfinssclient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbserveurSsClient;
    }
}