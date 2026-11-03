using Guna.UI2.WinForms;
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
    public partial class FormProfil : Form
    {
        public FormProfil()
        {
            InitializeComponent();
            String idDirigeant = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtBoxIdConnexion.Text;
            
            

            String idServeur = (System.Windows.Forms.Application.OpenForms["Form_Connexion_Gueguen"] as Form_Connexion_Gueguen).txtidServeur.Text;
           


            if (idDirigeant != "" )
            {
               testTextbox.Text = idDirigeant;
                int IdUserDirigeant = Convert.ToInt32(idDirigeant);
                Modele_gueguen.GetProfilStatus(IdUserDirigeant);
                txtNom.Text = Modele_gueguen.GetNomDirigeant();
                txtPrenom.Text = Modele_gueguen.GetPrenomDirigeant();
            }
            else
            {
                if(idServeur != "")
                {
                    int IdServeurInt = Convert.ToInt32(idServeur);
                    Modele_gueguen.GetProfilStatusServeur(IdServeurInt);
                    txtNom.Text = Modele_gueguen.GetNomServeurST();
                    txtPrenom.Text = Modele_gueguen.GetPrenomServeurST();
                }
            }
        }

       
    }
}
