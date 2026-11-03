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
    public partial class FormReglerNote : Form
    {
        public FormReglerNote(int idCommande)
        {
            InitializeComponent();
            textNumComm.Text = Convert.ToString(idCommande);
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
            if(cbPaiment.SelectedIndex == -1)
            {
                MessageBox.Show("vous devez séléctionner un moyen de paiment pour régler la commabde à emporter", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int idNumCom = Convert.ToInt32(textNumComm.Text);
                int idpaiment = cbPaiment.SelectedIndex;
               if( Modele_gueguen.ConfirmPaiment(idNumCom, idpaiment))
                {
                    MessageBox.Show("la commande a bien été réglé !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridView dgv = (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).dtCommandeEmport;
                    (System.Windows.Forms.Application.OpenForms["FormGestionCommandes"] as FormGestionCommandes).rechardataAEmporter(dgv);
                }
                else
                {
                    MessageBox.Show("Erreur lors de la confirmation de paiment !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FormReglerNote_Load(object sender, EventArgs e)
        {
            ListeCategorie();
        }
    }
}
