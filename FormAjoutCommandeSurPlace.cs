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


    public partial class FormAjoutCommandeSurPlace : Form
    {
        public int idClient;
        public int idServeur;
        public int idTable;
        public int idpaiement;

        private EtatGestionCommande etat;
        public FormAjoutCommandeSurPlace(EtatGestionCommande etat)
        {
            InitializeComponent();
            this.etat = etat;
            btnValiderSP.Text = "Ajouter";
        }

        public FormAjoutCommandeSurPlace(EtatGestionCommande etat, string nomClient, string MoyePaie, string NomServeur, string NomTable, int idNumCommEmpor)
        {
            InitializeComponent();
            this.etat = etat;
            txtIdClient.Text = Convert.ToString(idNumCommEmpor);
            txtNomClient.Text = nomClient;
            txtMoyPaieRes.Text = MoyePaie;
            txtNomServeur.Text = NomServeur;
            txtNomTable.Text = NomTable;
            btnValiderSP.Text = "Modifier";
        }
        //******************ComboBox Client ********************************//
        public void ListeClient()
        {
            cbClientSP.ValueMember = "ID_CLIENT";//permet de stocker l'identifiant
            cbClientSP.DisplayMember = "NOM_CLIENT";
            bsClient.DataSource = Modele_gueguen.listeClient();
            cbClientSP.DataSource = bsClient;
            cbClientSP.SelectedIndex = -1;
        }
        //******************ComboBox MoyenPayement ********************************//
        public void ListeMoyenPaiement()
        {
            cbMoyenPaieSP.ValueMember = "IDPAIMENT";//permet de stocker l'identifiant
            cbMoyenPaieSP.DisplayMember = "NOMPAIMENT";
            bsMoyenPaiement.DataSource = Modele_gueguen.listeMoyenPaiement();
            cbMoyenPaieSP.DataSource = bsMoyenPaiement;
            cbMoyenPaieSP.SelectedIndex = -1;
        }
        //******************ComboBox Nom Serveur ********************************//
        public void ListeNomServeur(int idRestau)
        {
            cbServeur.ValueMember = "MATRICULE_SERVEUR";//permet de stocker l'identifiant
            cbServeur.DisplayMember = "NOM_SERVEUR";
            bsServeur.DataSource = Modele_gueguen.ListeNomServeurParRestau(idRestau); //affiche les noms des serveurs en fonction du restaurant
            cbServeur.DataSource = bsServeur;
            cbServeur.SelectedIndex = -1;
        }

        //******************ComboBox Nom Table ********************************//
        public void ListeNomTable(int idRestau)
        {
            
            cbTableSP.ValueMember = "ID_TABLE";//permet de stocker l'identifiant
            cbTableSP.DisplayMember = "NOM_TABLE";
            bsTable.DataSource = Modele_gueguen.listeNomTable(idRestau);
            cbTableSP.DataSource = bsTable;
            cbTableSP.SelectedIndex = -1;

           
        }
        //******************ComboBox Nom Serveur ********************************//
        public void ListeNomServeurssclient(int idRestau)
        {
            cbserveurSsClient.ValueMember = "MATRICULE_SERVEUR";//permet de stocker l'identifiant
            cbserveurSsClient.DisplayMember = "NOM_SERVEUR";
            bsServeur.DataSource = Modele_gueguen.ListeNomServeurParRestau(idRestau); //affiche les noms des serveurs en fonction du restaurant
            cbserveurSsClient.DataSource = bsServeur;
            cbserveurSsClient.SelectedIndex = -1;
        }
        //******************ComboBox Nom Table ********************************//
        public void ListeNomTablessclient(int idRestau)
        {

            cbtableSansClient.ValueMember = "ID_TABLE";//permet de stocker l'identifiant
            cbtableSansClient.DisplayMember = "NOM_TABLE";
            cbtableSansClient.DataSource = Modele_gueguen.listeNomTable(idRestau);
            cbtableSansClient.DataSource = bsTable;
            cbtableSansClient.SelectedIndex = -1;


        }

        private void btnValiderSP_Click(object sender, EventArgs e)
        {

            if(etat == EtatGestionCommande.Ajout) // cas ajout
            {
                int IdClientSP = Convert.ToInt32(cbClientSP.SelectedValue.ToString());
                int IDMoyenPaie = Convert.ToInt32(cbMoyenPaieSP.SelectedValue.ToString());


              /*  if (Modele_gueguen.AjoutCommande(IdClientSP, IDMoyenPaie))
                {
                    MessageBox.Show("ajout commande réussi !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DialogResult diaAjoutCommandeSP = MessageBox.Show("confirmer ?", "Confirmation", MessageBoxButtons.YesNo);
                    if (diaAjoutCommandeSP == DialogResult.Yes)
                    {
                        int idNomServeur = Convert.ToInt32(cbServeur.SelectedValue.ToString());
                        int IdTable = Convert.ToInt32(cbTableSP.SelectedValue.ToString());
                        int IdCommande = Modele_gueguen.RetournerDerniereCommande();
                        Modele_gueguen.ImportCommandeSurPlace(IdCommande, idNomServeur, IdTable);
                    }
                }
                else
                {
                    MessageBox.Show("ajout non effectué !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            else // cas modif
            {

                int idCommandeSurPlace = Convert.ToInt32(txtIdClient.Text);
                /*comp nomClient*/
                int nomClientCB = cbClientSP.SelectedIndex;
                
                /*comp Moyen de payement*/
                int nomMoyPaieCB = cbMoyenPaieSP.SelectedIndex;
               
                /*comp NomServeur*/
                int NomServeurCB = cbServeur.SelectedIndex;
                
                /*comp NomTable*/
                int NomTableCB = cbTableSP.SelectedIndex;
                



                if (nomClientCB != idClient || nomMoyPaieCB != idpaiement || NomServeurCB != idServeur || NomTableCB != idTable)
                {
                  
                  
                 if (Modele_gueguen.ModifInformationCommandeSurPlace(idCommandeSurPlace, idClient, idpaiement, idServeur, idTable))
                    {
                            MessageBox.Show("Modification Informations Serveur Effectuée !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Erreur Modification Informations Commande sur Place !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   



                }









            }
          
        }

        private void FormAjoutCommandeSurPlace_Load(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            bsClientDataGrid.DataSource = Modele_gueguen.ListeRechercheClientDsRestaurant().Select(x => new
            {
                x.NUMERO_COMMANDESP,
                x.ID_CLIENT,
                x.NOM_CLIENT,
                x.PRENOM_CLIENT,
                x.ID_RESTAURANT


            }).Where(x => x.ID_RESTAURANT == idrestau);

            dtClient.DataSource = bsClientDataGrid;
            dtClient.Columns[0].HeaderText = "NUMERO_COMMANDESP";
            dtClient.Columns[1].Visible = false;
            dtClient.Columns[2].HeaderText = "NOM_CLIENT";
            dtClient.Columns[3].HeaderText = "PRENOM_CLIENT";
            dtClient.Columns[4].Visible = false;




            /* ListeClient();
             ListeMoyenPaiement();
             ListeNomServeur();*/
            ListeNomTable(idrestau);
            ListeNomServeurssclient(idrestau);
        }


        //******************Binding source client current changed ********************************//
        private void bsClient_CurrentChanged(object sender, EventArgs e)
        {
           /* if(etat == EtatGestionCommande.Ajout)
            {
                if (cbClientSP.SelectedIndex != -1)
                {
                    // récupération du client sélectionné
                    CLIENT CI = (CLIENT)bsClient.Current;
                    // mise à jour des champs du client sélectionné
                    txtNomClient.Text = CI.NOM_CLIENT;
                    idClient = CI.ID_CLIENT;
                }
            }*/
           
        }

        private void cbClientSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (etat == EtatGestionCommande.Ajout)
            {
                bsClient_CurrentChanged(sender, e);
            }*/
            
               
        }

        //******************Binding source Moyen Paiement current changed ********************************//

        private void bsMoyenPaiement_CurrentChanged(object sender, EventArgs e)
        {
            /*if (etat == EtatGestionCommande.Ajout)
            {
                if (cbMoyenPaieSP.SelectedIndex != -1)
                {
                    // récupération du client sélectionné
                    TYPEPAIMENT TPAIE = (TYPEPAIMENT)bsMoyenPaiement.Current;
                    // mise à jour des champs du client sélectionné
                    txtMoyPaieRes.Text = TPAIE.NOMPAIMENT;
                    idpaiement = TPAIE.IDPAIMENT;
                }
            }*/
            
               
        }

        private void cbMoyenPaieSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (etat == EtatGestionCommande.Ajout)
            {
                bsMoyenPaiement_CurrentChanged(sender, e);
            }*/
               
        }

        //******************Binding source Nom Serveur current changed ********************************//

        private void bsServeur_CurrentChanged(object sender, EventArgs e)
        {
          /*  if (etat == EtatGestionCommande.Ajout)
            {
                if (cbServeur.SelectedIndex != -1)
                {
                    // récupération du client sélectionné
                    SERVEUR SV = (SERVEUR)bsServeur.Current;
                    // mise à jour des champs du client sélectionné
                    txtNomServeur.Text = SV.NOM_SERVEUR;
                    idServeur = SV.MATRICULE_SERVEUR;
                }
            }*/
               
        }

        private void cbServeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (etat == EtatGestionCommande.Ajout)
            {
                bsServeur_CurrentChanged(sender, e);
            }*/
                
        }

        //******************Binding source Nom Table current changed ********************************//

        private void bsTable_CurrentChanged(object sender, EventArgs e)
        {
           /* if (etat == EtatGestionCommande.Ajout)
            {
                if (cbTableSP.SelectedIndex != -1)
                {
                    // récupération du client sélectionné
                    TABLECLIENT TC = (TABLECLIENT)bsTable.Current;
                    // mise à jour des champs du client sélectionné
                    txtNomTable.Text = TC.NOM_TABLE;
                    idTable = TC.ID_TABLE;
                }
            }*/
               
        }

        private void cbTableSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* if (etat == EtatGestionCommande.Ajout)
            {
                bsTable_CurrentChanged(sender, e);
            }*/
               
        }

        private void FormAjoutCommandeSurPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
          /*  DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).dtCommande;
            (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).rechardataSurPlace(dgv);*/
        }

        private void RechercheNomClient_TextChanged(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            var recherche = RechercheNomClient.Text;

            var NomClientRecherche = Modele_gueguen.ListeRechercheClientDsRestaurant().Where(p => p.NOM_CLIENT.Contains(recherche) && p.ID_RESTAURANT == idrestau).ToList();
            dtClient.DataSource = NomClientRecherche;

        }

        private void btnComandConClient_Click(object sender, EventArgs e)
        {
            System.Type type = bsClientDataGrid.Current.GetType();
            int idClient = (int)type.GetProperty("ID_CLIENT").GetValue(bsClientDataGrid.Current, null);
            string NomClient = (string)type.GetProperty("NOM_CLIENT").GetValue(bsClientDataGrid.Current, null);
            panelssClient.Visible = false;
            txtNomCliSP.Text = NomClient;
            panelCreaCommande.Visible = true;
            panelAsseoir.Visible = true;
      
            /*panel Asseoir*/
            textIdClientAsseoir.Text = Convert.ToString(idClient);
            txtNomClient.Text = NomClient;
        }

        private void btnValidAsseoir_Click(object sender, EventArgs e)
        {
            int IdClient = Convert.ToInt32(textIdClientAsseoir.Text);
            int idTable = cbTableSP.SelectedIndex;

            if (Modele_gueguen.SetAsseoir(IdClient, idTable))
            {
               
                    string idmoyPaie = null;
                    if (Modele_gueguen.AjoutCommande(IdClient, idmoyPaie))
                    {
                        MessageBox.Show("Création de la commande réussie !","succès",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        panelAftAsseoir.Visible = true;
                        txtNomTable.Text = cbTableSP.Text;

                        String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
                        int idrestau = Convert.ToInt32(StringIdRestau);
                        ListeNomServeur(idrestau);
                    }
                    else
                    {
                        MessageBox.Show("Erreur dans la création de la commande !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //Some task…
                
                


            }
            else
            {
                MessageBox.Show("Erreur dans l'attribution de la table au client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnFinCommandSP_Click(object sender, EventArgs e)
        {
            int IdServeur = cbServeur.SelectedIndex;
            int idTable = cbTableSP.SelectedIndex;
            int IdCommande = Modele_gueguen.RetournerDerniereCommande();

            if (Modele_gueguen.ImportCommandeSurPlace(IdCommande, IdServeur,idTable))
            {
                MessageBox.Show("Finalisation de la commande réussie !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Erreur dans la finalisation de la création de la commande !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnSansClient_Click(object sender, EventArgs e)
        {
           
            panelssClient.Visible = true;
            panelCreaCommande.Visible = false;
            panelSSclientAsseoir.Visible = true;
            pansscliaftaasseoir.Visible = false;
            textClientId.Text = Convert.ToString(Modele_gueguen.idClientPrem());

            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            ListeNomTablessclient(idrestau);


           

          
        }


        private void btnfinssclient_Click(object sender, EventArgs e)
        {
            int IdServeur = cbserveurSsClient.SelectedIndex;
            int idTable = cbtableSansClient.SelectedIndex;
            int IdCommande = Modele_gueguen.RetournerDerniereCommande();

            if (Modele_gueguen.ImportCommandeSurPlace(IdCommande, IdServeur, idTable))
            {
                MessageBox.Show("Finalisation de la commande réussie !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).dtCommande;
                (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).rechardataSurPlace(dgv);
            }
            else
            {
                MessageBox.Show("Erreur dans la finalisation de la création de la commande !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnValideAsseoirSScli_Click(object sender, EventArgs e)
        {
            int idTable = cbTableSP.SelectedIndex;
            string strIdClient = textClientId.Text;
            int IdClient = Convert.ToInt32(strIdClient);
          

            if (Modele_gueguen.SetAsseoir(IdClient, idTable))
            {

                string idmoyPaie = null;
                if (Modele_gueguen.AjoutCommande(IdClient, idmoyPaie))
                {
                    MessageBox.Show("Création de la commande réussie !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pansscliaftaasseoir.Visible = true;
                    txtNomTable.Text = cbTableSP.Text;

                    String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
                    int idrestau = Convert.ToInt32(StringIdRestau);
                    ListeNomServeurssclient(idrestau);
                }
                else
                {
                    MessageBox.Show("Erreur dans la création de la commande !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                //Some task…




            }
            else
            {
                MessageBox.Show("Erreur dans l'attribution de la table au client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
