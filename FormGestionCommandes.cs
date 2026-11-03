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
    public enum EtatGestionCommande
    {
        Ajout,
        Modif
    }

    public partial class FormGestionCommandes : Form
    {
        private EtatGestionCommande etat;
        public FormGestionCommandes(EtatGestionCommande etat)
        {
            InitializeComponent();
            this.etat = etat;
        }
      
        public FormGestionCommandes()
        {
            InitializeComponent();
           
        }

        private void FormGestionCommandes_Load(object sender, EventArgs e)
        {
            labelCommande.Visible = true;
            labelCommande.Text = "Sur Place";

                lblEtatDatagridview.Visible = false;
                dtCommande.Visible = true;

            List<ListeCommandeSurPlaceDate> listecommandeSP = Modele_gueguen.listeCommandeSurPlace();

            if (listecommandeSP.Any())
            {
                BSCommandeSurPlace.DataSource = listecommandeSP.Select(x => new
                {
                    x.NUMERO_COMMANDE,
                    x.IDPAIMENT,
                    x.ID_CLIENT,
                    x.NOM_CLIENT,
                    x.NOM_TABLE,
                    x.POURCENTAGETVA,
                    x.dateCommande,
                    x.ID_TABLE,
                    x.MATRICULE_SERVEUR,
                    x.Archivsurplace
                });
                dtCommande.DataSource = BSCommandeSurPlace;
                dtCommande.Columns[0].HeaderText = "NUMERO_COMMANDE";
                dtCommande.Columns[1].Visible = false;
                dtCommande.Columns[2].Visible = false;
                dtCommande.Columns[3].HeaderText = "NOM_CLIENT";
                dtCommande.Columns[4].HeaderText = "NOM_TABLE";
                dtCommande.Columns[5].HeaderText = "POURCENTAGETVA";
                dtCommande.Columns[6].HeaderText = "dateCommande";
                dtCommande.Columns[7].Visible = false;
                dtCommande.Columns[8].HeaderText = "MATRICULE_SERVEUR";
                dtCommande.Columns[9].Visible = false;
            }
            else
            {
                dtCommande.DataSource = null;
                dtCommande.Rows.Clear();
                dtCommande.Columns.Clear();
                dtCommande.AllowUserToAddRows = false;
                dtCommande.RowCount = 1;
                dtCommande.ColumnCount = 1;
                dtCommande.Rows[0].Cells[0].Value = "Il n'y a pas de commande sur place pour le restaurant.";
                dtCommande.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }











            //Début datagrid view pour lister les commandes sur place




            //Fin datagrid view pour lister les commandes sur place


            //Début datagrid view pour lister les commandes à emporter


        }

        public void rechardataAEmporter(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);
            List<ListeCommandeEmportV2> listCommandEmport = Modele_gueguen.listeCommandeAEmporter();

            if (listCommandEmport.Any())
            {
                BSCommandeAEmporter.DataSource = Modele_gueguen.listeCommandeAEmporter().Select
              (x => new
              {
                  x.NUMERO_COMMANDE,
                  x.ID_CLIENT,
                  x.POURCENTAGETVA,
                  x.dateCommande,
                  x.Archiv,
                  x.NOM_CLIENT,
                  x.ID_RESTAURANT,
                  x.IDPAIMENT

              }).Where(x => x.ID_RESTAURANT == idrestau);

                dtCommandeEmport.DataSource = BSCommandeAEmporter;
                dtCommandeEmport.Columns[0].HeaderText = "NUMERO_COMMANDE";
                dtCommandeEmport.Columns[1].Visible = false;
                dtCommandeEmport.Columns[2].HeaderText = "POURCENTAGETVA ";
                dtCommandeEmport.Columns[3].HeaderText = "dateCommande ";
                dtCommandeEmport.Columns[4].Visible = false;
                dtCommandeEmport.Columns[5].HeaderText = "NOM_CLIENT";
                dtCommandeEmport.Columns[6].Visible = false;
                dtCommandeEmport.Columns[6].Visible = false;
            }
            else
            {
                dtCommandeEmport.DataSource = null;
                dtCommandeEmport.Rows.Clear();
                dtCommandeEmport.Columns.Clear();
                dtCommandeEmport.AllowUserToAddRows = false;
                dtCommandeEmport.RowCount = 1;
                dtCommandeEmport.ColumnCount = 1;
                dtCommandeEmport.Rows[0].Cells[0].Value = "Il n'y a pas de commande à emporter pour le restaurant.";
                dtCommandeEmport.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtCommandeEmport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        public void rechardataSurPlace(DataGridView dgv)
        {
            List<ListeCommandeSurPlaceDate> listecommandeSP = Modele_gueguen.listeCommandeSurPlace();

            if (listecommandeSP.Any())
            {
                BSCommandeSurPlace.DataSource = listecommandeSP.Select(x => new
                {
                    x.NUMERO_COMMANDE,
                    x.IDPAIMENT,
                    x.ID_CLIENT,
                    x.NOM_CLIENT,
                    x.NOM_TABLE,
                    x.POURCENTAGETVA,
                    x.dateCommande,
                    x.ID_TABLE,
                    x.MATRICULE_SERVEUR,
                    x.Archivsurplace
                });
                dtCommande.DataSource = BSCommandeSurPlace;
                dtCommande.Columns[0].HeaderText = "NUMERO_COMMANDE";
                dtCommande.Columns[1].Visible = false;
                dtCommande.Columns[2].Visible = false;
                dtCommande.Columns[3].HeaderText = "NOM_CLIENT";
                dtCommande.Columns[4].HeaderText = "NOM_TABLE";
                dtCommande.Columns[5].HeaderText = "POURCENTAGETVA";
                dtCommande.Columns[6].HeaderText = "dateCommande";
                dtCommande.Columns[7].Visible = false;
                dtCommande.Columns[8].HeaderText = "MATRICULE_SERVEUR";
                dtCommande.Columns[9].Visible = false;
            }
            else
            {
                dtCommande.DataSource = null;
                dtCommande.Rows.Clear();
                dtCommande.Columns.Clear();
                dtCommande.AllowUserToAddRows = false;
                dtCommande.RowCount = 1;
                dtCommande.ColumnCount = 1;
                dtCommande.Rows[0].Cells[0].Value = "Il n'y a pas de commande sur place pour le restaurant.";
                dtCommande.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btn_surPlace_Click(object sender, EventArgs e)
        {
           
            panAEmporter.Visible = false;

            
            labelCommande.Visible = true;
            labelCommande.Text = "Sur Place";


            List<ListeCommandeSurPlaceDate> listecommandeSP = Modele_gueguen.listeCommandeSurPlace();

            if (listecommandeSP.Any())
            {
                BSCommandeSurPlace.DataSource = listecommandeSP.Select(x => new
                {
                    x.NUMERO_COMMANDE,
                    x.IDPAIMENT,
                    x.ID_CLIENT,
                    x.NOM_CLIENT,
                    x.NOM_TABLE,
                    x.POURCENTAGETVA,
                    x.dateCommande,
                    x.ID_TABLE,
                    x.MATRICULE_SERVEUR,
                    x.Archivsurplace
                });
                dtCommande.DataSource = BSCommandeSurPlace;
                dtCommande.Columns[0].HeaderText = "NUMERO_COMMANDE";
                dtCommande.Columns[1].Visible = false;
                dtCommande.Columns[2].Visible = false;
                dtCommande.Columns[3].HeaderText = "NOM_CLIENT";
                dtCommande.Columns[4].HeaderText = "NOM_TABLE";
                dtCommande.Columns[5].HeaderText = "POURCENTAGETVA";
                dtCommande.Columns[6].HeaderText = "dateCommande";
                dtCommande.Columns[7].Visible = false;
                dtCommande.Columns[8].HeaderText = "MATRICULE_SERVEUR";
                dtCommande.Columns[9].Visible = false;
            }
            else
            {
                dtCommande.DataSource = null;
                dtCommande.Rows.Clear();
                dtCommande.Columns.Clear();
                dtCommande.AllowUserToAddRows = false;
                dtCommande.RowCount = 1;
                dtCommande.ColumnCount = 1;
                dtCommande.Rows[0].Cells[0].Value = "Il n'y a pas de commande sur place pour le restaurant.";
                dtCommande.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }




        }

        private void btn_AEmporter_Click(object sender, EventArgs e)
        {
            BSCommandeSurPlace.DataSource = null;
            panAEmporter.Visible = true;
            
            labelCommande.Visible = true;
            labelCommande.Text = "A Emporter";


            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt16(StringIdRestau);

            List<ListeCommandeEmportV2> listCommandEmport = Modele_gueguen.listeCommandeAEmporter();

            if (listCommandEmport.Any())
            {
                BSCommandeAEmporter.DataSource = Modele_gueguen.listeCommandeAEmporter().Select
              (x => new
              {
                  x.NUMERO_COMMANDE,
                  x.ID_CLIENT,
                  x.POURCENTAGETVA,
                  x.dateCommande,
                  x.Archiv,
                  x.NOM_CLIENT,
                  x.ID_RESTAURANT,
                  x.IDPAIMENT

              }).Where(x => x.ID_RESTAURANT == idrestau);

                dtCommandeEmport.DataSource = BSCommandeAEmporter;
                dtCommandeEmport.Columns[0].HeaderText = "NUMERO_COMMANDE";
                dtCommandeEmport.Columns[1].Visible = false;
                dtCommandeEmport.Columns[2].HeaderText = "POURCENTAGETVA ";
                dtCommandeEmport.Columns[3].HeaderText = "dateCommande ";
                dtCommandeEmport.Columns[4].Visible = false;
                dtCommandeEmport.Columns[5].HeaderText = "NOM_CLIENT";
                dtCommandeEmport.Columns[6].Visible = false;
                dtCommandeEmport.Columns[6].Visible = false;
            }
            else
            {
                dtCommandeEmport.DataSource = null;
                dtCommandeEmport.Rows.Clear();
                dtCommandeEmport.Columns.Clear();
                dtCommandeEmport.AllowUserToAddRows = false;
                dtCommandeEmport.RowCount = 1;
                dtCommandeEmport.ColumnCount = 1;
                dtCommandeEmport.Rows[0].Cells[0].Value = "Il n'y a pas de commande à emporter pour le restaurant.";
                dtCommandeEmport.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtCommandeEmport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
           


        }

        private void btn_ArchiveraEmport_Click(object sender, EventArgs e)
        {
            System.Type type = BSCommandeAEmporter.Current.GetType();
            int idMe = (int)type.GetProperty("NUMERO_COMMANDE").GetValue(BSCommandeAEmporter.Current, null);

            if (Modele_gueguen.ArchivageAEmporter(idMe))
            {
                MessageBox.Show("Archivage Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rechardataAEmporter(dtCommande);
            }
            else
            {
                MessageBox.Show("Archivage non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Archiversurplace_Click(object sender, EventArgs e)
        {
            System.Type type = BSCommandeSurPlace.Current.GetType();
            int idMe = (int)type.GetProperty("NUMERO_COMMANDE").GetValue(BSCommandeSurPlace.Current, null);

            if (Modele_gueguen.ArchivageSurPlace(idMe))
            {
                MessageBox.Show("Archivage Effectué !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rechardataSurPlace(dtCommande);
            }
            else
            {
                MessageBox.Show("Archivage non réalisé !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       

        private void btn_Commander_Click(object sender, EventArgs e)
        {
            FormAjoutCommandeSurPlace FACP = new FormAjoutCommandeSurPlace(EtatGestionCommande.Ajout);
            FACP.Show();
        }

        /*Commande à emporter*/
        private void btn_EditEmport_Click(object sender, EventArgs e)
        {
            System.Type type = BSCommandeAEmporter.Current.GetType();
            int IdNumCommandeEmporter = (int)type.GetProperty("NUMERO_COMMANDE").GetValue(BSCommandeAEmporter.Current, null);
            string NomCli = (string)type.GetProperty("NOM_CLIENT").GetValue(BSCommandeAEmporter.Current, null);
            string MoyePaiement = (string)type.GetProperty("NOMPAIMENT").GetValue(BSCommandeAEmporter.Current, null);

            FormAjoutCommandeEmpor FAC = new FormAjoutCommandeEmpor(EtatGestionCommande.Modif, NomCli, MoyePaiement, IdNumCommandeEmporter);
            FAC.Show();
          
        }

        /*Commande sur place*/

        private void btn_EditNote_Click(object sender, EventArgs e)
        {
            System.Type type = BSCommandeSurPlace.Current.GetType();
            int IdNumCommandeSurPlace = (int)type.GetProperty("NUMERO_COMMANDE").GetValue(BSCommandeSurPlace.Current, null);
            string NomCliSurPlace = (string)type.GetProperty("NOM_CLIENT").GetValue(BSCommandeSurPlace.Current, null);
            string MoyePaiementSurPlace = (string)type.GetProperty("NOMPAIMENT").GetValue(BSCommandeSurPlace.Current, null);
            string NomServeur = (string)type.GetProperty("NOM_SERVEUR").GetValue(BSCommandeSurPlace.Current, null);
            string NomTable = (string)type.GetProperty("NOM_TABLE").GetValue(BSCommandeSurPlace.Current, null);

            FormAjoutCommandeSurPlace FASP = new FormAjoutCommandeSurPlace(EtatGestionCommande.Modif, NomCliSurPlace, MoyePaiementSurPlace, NomServeur, NomTable, IdNumCommandeSurPlace);
            FASP.Show();
        }

        private void BtnRéglerNote_Click(object sender, EventArgs e)
        {
            System.Type type = BSCommandeAEmporter.Current.GetType();
            int IdNumCommandeEmport = (int)type.GetProperty("NUMERO_COMMANDE").GetValue(BSCommandeAEmporter.Current, null);
            FormReglerNote FRN = new FormReglerNote(IdNumCommandeEmport);
            FRN.Show();
        }
    }
}
