using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projet_Gueguen_Csharp
{
    public partial class Statistiques_Gueguen : Form
    {
        public Statistiques_Gueguen()
        {
            InitializeComponent();
        }

        private void Statistiques_Gueguen_Load(object sender, EventArgs e)
        {
            cbb_choixPeriode.Items.Add("Jours");
            cbb_choixPeriode.Items.Add("Semaine");
            cbb_choixPeriode.Items.Add("Mois");
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            cbb_choixPeriode.SelectedIndex = -1;
            dateTimePicker2_ValueChanged(sender, e);

        }

        #region stat produit le plus commmandé
        private void cbb_choixPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            List<COMMANDE> listeCommande = Modele_gueguen.statListeDeCommandes(cbb_choixPeriode.SelectedIndex, dateTimePicker1.Value);
            List<int> listeNumCommande = listeCommande.Select(x => x.NUMERO_COMMANDE).ToList();
            List<DETAILS> listeDetail = Modele_gueguen.statListeDetail(listeNumCommande, StringIdRestau);
            if (listeDetail.Any())
            {
                label3.Visible = false;
                chart1.Visible = true;
                bsBestProd.DataSource = listeDetail.GroupBy(DETAILS => DETAILS.ID_PRODUIT, DETAILS => DETAILS.QTE, (prod, nbCommande) => new { Key = prod, nb = nbCommande.Sum() });
                dgv_nbProduit.DataSource = bsBestProd;
                List<int> listeIdProd = listeDetail.Select(x => x.ID_PRODUIT).ToList();
                bsNomProd.DataSource = Modele_gueguen.statListeProduit(listeIdProd);
                dgv_nomProd.DataSource = bsNomProd;

                /// graphe numéro 1, premiere page du form TabControl
                for (int i = 0; i < dgv_nomProd.Rows.Count -1; i++)
                {
                    chart1.Series.Add(dgv_nomProd[2, i].Value.ToString());
                }

                int counter = 0;
                // and fill in all the values from the dgv to the chart:
                for (int i = 0; i < dgv_nbProduit.Rows.Count; i++)
                {
                    for (int j = 1; j < dgv_nbProduit.Columns.Count; j++)
                    {
                            chart1.Series[i].Points.AddXY(counter, dgv_nbProduit[j, i].Value);

                    }
                }
            }
            else
            {
                label3.Visible = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(cbb_choixPeriode.SelectedIndex != -1)
            cbb_choixPeriode_SelectedIndexChanged(sender, e);
        }
        #endregion

        #region stat nombre de commande
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            chart2.Series.Clear();
            chart2.Series.Add("s1");
            chart2.Series["s1"].ChartType = SeriesChartType.Pie;
            String StringIdRestau = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidrestau.Text;
            List<COMMANDE> listeCommande = Modele_gueguen.statListeDeCommandes(0, dateTimePicker1.Value);
            List<int> listeNumCommande = listeCommande.Select(x => x.NUMERO_COMMANDE).ToList();
            bsCommandeSurPlace.DataSource = Modele_gueguen.statListeCommandeSurPlace(listeNumCommande);
            bsCommandeAemporter.DataSource = Modele_gueguen.statListeCommandeEmporter(listeNumCommande, StringIdRestau);
            dgvCommandeAemporter.DataSource = bsCommandeAemporter;
            dvg_commandeSurPlace.DataSource = bsCommandeSurPlace;
            if (dgvCommandeAemporter.Rows.Count != 0 && dvg_commandeSurPlace.Rows.Count != 0)
            {
                int nbCommandeSurPlace = dvg_commandeSurPlace.Rows.Count;
                int nbCommandeAemporter = dgvCommandeAemporter.Rows.Count;
                chart2.Series["s1"].Points.AddXY("Commande à emporter", nbCommandeSurPlace);
                chart2.Series["s1"].Points.AddXY("Commande sur place", nbCommandeAemporter);

                foreach (DataPoint p in chart2.Series["s1"].Points)
                {
                    p.Label = "#PERCENT";
                    p.LegendText = "#VALX";
                }
                int nb = nbCommandeAemporter + nbCommandeSurPlace;
                label6.Text = nb.ToString();
            }
            else
            {
                label4.Visible = true;
            }
        }

        #endregion
    }
}
