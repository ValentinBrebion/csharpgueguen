using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Gueguen_Csharp
{
    public partial class FormAjoutEmploye : Form
    {
        private EtatGestionServeur etat;
        /*COMPARAISON VARIABLES*/
        public string NomServeurComp;
        public string prenomServeurComp;
        public string MailServeurComp;
        public string telServeurComp;
        public DateTime dtArriveServeurComp;
        public DateTime dtNaissanceServeur;

        /*VARIABLES COMP 2*/
        public string NomSECOMP;
        public string PREservComp;
        public string EmailServ;
        public string teleServ;
        public string datArriveSE;
        public DateTime dtConvArrivServ;
        public string DateNaisServSE;
        public DateTime dtConvNaissServ;

        public FormAjoutEmploye(EtatGestionServeur etat, int idServe, string NomServ, string PrenomServe, string mailServ, string telServ, DateTime datearrivServ, DateTime DateNaissServ)
        {
            InitializeComponent();
            this.etat = etat;
            txtIdServ.Text = Convert.ToString(idServe);
            txtNomServeur.Text = NomServ;
            NomSECOMP += NomServ;
            txtPrenomServeur.Text = PrenomServe;
            PREservComp += PrenomServe;
            txtMailServeur.Text = mailServ;
            EmailServ += mailServ;
            txtTelServeur.Text = telServ;
            teleServ += telServ;
            dtArriveServeur.Value = datearrivServ;
            datArriveSE += datearrivServ;
            dtConvArrivServ = Convert.ToDateTime(datArriveSE);
            dtNaiss.Value = DateNaissServ;
            DateNaisServSE += DateNaissServ;
            dtConvNaissServ = Convert.ToDateTime(DateNaissServ);
            labelAjoutServeur.Text = "Modifier Serveur";
            btnValiderAjoutServ.Text = "Modifier";

        }
        public FormAjoutEmploye(EtatGestionServeur etat)
        {
            InitializeComponent();
            this.etat = etat;
            labelAjoutServeur.Text = "Ajouter Serveur";
            btnValiderAjoutServ.Text = "Ajouter";
        }

        //******************ComboBox Restaurant ********************************//
       

        private void btnValiderAjoutEmp_Click(object sender, EventArgs e)
        {
            String idRestaurant = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int IDRESTAURANT = Convert.ToInt32(idRestaurant);

            string NomServeur = txtNomServeur.Text;
            string PrenomServeur = txtPrenomServeur.Text;
            string MailServeur = txtMailServeur.Text;
            string MdpServeur = txtMdpServeur.Text;
            string telServeur = txtTelServeur.Text;
            DateTime dtArrive = dtArriveServeur.Value;
            DateTime dateNaiss = dtNaiss.Value;
            

            if (etat == EtatGestionServeur.Ajout)
            {
                if (NomServeur == "" || PrenomServeur == "" || MailServeur == "" || MdpServeur == "" || telServeur == "" || IDRESTAURANT < -1 || dtArrive.Date > DateTime.Now || dateNaiss.Date > DateTime.Now)
                {
                    MessageBox.Show("Veuillez remplir correctement toutes vos Informations", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if(Modele_gueguen.AjoutServeur(NomServeur, PrenomServeur, MailServeur, MdpServeur, telServeur, dateNaiss, IDRESTAURANT, dtArrive))
                    {
                        MessageBox.Show("Ajout Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        MessageBox.Show("Erreur Ajout !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
                    }
                }
            }
            else
            {
                
                int idServeur = Convert.ToInt32(txtIdServ.Text);

                if(NomServeur != NomSECOMP || PrenomServeur != PREservComp || MailServeur != EmailServ || telServeur != teleServ || dtArrive != dtConvArrivServ || dateNaiss != dtConvNaissServ)
                {
                    if (CheckMdpServeur.Checked)
                    {
                        string mdpServeur = txtMdpServeur.Text;
                        if (Modele_gueguen.ModifInformationServeur(idServeur, NomServeurComp, prenomServeurComp, MailServeurComp, telServeurComp, dtArriveServeurComp, dtNaissanceServeur, mdpServeur))
                        {
                            MessageBox.Show("Modification Effectuée avec mot de passe!", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Modification Erreur sans mot de passe!", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (Modele_gueguen.ModifInformationServeur(idServeur, NomServeurComp, prenomServeurComp, MailServeurComp, telServeurComp, dtArriveServeurComp, dtNaissanceServeur))
                        {
                            MessageBox.Show("Modification Informations Serveur Effectuée !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                   
                   
                }
            }
               
        }

        private void FormAjoutEmploye_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionEmploye"] as FormGestionEmploye).dtEmploye;
            (System.Windows.Forms.Application.OpenForms["FormGestionEmploye"] as FormGestionEmploye).rechardataServeur(dgv);
        }

        private void CheckMdpServeur_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckMdpServeur.Checked)
            {
                txtMdpServeur.Visible = true;
            }
            else
            {
                txtMdpServeur.Visible = false;
            }
        }

        private void txtNomServeur_TextChanged(object sender, EventArgs e)
        {
            NomServeurComp = txtNomServeur.Text;
        }

        private void txtPrenomServeur_TextChanged(object sender, EventArgs e)
        {
            prenomServeurComp = txtPrenomServeur.Text;
        }

        private void txtMailServeur_TextChanged(object sender, EventArgs e)
        {
            MailServeurComp = txtMailServeur.Text;
        }

        private void txtTelServeur_TextChanged(object sender, EventArgs e)
        {
            telServeurComp = txtTelServeur.Text;
        }

        private void dtArriveServeur_ValueChanged(object sender, EventArgs e)
        {
            dtArriveServeurComp = dtArriveServeur.Value;
        }

        private void dtNaiss_ValueChanged(object sender, EventArgs e)
        {
            dtNaissanceServeur = dtNaiss.Value;
        }
    }
}
