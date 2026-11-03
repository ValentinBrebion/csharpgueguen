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
    public partial class FormAjoutCommandeEmpor : Form
    {
        private EtatGestionCommande etat;
      

        public FormAjoutCommandeEmpor(EtatGestionCommande etat , string nomClient , string MoyePaie, int idNumCommEmpor)
        {
            InitializeComponent();
            this.etat = etat;
            txtNumCom.Text = Convert.ToString(idNumCommEmpor);
            textboxClient.Text = nomClient;
            txtModePaiement.Text = MoyePaie;
            btnValiderEmporter.Text = "Modifier";
        }

        //******************ComboBox Client ********************************//
        public void ListeClient()
        {
            cbClient.ValueMember = "ID_CLIENT";//permet de stocker l'identifiant
            cbClient.DisplayMember = "NOM_CLIENT";
            bsClient.DataSource = Modele_gueguen.listeClient();
            cbClient.DataSource = bsClient;
            cbClient.SelectedIndex = -1;
        }

        //******************ComboBox MoyenPayement ********************************//
        public void ListeMoyenPaiement()
        {
            cbPaiement.ValueMember = "IDPAIMENT";//permet de stocker l'identifiant
            cbPaiement.DisplayMember = "NOMPAIMENT";
            bsPaiement.DataSource = Modele_gueguen.listeMoyenPaiement();
            cbPaiement.DataSource = bsPaiement;
            cbPaiement.SelectedIndex = -1;
        }

        private void btnValiderEmporter_Click(object sender, EventArgs e)
        {

        
            
            
               
             
               
               
            

           
        }


  
        private void bsClient_CurrentChanged(object sender, EventArgs e)
        {
           if(etat == EtatGestionCommande.Ajout)
            {

            

                if (cbClient.SelectedIndex != -1)
                {

                    // récupération du client sélectionné
                    CLIENT CLI = (CLIENT)bsClient.Current;

                    // mise à jour des champs du client sélectionné
                    textboxClient.Text = CLI.NOM_CLIENT;
                

                }
            }
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(etat == EtatGestionCommande.Ajout)
            {
                bsClient_CurrentChanged(sender, e);
            }
            
        }

        private void bsPaiement_CurrentChanged(object sender, EventArgs e)
        {
            if(etat == EtatGestionCommande.Ajout)
            {
                if (cbPaiement.SelectedIndex != -1)
                {
                    TYPEPAIMENT TP = (TYPEPAIMENT)bsPaiement.Current;

                    txtModePaiement.Text = TP.NOMPAIMENT;
                }
            }
            
        }

        private void cbPaiement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(etat == EtatGestionCommande.Ajout)
            {
                bsPaiement_CurrentChanged(sender, e);
            }
            
        }


        private void FormAjoutCommandeEmpor_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).dtCommande;
            (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).rechardataAEmporter(dgv);
        }

        private void FormAjoutCommandeEmpor_Load(object sender, EventArgs e)
        {
            ListeClient();
            ListeMoyenPaiement();
        }
    }
}
