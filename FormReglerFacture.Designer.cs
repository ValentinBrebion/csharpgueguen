
namespace Projet_Gueguen_Csharp
{
    partial class FormReglerFacture
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
            this.labelInformation = new System.Windows.Forms.Label();
            this.textNumComm = new System.Windows.Forms.TextBox();
            this.labelCommande = new System.Windows.Forms.Label();
            this.cbPaiment = new System.Windows.Forms.ComboBox();
            this.btnValiderPaiment = new Guna.UI2.WinForms.Guna2Button();
            this.bsMoyenPaiment = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsMoyenPaiment)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(18, 9);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(227, 22);
            this.labelInformation.TabIndex = 1;
            this.labelInformation.Text = "Reglement Facture";
            // 
            // textNumComm
            // 
            this.textNumComm.Location = new System.Drawing.Point(211, 50);
            this.textNumComm.Name = "textNumComm";
            this.textNumComm.Size = new System.Drawing.Size(60, 22);
            this.textNumComm.TabIndex = 4;
            // 
            // labelCommande
            // 
            this.labelCommande.AutoSize = true;
            this.labelCommande.Location = new System.Drawing.Point(30, 106);
            this.labelCommande.Name = "labelCommande";
            this.labelCommande.Size = new System.Drawing.Size(215, 17);
            this.labelCommande.TabIndex = 5;
            this.labelCommande.Text = "Sélectionner le mode de paiment";
            // 
            // cbPaiment
            // 
            this.cbPaiment.FormattingEnabled = true;
            this.cbPaiment.Location = new System.Drawing.Point(79, 154);
            this.cbPaiment.Name = "cbPaiment";
            this.cbPaiment.Size = new System.Drawing.Size(121, 24);
            this.cbPaiment.TabIndex = 6;
            // 
            // btnValiderPaiment
            // 
            this.btnValiderPaiment.BorderRadius = 20;
            this.btnValiderPaiment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderPaiment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValiderPaiment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValiderPaiment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValiderPaiment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(204)))), ((int)(((byte)(22)))));
            this.btnValiderPaiment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnValiderPaiment.ForeColor = System.Drawing.Color.White;
            this.btnValiderPaiment.Location = new System.Drawing.Point(50, 200);
            this.btnValiderPaiment.Name = "btnValiderPaiment";
            this.btnValiderPaiment.Size = new System.Drawing.Size(180, 45);
            this.btnValiderPaiment.TabIndex = 7;
            this.btnValiderPaiment.Text = "Valider";
            this.btnValiderPaiment.Click += new System.EventHandler(this.btnValiderPaiment_Click);
            // 
            // FormReglerFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 306);
            this.Controls.Add(this.btnValiderPaiment);
            this.Controls.Add(this.cbPaiment);
            this.Controls.Add(this.labelCommande);
            this.Controls.Add(this.textNumComm);
            this.Controls.Add(this.labelInformation);
            this.Name = "FormReglerFacture";
            this.Text = "FormReglerFacture";
            this.Load += new System.EventHandler(this.FormReglerFacture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMoyenPaiment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.TextBox textNumComm;
        private System.Windows.Forms.Label labelCommande;
        private System.Windows.Forms.ComboBox cbPaiment;
        private Guna.UI2.WinForms.Guna2Button btnValiderPaiment;
        private System.Windows.Forms.BindingSource bsMoyenPaiment;
    }
}