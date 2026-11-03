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
    public partial class Form_GestionProduitStock : Form
    {
        /*Variables valeurs constructeur*/
        public int idCategoComp;
        public long seuilActuComp;
        public long seuilMinComp;
        public long seuilMaxComp;
        public double PrixHTProdComp;
        public string nomProdComp;
        public int nomCategoComp;
        public string descriProdComp;
        public string imgProdComp;

        /*variables valeurs textchanged*/
        public int IdCategoriechanged;
        public long seuilActuchanged;
        public long seuilMinchanged;
        public long seuilMaxchanged;
        public double PrixHTProdchanged;
        public string nomProdchanged;
        public string descriProdchanged;
        public string imgProdchanged;




        private EtatGestionProduit etat;
        public Form_GestionProduitStock()
        {
            InitializeComponent();
        }
        public Form_GestionProduitStock(EtatGestionProduit etat, int idRestau)
        {
            InitializeComponent();
            this.etat = etat;
            labelStatusProduit.Text = "Ajouter d'un produit";
            txtidRestau.Text = Convert.ToString(idRestau);
            btnValideProd.Visible = true;
            BTNValidProd.Visible = true;
            modifProd.Visible = false;
            ListeCategorie();
        }

        public Form_GestionProduitStock(EtatGestionProduit etat, int idProd,int IdCatego, int idrestau,long seuilActu,long seuilMin,long seuilMax,double PrixHTProd,string nomProd,string descriptionProd,string imgProd)
        {

            InitializeComponent();
            ListeCategorie();

            txtidCatego.Text = Convert.ToString(IdCatego);
            int idCatego = Convert.ToInt32(txtidCatego.Text);

            cbCatego.ValueMember = "ID_CATEGORIE";//permet de stocker l'identifiant
            cbCatego.DisplayMember = "NOM_CATEGORIE";
            bsCategorie.DataSource = Modele_gueguen.ListCatégorie();
            cbCatego.DataSource = bsCategorie;
            cbCatego.SelectedIndex = idCatego-1;

            this.etat = etat;
            labelStatusProduit.Text = "Modifier un produit";
            btnValideProd.Visible = false;
            BTNValidProd.Visible = false;
            modifProd.Visible = true;
            panelSeuil.Visible = true;

            /*Attribution états */
            txtIdProd.Text = Convert.ToString(idProd);
           /* cbCatego.Text = IdCatego;*/
            nomCategoComp += IdCatego;



            txtidRestau.Text = Convert.ToString(idrestau);
            txtseuilActuel.Text = Convert.ToString(seuilActu);
            seuilActuComp += seuilActu;
            txtseuilMin.Text = Convert.ToString(seuilMin);
            seuilMinComp += seuilMin;
            txtSeuilMax.Text = Convert.ToString(seuilMax);
            seuilMaxComp += seuilMax;
            txtprixHTPROD.Text = Convert.ToString(PrixHTProd);
            PrixHTProdComp += PrixHTProd;
            txtNomProd.Text = nomProd;
            nomProdComp += nomProd;
            descri.Text = descriptionProd;
            descriProdComp += descriptionProd;
            txtimg_prod.Text = imgProd;
            imgProdComp += imgProd;
        }
        

        //******************ComboBox Catégorie ********************************//



        public void ListeCategorie()
        {
            cbCatego.ValueMember = "ID_CATEGORIE";//permet de stocker l'identifiant
            cbCatego.DisplayMember = "NOM_CATEGORIE";
            bsCategorie.DataSource = Modele_gueguen.ListCatégorie();
            cbCatego.DataSource = bsCategorie;
            cbCatego.SelectedIndex = -1;
        }

        
        private void Form_GestionProduitStock_Load(object sender, EventArgs e)
        {
           /* ListeCategorie();*/
        }

        private void btnValideProd_Click(object sender, EventArgs e)
        {
            int idCatego = cbCatego.SelectedIndex;
            string nomProd = txtNomProd.Text;
            string descriProd = descri.Text;

            if (Modele_gueguen.AjoutProd(idCatego, nomProd, descriProd))
            {
                MessageBox.Show("produit ajouté place à la customisation");
                panelSeuil.Visible = true;
            }
            else
            {
                MessageBox.Show("Erreur ajout Produit Verifiez les informations");
            }
        }

        private void BTNValidProd_Click(object sender, EventArgs e)
        {
            int idProd = Modele_gueguen.lastInsertProd();
            int idRestau = Convert.ToInt32(txtidRestau.Text);
            double PrixHT = Convert.ToDouble(txtprixHTPROD.Text);
            long seuilActuel = Convert.ToInt64(txtseuilActuel.Text);
            long seuilMin = Convert.ToInt64(txtseuilMin.Text);
            long seuilMax = Convert.ToInt64(txtSeuilMax.Text);
            string imgProd = txtimg_prod.Text;
            bool Archi = false;

            if(seuilActuel >= seuilMin && seuilActuel < seuilMax)
            {
                if (Modele_gueguen.AjoutProdFin(idProd, idRestau, PrixHT, seuilActuel, seuilMin, seuilMax, imgProd, Archi))
                {
                    MessageBox.Show("produit ajouté fin au restaurant");
                    DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionStock"] as FormGestionStock).dtStock;
                    (System.Windows.Forms.Application.OpenForms["FormGestionStock"] as FormGestionStock).rechardataStock(dgv);
                }
                else
                {
                    MessageBox.Show("Erreur lors de l'ajout produit au restaurant","Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erreur Vous devez mettre le seuil actuel supérieur au seuil minimal et inférieur au seuil maximal", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void modifProd_Click(object sender, EventArgs e)
        {
            long seuilActuel = Convert.ToInt64(txtseuilActuel.Text);
            long seuilMin = Convert.ToInt64(txtseuilMin.Text);
            int idProd = Convert.ToInt32(txtIdProd.Text);
            long seuilMax = Convert.ToInt64(txtSeuilMax.Text);
            double PrixHT = Convert.ToDouble(txtprixHTPROD.Text);
            string descriProd = descri.Text;
            string imgProd = txtimg_prod.Text;
            string nomProd = txtNomProd.Text;
            int NomCatego =  cbCatego.SelectedIndex;
            

     
            if (seuilActuel != seuilActuchanged || seuilMin != seuilMinComp || seuilMax != seuilMaxComp || PrixHTProdComp != PrixHT || descriProdComp != descriProd || imgProdComp != imgProd || nomProdComp != nomProd || nomCategoComp != NomCatego)
            {
                
               
                    if (Modele_gueguen.modifProduitStock(idProd, seuilActuchanged, seuilMinchanged, seuilMaxchanged, PrixHTProdchanged, imgProdchanged, descriProdchanged, nomProdchanged, IdCategoriechanged))
                    {
                        MessageBox.Show("Modification Informations Produit Effectuée !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                    MessageBox.Show("Erreur Modification Informations Produit !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                



            }
        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {
            nomProdchanged = txtNomProd.Text;
        }

        private void cbCatego_SelectedIndexChanged(object sender, EventArgs e)
        {
            IdCategoriechanged = cbCatego.SelectedIndex;
        }

        private void txtprixHTPROD_TextChanged(object sender, EventArgs e)
        {
            if(txtprixHTPROD.Text == "")
            {

            }
            else
            {
                PrixHTProdchanged = Convert.ToDouble(txtprixHTPROD.Text);
            }
            
        }

        private void txtseuilActuel_TextChanged(object sender, EventArgs e)
        {
            if(txtseuilActuel.Text == "")
            {

            }
            else
            {
                seuilActuchanged = Convert.ToInt64(txtseuilActuel.Text);
            }
         
        }

        private void txtseuilMin_TextChanged(object sender, EventArgs e)
        {
            if(txtseuilMin.Text == "")
            {

            }
            else
            {
                seuilMinchanged = Convert.ToInt64(txtseuilMin.Text);
            }
           
        }

        private void txtSeuilMax_TextChanged(object sender, EventArgs e)
        {
            if(txtSeuilMax.Text == "")
            {

            }
            else
            {
                seuilMaxchanged = Convert.ToInt64(txtSeuilMax.Text);
            }
           
        }

        private void txtimg_prod_TextChanged(object sender, EventArgs e)
        {
            imgProdchanged = txtimg_prod.Text;
        }

        private void descri_TextChanged(object sender, EventArgs e)
        {
            descriProdchanged = descri.Text;
        }

        private void Form_GestionProduitStock_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionStock"] as FormGestionStock).dtStock;
            (System.Windows.Forms.Application.OpenForms["FormGestionStock"] as FormGestionStock).rechardataStock(dgv);
        }
    }
}
