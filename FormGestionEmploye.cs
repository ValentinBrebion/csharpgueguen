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
    public enum EtatGestionServeur
    {
        Ajout,
        Modif
    }
    public partial class FormGestionEmploye : Form
    {
        private EtatGestionServeur etat;

        public FormGestionEmploye(EtatGestionServeur etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
        public FormGestionEmploye()
        {
            InitializeComponent();
        }

        private void FormGestionEmploye_Load(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text ;
            int idrestau = Convert.ToInt32(StringIdRestau);
            //Début datagrid view pour lister les commandes sur place
            bsServeur.DataSource = Modele_gueguen.GetListeServeur().Select(x => new
            {
                x.MATRICULE_SERVEUR,
                x.NOM_SERVEUR,
                x.PRENOM_SERVEUR,
                x.ID_RESTAURANT,
                x.MAIL_SERVEUR,/*4*/
                x.TEL_SERVEUR,/*5*/
                x.DATEARRIVEE_SERVEUR,/*6*/

                x.password,/*7*/


                x.DATENAISS_SERVEUR/*8*/

            }).Where(x => x.ID_RESTAURANT == idrestau);

            dtEmploye.DataSource = bsServeur;
            dtEmploye.Columns[0].HeaderText = "MATRICULE_SERVEUR";
            dtEmploye.Columns[1].HeaderText = "NOM_SERVEUR";
            dtEmploye.Columns[2].HeaderText = "PRENOM_SERVEUR";
            dtEmploye.Columns[3].Visible = false;
            dtEmploye.Columns[4].Visible = false;
            dtEmploye.Columns[5].Visible = false;
            dtEmploye.Columns[6].Visible = false;
            dtEmploye.Columns[7].Visible = false;
            dtEmploye.Columns[8].Visible = false;



            //Fin datagrid view pour lister les commandes sur place
        }

        public void rechardataServeur(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            bsServeur.DataSource = Modele_gueguen.GetListeServeur().Select(x => new
            {
                x.MATRICULE_SERVEUR,/*0*/
                x.ID_RESTAURANT,/*1*/
                x.NOM_SERVEUR,/*2*/
                x.PRENOM_SERVEUR,/*3*/
                x.MAIL_SERVEUR,/*4*/
                x.TEL_SERVEUR,/*5*/
                x.DATEARRIVEE_SERVEUR,/*6*/

                x.password,/*7*/


                x.DATENAISS_SERVEUR/*8*/

            }).Where(x => x.ID_RESTAURANT == idrestau);

            dtEmploye.DataSource = bsServeur;
            dtEmploye.Columns[0].HeaderText = "MATRICULE_SERVEUR";
            dtEmploye.Columns[1].Visible = false;
            dtEmploye.Columns[2].HeaderText = "NOM_SERVEUR";
            dtEmploye.Columns[3].HeaderText = "PRENOM_SERVEUR";
            dtEmploye.Columns[4].Visible = false;
            dtEmploye.Columns[5].Visible = false;
            dtEmploye.Columns[6].Visible = false;
            dtEmploye.Columns[7].Visible = false;
            dtEmploye.Columns[8].Visible = false;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            FormAjoutEmploye FAE = new FormAjoutEmploye(EtatGestionServeur.Ajout);
            FAE.Show();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            System.Type type = bsServeur.Current.GetType();
            int idH = (int)type.GetProperty("MATRICULE_SERVEUR").GetValue(bsServeur.Current, null);
            if (Modele_gueguen.SupprServeur(idH))
            {
                MessageBox.Show("Suppression Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                rechardataServeur(dtEmploye);
            }
            else
            {
                MessageBox.Show("Suppression non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            System.Type type = bsServeur.Current.GetType();
            int idServe = (int)type.GetProperty("MATRICULE_SERVEUR").GetValue(bsServeur.Current, null);
            string NomServ = (string)type.GetProperty("NOM_SERVEUR").GetValue(bsServeur.Current, null);
            string PrenomServe = (string)type.GetProperty("PRENOM_SERVEUR").GetValue(bsServeur.Current, null);
            string mailServ = (string)type.GetProperty("MAIL_SERVEUR").GetValue(bsServeur.Current, null);
            string telServ = (string)type.GetProperty("TEL_SERVEUR").GetValue(bsServeur.Current, null);
            DateTime datearrivServ = (DateTime)type.GetProperty("DATEARRIVEE_SERVEUR").GetValue(bsServeur.Current, null);
            DateTime DateNaissServ = (DateTime)type.GetProperty("DATENAISS_SERVEUR").GetValue(bsServeur.Current, null);

            FormAjoutEmploye FAE = new FormAjoutEmploye(EtatGestionServeur.Modif, idServe, NomServ, PrenomServe, mailServ, telServ, datearrivServ, DateNaissServ);
            FAE.Show();

           
        }

        private void RecherchetxtEmploye_TextChanged(object sender, EventArgs e)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            var recherche = RecherchetxtEmploye.Text;

            var NomClientRecherche = Modele_gueguen.GetListeServeur().Where(p => p.NOM_SERVEUR.Contains(recherche) && p.ID_RESTAURANT == idrestau).ToList();
            dtEmploye.DataSource = NomClientRecherche;
        }
    }
}
