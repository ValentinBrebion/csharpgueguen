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
    
    public partial class FormReglerFacture : Form
    {
        private EtatGestionCommande etat;
        public FormReglerFacture(int numCom)
        {
            InitializeComponent();

            textNumComm.Text = Convert.ToString(numCom);
        }
        public FormReglerFacture()
        {
            InitializeComponent();
        }

        public void ListeCategorie()
        {
            cbPaiment.ValueMember = "IDPAIMENT";//permet de stocker l'identifiant
            cbPaiment.DisplayMember = "NOMPAIMENT";
            bsMoyenPaiment.DataSource = Modele_gueguen.listeMoyenPaiement();
            cbPaiment.DataSource = bsMoyenPaiment;
            cbPaiment.SelectedIndex = -1;
        }

        private void btnValiderPaiment_Click(object sender, EventArgs e)
        {

            if (cbPaiment.SelectedIndex == -1)
            {
                MessageBox.Show("vous devez séléctionner un moyen de paiment pour régler la commabde à emporter", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idNumCom = Convert.ToInt32(textNumComm.Text);
                int idpaiment = cbPaiment.SelectedIndex;
                if (Modele_gueguen.ConfirmPaiment(idNumCom, idpaiment))
                {
                    MessageBox.Show("la commande a bien été réglé !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionFacture"] as FormGestionFacture).dtFacture;
                    (System.Windows.Forms.Application.OpenForms["FormGestionFacture"] as FormGestionFacture).RechargeDataCommande(dgv);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la confirmation de paiment !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormReglerFacture_Load(object sender, EventArgs e)
        {
            ListeCategorie();
        }
    }
}
