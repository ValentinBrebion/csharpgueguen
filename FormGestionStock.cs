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
    public enum EtatGestionProduit
    {
        AjoutProduit,
        ModifProduit
    }
    public partial class FormGestionStock : Form
    {
        private EtatGestionProduit etat;
        public FormGestionStock(EtatGestionProduit etat)
        {
            InitializeComponent();
            this.etat = etat;
        }

        public FormGestionStock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Recharge datagridview 
        /// </summary>
        /// <param name="dgv"></param>
        public void rechardataStock(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            bsStock.DataSource = Modele_gueguen.GetListStock().Select(x => new
            {
                x.ID_PRODUIT,
                x.NOM_PRODUIT,
                x.ID_RESTAURANT,
                x.ID_CATEGORIE,
                x.SEUILMINIMAL,
                x.SEUILACTUEL,
                x.SEUILMAXIMAL,
                x.PRIXHT_PRODUIT,
                x.DESCRIPTION_PRODUIT,
                x.IMAGE_CATEGORIE,
                x.NOM_CATEGORIE,
                x.Archiv


            }).Where(x => x.ID_RESTAURANT == idrestau && x.Archiv == false);

            dtStock.DataSource = bsStock;
            dtStock.Columns[0].HeaderText = "ID_PRODUIT";
            dtStock.Columns[1].HeaderText = "NOM_PRODUIT";
            dtStock.Columns[2].Visible = false;/* ID_RESTAURANT */
            dtStock.Columns[3].Visible = false;/* ID_CATEGORIE */
            dtStock.Columns[4].HeaderText = "SEUILMINIMAL";
            dtStock.Columns[5].HeaderText = "SEUILACTUEL";
            dtStock.Columns[6].HeaderText = "SEUILMAXIMAL";
            dtStock.Columns[7].Visible = false;/* PRIXHT_PRODUIT */
            dtStock.Columns[8].Visible = false;/* DESCRIPTION_PRODUIT */
            dtStock.Columns[9].Visible = false;/* IMAGE_CATEGORIE */
            dtStock.Columns[10].Visible = false;/* NOM_CATEGORIE */
            dtStock.Columns[11].Visible = false;/* Archiv */
        }





        private void FormGestionStock_Load(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            List<v_stock3> ListStock = Modele_gueguen.GetListStock();

            if (ListStock.Any())
            {
                //Début datagrid view pour lister les commandes sur place
                bsStock.DataSource = Modele_gueguen.GetListStock().Select(x => new
                {
                    x.ID_PRODUIT,
                    x.NOM_PRODUIT,
                    x.ID_RESTAURANT,
                    x.ID_CATEGORIE,
                    x.SEUILMINIMAL,
                    x.SEUILACTUEL,
                    x.SEUILMAXIMAL,
                    x.PRIXHT_PRODUIT,
                    x.DESCRIPTION_PRODUIT,
                    x.IMAGE_CATEGORIE,
                    x.NOM_CATEGORIE,
                    x.Archiv


                }).Where(x => x.ID_RESTAURANT == idrestau && x.Archiv == false);

                dtStock.DataSource = bsStock;
                dtStock.Columns[0].HeaderText = "ID_PRODUIT";
                dtStock.Columns[1].HeaderText = "NOM_PRODUIT";
                dtStock.Columns[2].Visible = false;/* ID_RESTAURANT */
                dtStock.Columns[3].Visible = false;/* ID_CATEGORIE */
                dtStock.Columns[4].HeaderText = "SEUILMINIMAL";
                dtStock.Columns[5].HeaderText = "SEUILACTUEL";
                dtStock.Columns[6].HeaderText = "SEUILMAXIMAL";
                dtStock.Columns[7].Visible = false;/* PRIXHT_PRODUIT */
                dtStock.Columns[8].Visible = false;/* DESCRIPTION_PRODUIT */
                dtStock.Columns[9].Visible = false;/* IMAGE_CATEGORIE */
                dtStock.Columns[10].Visible = false;/* NOM_CATEGORIE */
                dtStock.Columns[11].Visible = false;/* Archiv */

            }
            else
            {
                dtStock.DataSource = null;
                dtStock.Rows.Clear();
                dtStock.Columns.Clear();
                dtStock.AllowUserToAddRows = false;
                dtStock.RowCount = 1;
                dtStock.ColumnCount = 1;
                dtStock.Rows[0].Cells[0].Value = "Il n'y a pas de produit pour le restaurant.";
                dtStock.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void btn_Commander_Click(object sender, EventArgs e)
        {
            System.Type type = bsStock.Current.GetType();
            int idProd = (int)type.GetProperty("ID_PRODUIT").GetValue(bsStock.Current, null);
            long QTEMax = (long)type.GetProperty("SEUILMAXIMAL").GetValue(bsStock.Current, null);
            long QTEActu = (long)type.GetProperty("SEUILACTUEL").GetValue(bsStock.Current, null);
            int qteSeuil = Convert.ToInt32(txtQTE.Text);
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idRestaurant = Convert.ToInt32(StringIdRestau);


            if (txtQTE.Text == "" || Convert.ToInt32(txtQTE.Text) <= 0 )
            {
                MessageBox.Show("erreur dans l'ajout de la quantité au produit séléctionné", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
               if(QTEActu > QTEMax || qteSeuil + QTEActu > QTEMax)
                {
                    MessageBox.Show("Vous avez atteint la quantité max pour ce produit", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                   
                    if (Modele_gueguen.AjoutSeuilActuel(idProd, qteSeuil))
                    {
                        string nomProduit = (string)type.GetProperty("NOM_PRODUIT").GetValue(bsStock.Current, null);
                        MessageBox.Show("Vous avez bien ajouté " + qteSeuil + " au produit " + nomProduit + " ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                  

                    if (Modele_gueguen.AjoutHistoStock(idProd, idRestaurant, qteSeuil))
                      {
                                MessageBox.Show("L'historique du stock a bien été enregistré", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                rechardataStock(dtStock);
                            }
                            else
                            {
                                MessageBox.Show("erreur dans l'historisation du stock", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                       
                    }
                    else
                    {
                        MessageBox.Show("erreur dans l'ajout de la quantité au produit séléctionné", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                    
                
                    
                

            

        }

        private void btnAjoutProduit_Click(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idRestaurant = Convert.ToInt32(StringIdRestau);
            Form_GestionProduitStock FAE = new Form_GestionProduitStock(EtatGestionProduit.AjoutProduit, idRestaurant);
            FAE.Show();
        }

        private void btnArchiverProd_Click(object sender, EventArgs e)
        {
            System.Type type = bsStock.Current.GetType();
            int idMe = (int)type.GetProperty("ID_PRODUIT").GetValue(bsStock.Current, null);

            if (Modele_gueguen.ArchivageProdStock(idMe))
            {
                MessageBox.Show("Archivage Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rechardataStock(dtStock);
            }
            else
            {
                MessageBox.Show("Archivage non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RecherchetxtStock_TextChanged(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            var recherche = RecherchetxtStock.Text;
           
            var NomClientRecherche = Modele_gueguen.GetListStock().Where(p => p.NOM_PRODUIT.Contains(recherche) && p.ID_RESTAURANT == idrestau).ToList();
            dtStock.DataSource = NomClientRecherche;
        }

        private void btnModifProduit_Click(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;

            System.Type type = bsStock.Current.GetType();
            int idProd = (int)type.GetProperty("ID_PRODUIT").GetValue(bsStock.Current, null);
            int NomCatego = (int)type.GetProperty("ID_CATEGORIE").GetValue(bsStock.Current, null);
            int idrestau = Convert.ToInt32(StringIdRestau);
            long seuilActu = (long)type.GetProperty("SEUILACTUEL").GetValue(bsStock.Current, null);
            long seuilMin = (long)type.GetProperty("SEUILMINIMAL").GetValue(bsStock.Current, null);
            long seuilMax = (long)type.GetProperty("SEUILMAXIMAL").GetValue(bsStock.Current, null);
            double PrixHTProd = (double)type.GetProperty("PRIXHT_PRODUIT").GetValue(bsStock.Current, null);
            string nomProd = (string)type.GetProperty("NOM_PRODUIT").GetValue(bsStock.Current, null);
            string descriptionProd = (string)type.GetProperty("DESCRIPTION_PRODUIT").GetValue(bsStock.Current, null);
            string imgProd = (string)type.GetProperty("IMAGE_CATEGORIE").GetValue(bsStock.Current, null);

            Form_GestionProduitStock FAE = new Form_GestionProduitStock(EtatGestionProduit.ModifProduit, idProd, NomCatego, idrestau, seuilActu, seuilMin,seuilMax, PrixHTProd, nomProd, descriptionProd, imgProd);
            FAE.Show();

         
        }
    }
}
