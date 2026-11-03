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
   
    public partial class FormGestionFacture : Form
    {
    
        public bool ArchivEmport;
        public bool ArchivSurPlace;
        
        public FormGestionFacture()
        {
            InitializeComponent();
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
            panelConnexion.Controls.Add(formEnfant);
            panelConnexion.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }


        #region rechargedataemport

        public void RechargeDataEmport(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            List<v_Facture> ListStock = Modele_gueguen.listeFacture();

            if (ListStock.Any())
            {
                bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                {
                    x.NumCommande,
                    x.NumCommEmpor,
                    x.NOM_CLIENT,
                    x.IDCLIENTCOMM,
                    x.PRENOM_CLIENT,
                    x.IDPAIMENT,
                    x.Archiv,
                    x.dateCommande


                }).Where(x => x.NumCommande == x.NumCommEmpor);

                dtFacture.DataSource = bsFacture;
                dtFacture.Columns[0].Visible = false;
                dtFacture.Columns[1].HeaderText = "NumCommEmpor";
                dtFacture.Columns[2].HeaderText = "NOM_CLIENT";
                dtFacture.Columns[3].Visible = false;
                dtFacture.Columns[4].HeaderText = "PRENOM_CLIENT";
                dtFacture.Columns[5].HeaderText = "IDPAIMENT";
                dtFacture.Columns[6].HeaderText = "Archiv";
                dtFacture.Columns[7].HeaderText = "dateCommande";
            }
            else
            {
                dtFacture.DataSource = null;
                dtFacture.Rows.Clear();
                dtFacture.Columns.Clear();
                dtFacture.AllowUserToAddRows = false;
                dtFacture.RowCount = 1;
                dtFacture.ColumnCount = 1;
                dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture à Emporter pour le restaurant.";
                dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        #endregion


        #region datagridSurPlace

        public void RecharDataSurPlace(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            List<v_Facture> ListStock = Modele_gueguen.listeFacture();

            if (ListStock.Any())
            {
                labelEtat.Visible = true;
                labelEtat.Text = "Commande sur place";
                bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                {
                    x.NumCommande,
                    x.NumCommSP,
                    x.NOM_CLIENT,
                    x.IDCLIENTCOMM,
                    x.PRENOM_CLIENT,
                    x.IDPAIMENT,
                    x.Archivsurplace,
                    x.dateCommande


                }).Where(x => x.NumCommande == x.NumCommSP && x.IDPAIMENT == null || x.Archivsurplace == false);

                dtFacture.DataSource = bsFacture;
                dtFacture.Columns[0].Visible = false;
                dtFacture.Columns[1].HeaderText = "NumCommSP";
                dtFacture.Columns[2].HeaderText = "NOM_CLIENT";
                dtFacture.Columns[3].HeaderText = "PRENOM_CLIENT";
                dtFacture.Columns[4].HeaderText = "IDCLIENTCOMM";
                dtFacture.Columns[5].HeaderText = "IDPAIMENT";
                dtFacture.Columns[6].HeaderText = "Archivsurplace";
                dtFacture.Columns[7].HeaderText = "dateCommande";
            }
            else
            {
                dtFacture.DataSource = null;
                dtFacture.Rows.Clear();
                dtFacture.Columns.Clear();
                dtFacture.AllowUserToAddRows = false;
                dtFacture.RowCount = 1;
                dtFacture.ColumnCount = 1;
                dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture sur place pour le restaurant.";
                dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }
        #endregion

        #region rechargeDataCommande

        public void RechargeDataCommande(DataGridView dgv)
        {
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            List<v_Facture> ListStock = Modele_gueguen.listeFacture();

            if (ListStock.Any())
            {
                //Début datagrid view pour lister les commandes sur place
                bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                {
                    x.NumCommande,
                    x.NumCommEmpor,
                    x.NumCommSP,
                    x.NOM_CLIENT,
                    x.IDCLIENTCOMM,
                    x.PRENOM_CLIENT,
                    x.IDPAIMENT,
                    x.Archiv,
                    x.Archivsurplace,
                    x.dateCommande


                }).Where(x => x.IDPAIMENT == null && x.Archivsurplace == false || x.Archivsurplace == null &&  x.Archiv == false || x.Archiv == null);

                dtFacture.DataSource = bsFacture;
                dtFacture.Columns[0].HeaderText = "NumCommande";
                dtFacture.Columns[1].HeaderText = "NumCommEmporter";
                dtFacture.Columns[2].HeaderText = "NumCommSP";
                dtFacture.Columns[3].HeaderText = "NOM_CLIENT";
                dtFacture.Columns[4].Visible = false;
                dtFacture.Columns[5].HeaderText = "PRENOM_CLIENT";
                dtFacture.Columns[6].HeaderText = "IDPAIMENT";
                dtFacture.Columns[7].Visible = false;/* Archiv */
                dtFacture.Columns[8].Visible = false;/* Archivsurplace */
                dtFacture.Columns[9].HeaderText = "dateCommande";


            }
            else
            {
                dtFacture.DataSource = null;
                dtFacture.Rows.Clear();
                dtFacture.Columns.Clear();
                dtFacture.AllowUserToAddRows = false;
                dtFacture.RowCount = 1;
                dtFacture.ColumnCount = 1;
                dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture pour le restaurant.";
                dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
            #endregion

        private void gestionFacturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionFacture());
        }

        private void gestionStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionStock());
        }

        private void btn_Archiver_Click(object sender, EventArgs e)
        {

            if(cbCommande.Text == "Commande à emporter")
            {
                System.Type type = bsFacture.Current.GetType();
                bool ArchivEmport = (bool)type.GetProperty("Archiv").GetValue(bsFacture.Current, null);
                int NUMComEmport = (int)type.GetProperty("NumCommEmpor").GetValue(bsFacture.Current, null);
                if (Modele_gueguen.ArchivageAEmporter(NUMComEmport))
                {
                    MessageBox.Show("Archivage commande Emporter réussie !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FormGestionFacture_Load(sender, e);
                   /* RechargeDataCommande(dtFacture);*/
                }
                else
                {
                    MessageBox.Show("Echec commande Emporter !", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                System.Type type = bsFacture.Current.GetType();
                bool ArchivSurPlace = (bool)type.GetProperty("Archivsurplace").GetValue(bsFacture.Current, null);
                if (cbCommande.Text == "Commande sur place" || ArchivSurPlace == false)
                {
                    
                    int NumCommSP = (int)type.GetProperty("NumCommSP").GetValue(bsFacture.Current, null);
                    if (Modele_gueguen.ArchivageSurPlace(NumCommSP))
                    {
                        MessageBox.Show("Archivage commande Sur Place réussie !", "succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        FormGestionFacture_Load(sender, e);
                       /* RechargeDataCommande(dtFacture);*/
                      
                    }
                    else
                    {
                        MessageBox.Show("Echec commande Sur Place !", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
          
            
           
           


           
        }

        private void FormGestionFacture_Load(object sender, EventArgs e)
        {
           


            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            int idrestau = Convert.ToInt32(StringIdRestau);

            List<v_Facture> ListStock = Modele_gueguen.listeFacture();

            if (ListStock.Any())
            {
                //Début datagrid view pour lister les commandes sur place
                bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                {
                    x.NumCommande,
                    x.NumCommEmpor,
                    x.NumCommSP,
                    x.NOM_CLIENT,
                    x.IDCLIENTCOMM,
                    x.PRENOM_CLIENT,
                    x.IDPAIMENT,
                    x.Archiv,
                    x.Archivsurplace,
                    x.dateCommande


                }).Where(x => x.IDPAIMENT == null && x.Archivsurplace == false || x.Archivsurplace == null && x.Archiv == false || x.Archiv == null);

                dtFacture.DataSource = bsFacture;
                dtFacture.Columns[0].HeaderText = "NumCommande";
                dtFacture.Columns[1].HeaderText = "NumCommEmporter";
                dtFacture.Columns[2].HeaderText = "NumCommSP";
                dtFacture.Columns[3].HeaderText = "NOM_CLIENT";
                dtFacture.Columns[4].Visible = false;
                dtFacture.Columns[5].HeaderText = "PRENOM_CLIENT";
                dtFacture.Columns[6].HeaderText = "IDPAIMENT";
                dtFacture.Columns[7].Visible = false;/* Archiv */
                dtFacture.Columns[8].Visible = false;/* Archivsurplace */
                dtFacture.Columns[9].HeaderText = "dateCommande";
                

            }
            else
            {
                dtFacture.DataSource = null;
                dtFacture.Rows.Clear();
                dtFacture.Columns.Clear();
                dtFacture.AllowUserToAddRows = false;
                dtFacture.RowCount = 1;
                dtFacture.ColumnCount = 1;
                dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture pour le restaurant.";
                dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cbCommande_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
            if(cbCommande.Text == "Commande sur place")
            {
                List<v_Facture> ListStock = Modele_gueguen.listeFacture();

                if (ListStock.Any())
                {
                    labelEtat.Visible = true;
                    labelEtat.Text = "Commande sur place";
                    bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                    {
                        x.NumCommande,
                        x.NumCommSP,
                        x.NOM_CLIENT,
                        x.IDCLIENTCOMM,
                        x.PRENOM_CLIENT,
                        x.IDPAIMENT,
                        x.Archivsurplace,
                        x.dateCommande


                    }).Where(x => x.NumCommande == x.NumCommSP && x.IDPAIMENT == null || x.Archivsurplace == false);

                    dtFacture.DataSource = bsFacture;
                    dtFacture.Columns[0].Visible = false;
                    dtFacture.Columns[1].HeaderText = "NumCommSP";
                    dtFacture.Columns[2].HeaderText = "NOM_CLIENT";
                    dtFacture.Columns[3].HeaderText = "PRENOM_CLIENT";
                    dtFacture.Columns[4].HeaderText = "IDCLIENTCOMM";
                    dtFacture.Columns[5].HeaderText = "IDPAIMENT";
                    dtFacture.Columns[6].HeaderText = "Archivsurplace";
                    dtFacture.Columns[7].HeaderText = "dateCommande";
                }
                else
                {
                    dtFacture.DataSource = null;
                    dtFacture.Rows.Clear();
                    dtFacture.Columns.Clear();
                    dtFacture.AllowUserToAddRows = false;
                    dtFacture.RowCount = 1;
                    dtFacture.ColumnCount = 1;
                    dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture sur place pour le restaurant.";
                    dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }

            }
            else
            {
                labelEtat.Visible = true;
                labelEtat.Text = "Commande à Emporter";

                List<v_Facture> ListStock = Modele_gueguen.listeFacture();

                if (ListStock.Any())
                {
                    bsFacture.DataSource = Modele_gueguen.listeFacture().Select(x => new
                    {
                        x.NumCommande,
                        x.NumCommEmpor,
                        x.NOM_CLIENT,
                        x.IDCLIENTCOMM,
                        x.PRENOM_CLIENT,
                        x.IDPAIMENT,
                        x.Archiv,
                        x.dateCommande


                    }).Where(x => x.NumCommande == x.NumCommEmpor  );

                    dtFacture.DataSource = bsFacture;
                    dtFacture.Columns[0].Visible = false;
                    dtFacture.Columns[1].HeaderText = "NumCommEmpor";
                    dtFacture.Columns[2].HeaderText = "NOM_CLIENT";
                    dtFacture.Columns[3].Visible = false;
                    dtFacture.Columns[4].HeaderText = "PRENOM_CLIENT";
                    dtFacture.Columns[5].HeaderText = "IDPAIMENT";
                    dtFacture.Columns[6].HeaderText = "Archiv";
                    dtFacture.Columns[7].HeaderText = "dateCommande";
                }
                else
                {
                    dtFacture.DataSource = null;
                    dtFacture.Rows.Clear();
                    dtFacture.Columns.Clear();
                    dtFacture.AllowUserToAddRows = false;
                    dtFacture.RowCount = 1;
                    dtFacture.ColumnCount = 1;
                    dtFacture.Rows[0].Cells[0].Value = "Il n'y a pas de facture à Emporter pour le restaurant.";
                    dtFacture.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dtFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void btn_Payer_Click(object sender, EventArgs e)
        {
            if(cbCommande.Text == "Commande à Emporter")
            {
                System.Type type = bsFacture.Current.GetType();
                int IdNumCommandeEmport = (int)type.GetProperty("NumCommande").GetValue(bsFacture.Current, null);
         
                FormReglerFacture FRN = new FormReglerFacture(IdNumCommandeEmport);
                FRN.Show();
            }
            else
            {
                System.Type type = bsFacture.Current.GetType();
                int IdNumCommandeEmport = (int)type.GetProperty("NumCommande").GetValue(bsFacture.Current, null);
                
                FormReglerFacture FRN = new FormReglerFacture( IdNumCommandeEmport);
                FRN.Show();
            }
            
        }
    }
}
