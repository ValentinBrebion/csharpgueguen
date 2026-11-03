using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Gueguen_Csharp
{
    public partial class Form_Connexion_Gueguen : Form
    {

        public int idMatri;
        public Form_Connexion_Gueguen()
        {
            InitializeComponent();
            idMatri = 0;
            txtBoxIdConnexion.Text = "";
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panConn.Controls.Add(formEnfant);
            panConn.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        //******************ComboBox Restaurant ********************************//
        public void ListeRestau(int idMatr)
        {
            
            cbRestau.ValueMember = "ID_RESTAURANT";//permet de stocker l'identifiant
            cbRestau.DisplayMember = "NOM_RESTAURANT";
            bsRestau.DataSource = Modele_gueguen.listeRestau(idMatr);
            cbRestau.DataSource = bsRestau;
            cbRestau.SelectedIndex = -1;
        }

        private void txt_id_Click_1(object sender, EventArgs e)
        {
            txt_id.Text = "";
        }

        private void txt_pass_Click_1(object sender, EventArgs e)
        {
            txt_pass.Text = "";
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked)
            {
                txt_pass.PasswordChar = '\0';
            }
            else
            {
                txt_pass.PasswordChar = '*';
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string identifiant =  txt_id.Text;
            string Password = txt_pass.Text;
            
          

            if (txt_id.Text == "" || Password == "")
            {
                if (Password == "")
                {
                    MessageBox.Show("aucun mot de passe admin n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_id.Text == "")
                {
                    MessageBox.Show("aucun login admin n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (Modele_gueguen.ConnexionDirigeant(identifiant, Password))
                {
                    
   
                    txtBoxIdConnexion.Text = Convert.ToString(Modele_gueguen.GetIdDirigeant());
                    idMatri = Convert.ToInt32(txtBoxIdConnexion.Text);
                    panelRestau.Visible = true;/*AFFICHAGE PANEL RESTAURANT*/
                    GBAdmin.Visible = false;
                    ListeRestau(idMatri);
                    btnAdmingb.Visible = false;
                    btnServeurgb.Visible = false;
                    

                }
                else
                {
                    MessageBox.Show("Mauvais identifiant de l'admin, veuillez recommencer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_id.Text = "";
                    txt_pass.Text = "";
                }
                
            }

        }

        private void gestionFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionFacture());
            changeintoBlack();
            gestionFacturesToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void gestionStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionStock());
            changeintoBlack();
            gestionStockToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void gestionCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionCommandes());
            changeintoBlack();
            gestionCommandesToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Statistiques_Gueguen());
            changeintoBlack();
            statistiquesToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void gestionEmployésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionEmploye());
            changeintoBlack();
            gestionEmployésToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new FormProfil());
            changeintoBlack();
            ProfilToolStripMenuItem.ForeColor = Color.FromArgb(132, 204, 22);
        }

        private void changeintoBlack()
        {
            ProfilToolStripMenuItem.ForeColor = Color.Black;
            gestionEmployésToolStripMenuItem.ForeColor = Color.Black;
            statistiquesToolStripMenuItem.ForeColor = Color.Black;
            gestionCommandesToolStripMenuItem.ForeColor = Color.Black;
            gestionStockToolStripMenuItem.ForeColor = Color.Black;
            gestionFacturesToolStripMenuItem.ForeColor = Color.Black;



        }

        private void btnAdmingb_Click(object sender, EventArgs e)
        {
            
            GBServeur.SendToBack();
            GBAdmin.BringToFront();
            GBAdmin.Visible = true;
            GBServeur.Visible = false;

            GBAdmin.Location = new Point(105, 115);

        }

        private void btnServeurgb_Click(object sender, EventArgs e)
        {

            GBAdmin.SendToBack();
            GBServeur.BringToFront();
            GBServeur.Visible = true;
            GBAdmin.Visible = false;
            GBServeur.Location = new Point(105, 115);


        }

        private void txt_id_serveur_Click(object sender, EventArgs e)
        {
            txt_id_serveur.Text = "";
        }

        private void txt_pass_serveur_Click(object sender, EventArgs e)
        {
            txt_pass_serveur.Text = "";
        }

        private void checkserveur_CheckedChanged(object sender, EventArgs e)
        {
            if (checkserveur.Checked)
            {
                txt_pass_serveur.PasswordChar = '\0';
            }
            else
            {
                txt_pass_serveur.PasswordChar = '*';
            }
        }

        private void btnConnServeur_Click(object sender, EventArgs e)
        {
            string identifiantserveur = txt_id_serveur.Text;
            string Password = txt_pass_serveur.Text;

            if (txt_id.Text == "" || Password == "")
            {
                if (Password == "")
                {
                    MessageBox.Show("aucun mot de passe serveur n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txt_id.Text == "")
                {
                    MessageBox.Show("aucun login serveur n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                if (Modele_gueguen.ConnexionServeur(identifiantserveur, Password))
                {
                    txtidServeur.Text = Convert.ToString(Modele_gueguen.GetIdServeur());
                    txtidrestau.Text = Convert.ToString(Modele_gueguen.GetIdRestaurantSR());
                    menuGueguen.Visible = true;
                    GBconn.Visible = false;
                    gestionFacturesToolStripMenuItem.Visible = false;
                    gestionStockToolStripMenuItem.Visible = false;
                    statistiquesToolStripMenuItem.Visible = false;
                    gestionEmployésToolStripMenuItem.Visible = false;
                    

                }
                else
                {
                    MessageBox.Show("Mauvais identifiant du Serveur, veuillez recommencer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_id_serveur.Text = "";
                    txt_pass_serveur.Text = "";
                }
            }
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //accéder à une propriétée d'un groupbox à partir d'une autre form
            //(System.Windows.Forms.Application.OpenForms["FormProfil"] as FormProfil).gbProfil.Visible = false;

            (System.Windows.Forms.Application.OpenForms["FormProfil"] as FormProfil).Close();
            panAfterConn.Visible = false;
            menuGueguen.Visible = false;
            panelRestau.Visible = false;
            GBAdmin.Visible = false;
            GBServeur.Visible = false;
            btnServeurgb.Visible = true;
            btnAdmingb.Visible = true;
            GBconn.Visible = true;

            if (txtidServeur.Text != "")
            {

                menuGueguen.Visible = false;


                txt_id_serveur.Text = "identifiant Serveur";
                txt_pass_serveur.Text = "Mot de passe";
            }
            
                if (txtBoxIdConnexion.Text != "")
                {
                  
                    txt_id.Text = "Identifiant Admin";
                    txt_pass.Text = "Mot de passe";
                txtidrestau.Text = "";
                
           
               
                menuGueguen.Visible = false;
                bsRestau.DataSource = null;
                txtBoxIdConnexion.Text = "";

            }
           
           

        }

        
        private void buttonValidRestau_Click(object sender, EventArgs e)
        {
            panAfterConn.Visible = true;
            int idDirigeant = Convert.ToInt32(txtBoxIdConnexion.Text); /*affiche data prénom dirigeant*/
            int IdUserDirigeant = Convert.ToInt32(idDirigeant);
            Modele_gueguen.GetProfilStatus(IdUserDirigeant);
            labelnomdirigeant.Text = Modele_gueguen.GetPrenomDirigeant();
            menuGueguen.Visible = true;
            gestionFacturesToolStripMenuItem.Visible = true;
            gestionStockToolStripMenuItem.Visible = true;
            statistiquesToolStripMenuItem.Visible = true;
            gestionEmployésToolStripMenuItem.Visible = true;
            gestionCommandesToolStripMenuItem.Visible = true;
            ProfilToolStripMenuItem.Visible = true;

            panelRestau.Visible = false;
            GBconn.Visible = false;
            labelAfterConn.Visible = true; /*affichage nom du restau à true*/
            labelNomRestau.Text = cbRestau.Text;
            int idrestaur = Modele_gueguen.returnIdRESTAU(cbRestau.Text);
            txtidrestau.Text = Convert.ToString(idrestaur);
        }

       
    }
}
