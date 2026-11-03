using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace Projet_Gueguen_Csharp
{
    
    class Modele_gueguen
    {
        private static GUEGUENAppEntities maGueguen; // déclaration de la variable permettant l'instantiation de la connexion
        public int IdDirigeant = 0;
        public static int IdServeurSR = 0;
        public static int idRestaurantSR;
        public static int idDirigeant;
        public static String GetNom;
        public static String GetPrenom;
        public static String GetNomServeur;
        public static String GetPrenomServeur;

        
        

        public static void init() // initialisation de la variable de connexion à l'ORM
        {
            maGueguen = new GUEGUENAppEntities();
        }
        #region Facture
        public static List<v_Facture> listeFacture()
        {
            return maGueguen.v_Facture.ToList();
        }

        #endregion

        #region connexionAdministrateur

        /*Début Recuperer commande a emporter*/
        public static RESTAURANT RecupererIdRestaurant(String nomRestau)
        {

            RESTAURANT UnRestau = new RESTAURANT();
            try
            {
                UnRestau = maGueguen.RESTAURANT.First(x => x.NOM_RESTAURANT == nomRestau);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return UnRestau;
        }

       
        public static int returnIdRESTAU(string nomRestau)
        {
           
            RESTAURANT UnRestau;
            int IdRestaurantcombo = 0;

            try
            {
                UnRestau = RecupererIdRestaurant(nomRestau);
                IdRestaurantcombo = UnRestau.ID_RESTAURANT;
                

                maGueguen.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return IdRestaurantcombo;
        }
       
        /// <summary>
        /// Liste qui retourne la liste des restaurants 
        /// </summary>
        /// <returns></returns>
        public static List<RESTAURANT> listeRestau(int idMatr)
        {
            List<RESTAURANT> lesR;
            List<RESTAURANT> lesR_Dirigeant = new List<RESTAURANT>();
            lesR = maGueguen.RESTAURANT.ToList();
            foreach(RESTAURANT r in lesR)
            {
                ICollection<DIRIGER> lesD;
                lesD = r.DIRIGER;
                foreach (DIRIGER d in lesD)
                {
                    if (d.MATRICULE_DIRIGEANT==idMatr)
                    {
                        lesR_Dirigeant.Add(r);
                    }
                }
 
            }

            return lesR_Dirigeant;
       
        }

        public static List<TABLECLIENT> listeNomTable(int idRestau)
        {
            List<TABLECLIENT> lesR;
            List<TABLECLIENT> les_tablet = new List<TABLECLIENT>();
            lesR = maGueguen.TABLECLIENT.ToList();
            foreach (TABLECLIENT r in lesR)
            {
                if(r.ID_RESTAURANT == idRestau)
                {
                    les_tablet.Add(r);
                }
                

            }

            return les_tablet;

        }

        public static List<SERVEUR> ListeNomServeurParRestau(int idRestau)
        {
            List<SERVEUR> lesR;
            List<SERVEUR> les_tablet = new List<SERVEUR>();
            lesR = maGueguen.SERVEUR.ToList();
            foreach (SERVEUR r in lesR)
            {
                if (r.ID_RESTAURANT == idRestau)
                {
                    les_tablet.Add(r);
                }


            }

            return les_tablet;

        }

        /// <summary>
        /// Verification connexion dirigeant
        /// </summary>
        /// <param name="login"></param>
        /// <param name="mdp"></param>
        /// <returns></returns>
        public static bool ConnexionDirigeant(string login, string mdp)
        {
            bool ConnAdmin = false;
            DIRIGEANT dr = new DIRIGEANT();
            idDirigeant = 0;
            try
            {
                ConnAdmin = true;
                dr = maGueguen.DIRIGEANT.First(x => x.NOM_DIRIGEANT == login); // objet contenant l'enregistrement administrateur

                string passwordHash = dr.MOTDEPASSE_DIRIGEANT;
                bool verified = BCrypt.Net.BCrypt.Verify(mdp, passwordHash);

                if (verified)
                {
                    idDirigeant += dr.MATRICULE_DIRIGEANT;
                   
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                ConnAdmin = false;
                MessageBox.Show(e.Message.ToString());
            }
            return ConnAdmin;
        }

        /// <summary>
        /// fonction qui retourne l'IdDirigeant
        /// </summary>
        /// <returns></returns>
        public static int GetIdDirigeant()
        { 
            return idDirigeant;
        }

        /// <summary>
        /// Connexion serveur
        /// </summary>
        /// <param name="loginServeur"></param>
        /// <param name="PassWServeur"></param>
        /// <returns></returns>
        public static bool ConnexionServeur(string loginServeur, string PassWServeur)
        {
            bool ConnServeur = false;
            SERVEUR SR = new SERVEUR();
           
            try
            {
                ConnServeur = true;
                SR = maGueguen.SERVEUR.First(x => x.MAIL_SERVEUR == loginServeur); // objet contenant l'enregistrement administrateur

                string passServeur = SR.password;

                bool grantedServeur = BCrypt.Net.BCrypt.Verify(PassWServeur, passServeur);

                if (grantedServeur)
                {
                    idRestaurantSR += (int)SR.ID_RESTAURANT;
                    IdServeurSR += SR.MATRICULE_SERVEUR;

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                ConnServeur = false;
                MessageBox.Show(e.Message.ToString());
            }
            return ConnServeur;
        }

        public static int GetIdServeur()
        {
            return IdServeurSR;
        }

        public static int GetIdRestaurantSR()
        {
            return idRestaurantSR;
        }
        #endregion

        #region FormCommande

        public static List<ListeCommandeSurPlaceDate> listeCommandeSurPlace()
        {
            return maGueguen.ListeCommandeSurPlaceDate.ToList();
        }

        public static List<ListeCommandeEmportV2> listeCommandeAEmporter()
        {
            return maGueguen.ListeCommandeEmportV2.ToList();
        }

       
        
        /*Début Recuperer commande a emporter*/
        public static COMMANDEAEMPORTER RecupererCommandeEmport(int idC)
        {

            COMMANDEAEMPORTER uneCommandeEmport = new COMMANDEAEMPORTER();
            try
            {
                uneCommandeEmport = maGueguen.COMMANDEAEMPORTER.First(x => x.NUMERO_COMMANDE == idC);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return uneCommandeEmport;
        }
        /*Fin Recuperer commande a emporter*/
        /*Début Recuperer commande sur place*/
        public static COMMANDESURPLACE RecupererCommandSurPlace(int isCS)
        {
            COMMANDESURPLACE uneCommandeSurPlace = new COMMANDESURPLACE();
            try
            {
                uneCommandeSurPlace = maGueguen.COMMANDESURPLACE.First(x => x.NUMERO_COMMANDE == isCS);

            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return uneCommandeSurPlace;
        }

        /*Fin Recuperer commande sur place*/

        public static bool ArchivageAEmporter(int idC)
        {
            bool ArchiveEmport = true;
            COMMANDEAEMPORTER uneCommandeEmport;

            try
            {
                uneCommandeEmport = RecupererCommandeEmport(idC);
                uneCommandeEmport.Archiv = true;

                maGueguen.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return ArchiveEmport;

        }

        public static bool ArchivageSurPlace(int icSP)
        {
            bool ArchivageSurPlace = true;
            COMMANDESURPLACE uneCommandeSurPlace;

            try
            {
                uneCommandeSurPlace = RecupererCommandSurPlace(icSP);
                uneCommandeSurPlace.Archivsurplace = true;

                maGueguen.SaveChanges();


            }catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return ArchivageSurPlace;
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'une commande  à pu avoir lieu
        /// Faux sinon
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="idMoyenPaiement"></param>
       
        /// <returns></returns>
        /// 
        public static bool AjoutCommande( int idClient, string idMoyenPaiement)
        {
            COMMANDE COM;
           
            bool vretour = true;
            try
            {

                // ajout dans la table commande
                COM = new COMMANDE();
                COM.ID_CLIENT = idClient;
                COM.IDPAIMENT = null;
                COM.dateCommande = DateTime.Now;

                maGueguen.COMMANDE.Add(COM);
                maGueguen.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
       /// <summary>
       /// Liste qui retourne la liste client pour ajout commande à emporter
       /// </summary>
       /// <returns></returns>
        public static List<CLIENT> listeClient()
        {
            return maGueguen.CLIENT.ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste des moyens de paiements à emporter
        /// </summary>
        /// <returns></returns>

        public static List<TYPEPAIMENT> listeMoyenPaiement()
        {
            return maGueguen.TYPEPAIMENT.ToList();
        }

        /// <summary>
        /// Retourne l'identifiant du dernier Membre saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetournerDerniereCommande()
        {
            return maGueguen.COMMANDE.Max(x => x.NUMERO_COMMANDE);
        }
        /// <summary>
        /// retourne le dernier produit inséré
        /// </summary>
        /// <returns></returns>
        public static int lastInsertProd()
        {
            return maGueguen.PRODUIT.Max(x => x.ID_PRODUIT);
        }
        public static int idClientPrem()
        {
            return maGueguen.CLIENT.Min(x => x.ID_CLIENT);
        }

        /// <summary>
        /// Liste qui retourne la liste serveur pour ajout commande sur place
        /// </summary>
        /// <returns></returns>
        public static List<SERVEUR> ListeNomServeur()
        {
            return maGueguen.SERVEUR.ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste nom de table pour ajout commande sur place
        /// </summary>
        /// <returns></returns>
        public static List<TABLECLIENT> ListeNomTable()
        {
            return maGueguen.TABLECLIENT.ToList();
        }

        /// <summary>
        /// Retourne vrai si l'ajout d'une commande à emporter à pu avoir lieu
        /// Faux sinon
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="nomServeur"></param>
        /// <param name="nomTable"></param>


        /// <returns></returns>
        /// 
        public static bool ImportCommandeSurPlace(int idCommande, int nomServeur, int nomTable)
        {
            COMMANDESURPLACE CSP;
           
            int pourcentVA = 20;
            bool Archiv = false;

            bool vretour = true;
            try
            {

                // ajout dans la table commande
                CSP = new COMMANDESURPLACE();
                
                CSP.NUMERO_COMMANDE = idCommande;
                
                CSP.ID_TABLE = nomTable;
                CSP.MATRICULE_SERVEUR = nomServeur;
                CSP.POURCENTAGETVA = pourcentVA;
                CSP.Archivsurplace = Archiv;

                maGueguen.COMMANDESURPLACE.Add(CSP);
                maGueguen.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }



        public static COMMANDESURPLACE RecupererCommandeSurPlace(int idM)
        {
            COMMANDESURPLACE UneCommande = new COMMANDESURPLACE();

            try
            {
                UneCommande = maGueguen.COMMANDESURPLACE.First(x => x.NUMERO_COMMANDE == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return UneCommande;
        }

        public static COMMANDE RecupererCommande(int idM)
        {
            COMMANDE UneCommande = new COMMANDE();
            
            try
            {
                UneCommande = maGueguen.COMMANDE.First(x => x.NUMERO_COMMANDE == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return UneCommande;
        }


        public static bool ConfirmPaiment(int idNumCom, int idpaiment)
        {
            bool vretour = true;
            COMMANDE CO;

            try
            {

                CO = RecupererCommande(idNumCom);
                CO.IDPAIMENT = idpaiment;

              
                maGueguen.SaveChanges();

            }
            catch (Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }



        /// <summary>
        /// Modification commande sur place
        /// </summary>
        /// <param name="idCommandeSurPlace"></param>
        /// <param name="idclient"></param>
        /// <param name="idmoyPai"></param>
        /// <param name="idServeur"></param>
        /// <param name="idTable"></param>
        /// <returns></returns>
        public static bool ModifInformationCommandeSurPlace(int idCommandeSurPlace, int idclient, int idmoyPai, int idServeur, int idTable)
        {
            COMMANDESURPLACE UneCommandeSP;
            COMMANDE UneCommande;

            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                UneCommandeSP = RecupererCommandeSurPlace(idCommandeSurPlace);
                UneCommande = RecupererCommande(idCommandeSurPlace);

                // mise à jour des champs de l'hackathon

                UneCommandeSP.ID_TABLE = idTable;
                UneCommandeSP.MATRICULE_SERVEUR = idServeur;
                UneCommande.IDPAIMENT = idmoyPai;
                UneCommande.ID_CLIENT = idclient;


                maGueguen.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static List<Vue_RechercheClientDSRestaurant> ListeRechercheClientDsRestaurant()
        {
            return maGueguen.Vue_RechercheClientDSRestaurant.ToList();
        }

        public static bool SetAsseoir(int IdClient, int idTable)
        {
            bool vretour = true;
            ASSEOIR ASS;

            try
            {

                ASS = new ASSEOIR();
                ASS.ID_CLIENT = IdClient;
                ASS.ID_TABLE = idTable;
                ASS.DATECLIENTASSEOIR = DateTime.Now;


                maGueguen.ASSEOIR.Add(ASS);
                maGueguen.SaveChanges();

            }
            catch (Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }
        #endregion

        #region profilUtilisateur

        /*Début Recuperer commande sur place*/
        public static DIRIGEANT GetProfilStatus(int idUserDirigeant)
        {
            DIRIGEANT unDirigeant = new DIRIGEANT();
            try
            {
                unDirigeant = maGueguen.DIRIGEANT.First(x => x.MATRICULE_DIRIGEANT == idUserDirigeant);
                GetNom = unDirigeant.NOM_DIRIGEANT;
                GetPrenom = unDirigeant.PRENOM_DIRIGEANT;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return unDirigeant;
        }
        /// <summary>
        /// retourne le nom du dirigeant avec une variable déclaré en public
        /// </summary>
        /// <returns></returns>
        public static String GetNomDirigeant()
        {
            return GetNom;
        }
        /// <summary>
        /// retourne le prénom du dirigeant avec une variable déclaré en public
        /// </summary>
        /// <returns></returns>
        public static String GetPrenomDirigeant()
        {
            return GetPrenom;
        }

        public static SERVEUR GetProfilStatusServeur(int idUserServeur)
        {
            SERVEUR unServeur = new SERVEUR();
            try
            {
                unServeur = maGueguen.SERVEUR.First(x => x.MATRICULE_SERVEUR == idUserServeur);
                GetNomServeur = unServeur.NOM_SERVEUR;
                GetPrenomServeur = unServeur.PRENOM_SERVEUR;
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return unServeur;
        }

        public static String GetNomServeurST()
        {
            return GetNomServeur;
        }

        public static String GetPrenomServeurST()
        {
            return GetPrenomServeur;
        }
        #endregion

        #region FormGestionEmployéDir



        /// <summary>
        /// retourne la liste des serveurs 
        /// </summary>
        /// <returns></returns>
        public static List<SERVEUR> GetListeServeur()
        {
            return maGueguen.SERVEUR.ToList();
        }
        /// <summary>
        /// booléan qui return true si suppression TRUE
        /// </summary>
        /// <param name="idServeur"></param>
        /// <returns></returns>
        public static bool SupprServeur(int idServeur)
        {
            SERVEUR unServeur;
            bool vretour = true;
            try
            {
                unServeur = RecupererUnServeur(idServeur);
                maGueguen.SERVEUR.Remove(unServeur);
                maGueguen.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " " +
               ex.InnerException.InnerException.Message);
                vretour = false;
            }
            return vretour;
        }

        /// <summary>
        /// Recupére le tuple de l'id en paramètre
        /// </summary>
        /// <param name="IdMatriculeServeur"></param>
        /// <returns></returns>

        public static SERVEUR RecupererUnServeur(int IdMatriculeServeur)
        {

            SERVEUR UnServeur = new SERVEUR();
            try
            {
                UnServeur = maGueguen.SERVEUR.First(x => x.MATRICULE_SERVEUR == IdMatriculeServeur);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return UnServeur;
        }

        /// <summary>
        /// Ajout SERVEUR ADMIN
        /// </summary>
        /// <param name="NomServeur"></param>
        /// <param name="PrenomServeur"></param>
        /// <param name="EmailServeur"></param>
        /// <param name="TelServeur"></param>
        /// <param name="MoTdpsERVEUR"></param>
        /// <returns></returns>
        public static bool AjoutServeur(string NomServeur, string PrenomServeur, string EmailServeur, string MoTdpsERVEUR , string TelServeur, DateTime dateNaiss, int idRestau, DateTime dateArrive)
        {
            SERVEUR unServeur;
            /*int unMailMembre;*/
            bool mailtrue = false;


            /*unMailMembre = maConnexion.MEMBRE.Max(x => x.idmembre);*/


            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unServeur = new SERVEUR();

                unServeur.NOM_SERVEUR = NomServeur;
                unServeur.PRENOM_SERVEUR = PrenomServeur;
                unServeur.DATEDEPART_SERVEUR = null;
                

                List<SERVEUR> l = GetListeServeur();
                foreach (SERVEUR m in l)
                {
                    if (m.MAIL_SERVEUR == EmailServeur)
                    {

                        mailtrue = true;
                        vretour = false;
                    }


                }
                if (!mailtrue)
                {
                    unServeur.created_at = DateTime.Now;
                    unServeur.updated_at = null;
                    unServeur.remember_token = null;
                    unServeur.DATEARRIVEE_SERVEUR = dateArrive;
                    unServeur.ID_RESTAURANT = idRestau;
                    unServeur.DATENAISS_SERVEUR = dateNaiss;
                    unServeur.email_verified_at = DateTime.Now;
                    unServeur.MAIL_SERVEUR = EmailServeur;
                    unServeur.TEL_SERVEUR = TelServeur;
                    unServeur.password = BCrypt.Net.BCrypt.HashPassword(MoTdpsERVEUR);
                    


                    maGueguen.SERVEUR.Add(unServeur);
                    maGueguen.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        /// <summary>
        /// Boolean modification Serveur
        /// </summary>
        /// <param name="idH"></param>
        /// <param name="NomServeurComp"></param>
        /// <param name="prenomServeurComp"></param>
        /// <param name="MailServeurComp"></param>
        /// <param name="telServeurComp"></param>
        /// <param name="dtArriveServeurComp"></param>
        /// <param name="dtNaissanceServeur"></param>
        /// <returns></returns>
        public static bool ModifInformationServeur(int IdServeur, string NomServeurComp, string prenomServeurComp, string MailServeurComp, string telServeurComp,  DateTime dtArriveServeurComp, DateTime dtNaissanceServeur)
        {
            SERVEUR unServeur;
            
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unServeur = RecupererUnServeur(IdServeur);

                // mise à jour des champs de l'hackathon
                unServeur.NOM_SERVEUR = NomServeurComp;
                unServeur.PRENOM_SERVEUR = prenomServeurComp;
                unServeur.MAIL_SERVEUR = MailServeurComp;
                unServeur.TEL_SERVEUR = telServeurComp;
                unServeur.DATEARRIVEE_SERVEUR = dtArriveServeurComp;
                unServeur.DATENAISS_SERVEUR = dtNaissanceServeur;

           
                

                maGueguen.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool ModifInformationServeur(int IdServeur, string NomServeurComp, string prenomServeurComp, string MailServeurComp, string telServeurComp, DateTime dtArriveServeurComp, DateTime dtNaissanceServeur, string mdp)
        {
            SERVEUR unServeur;

            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unServeur = RecupererUnServeur(IdServeur);

                // mise à jour des champs de l'hackathon
                unServeur.NOM_SERVEUR = NomServeurComp;
                unServeur.PRENOM_SERVEUR = prenomServeurComp;
                unServeur.MAIL_SERVEUR = MailServeurComp;
                unServeur.TEL_SERVEUR = telServeurComp;
                unServeur.DATEARRIVEE_SERVEUR = dtArriveServeurComp;
                unServeur.DATENAISS_SERVEUR = dtNaissanceServeur;
                unServeur.password = BCrypt.Net.BCrypt.HashPassword(mdp);




                maGueguen.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion

        #region GestionStock

        /// <summary>
        /// Liste qui retourne la liste client pour ajout commande à emporter
        /// </summary>
        /// <returns></returns>
       public static List<CATEGORIE> ListCatégorie()
        {
            return maGueguen.CATEGORIE.ToList();
        }
        public static List<v_stock3> GetListStock()
        {
            return maGueguen.v_stock3.ToList();
        }

        public static bool AjoutSeuilActuel( int idProd, int qteActuel)
        {
            bool vretour = true;
            v_stock3 vStock = new v_stock3();
            
            try
            {
                vStock = maGueguen.v_stock3.First(x => x.ID_PRODUIT == idProd);
                vStock.SEUILACTUEL += (long)qteActuel;

                maGueguen.SaveChanges();
            }
            catch (Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }
        /// <summary>
        /// Historisation du stock
        /// </summary>
        /// <param name="idProd"></param>
        /// <param name="idRestaurant"></param>
        /// <param name="qteSeuil"></param>
        /// <returns></returns>
        public static bool AjoutHistoStock(int idProd, int idRestaurant, int qteSeuil)
        {
            bool vretour = true;
            HISTORIQUEREAPRO Has;

            try
            {

                Has = new HISTORIQUEREAPRO();
                Has.ID_PRODUIT = idProd;
                Has.datereapro = DateTime.Now;
                Has.ID_RESTAURANT = idRestaurant;
                Has.quantite = qteSeuil;


                maGueguen.HISTORIQUEREAPRO.Add(Has);
                maGueguen.SaveChanges();

            }catch(Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }
        /// <summary>
        /// Archivage Produit dans gestion stock
        /// </summary>
        /// <param name="idC"></param>
        /// <returns></returns>
        public static bool ArchivageProdStock(int idC)
        {
            bool ArchiveEmport = true;
            CUISINER UneCuisine;

            try
            {
                UneCuisine = RecupProd(idC);
                UneCuisine.Archiv = true;

                maGueguen.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return ArchiveEmport;

        }
        /// <summary>
        /// fonction qui va récupérer le produit désigné par la fonction ArchivageProdStock
        /// </summary>
        /// <param name="idC"></param>
        /// <returns></returns>
        public static CUISINER RecupProd(int idC)
        {

            CUISINER UneCuisine = new CUISINER();
            try
            {
                UneCuisine = maGueguen.CUISINER.First(x => x.ID_PRODUIT == idC);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return UneCuisine;
        }
        public static List<PRODUIT> GetListProduit()
        {
            return maGueguen.PRODUIT.ToList();
        }
        public static bool AjoutProd(int idCatego,string  nomProd,string descriProd)
        {
            bool vretour = true;
            bool nomProdexist = false;
            PRODUIT Prod;

            try
            {

                Prod = new PRODUIT();
                Prod.ID_CATEGORIE = idCatego;
                List<PRODUIT> l = GetListProduit();
                foreach (PRODUIT m in l)
                {
                    if (m.NOM_PRODUIT == nomProd)
                    {

                        nomProdexist = true;
                        vretour = false;
                    }
                }
                if (!nomProdexist)
                {
                    Prod.NOM_PRODUIT = nomProd;
                    Prod.DESCRIPTION_PRODUIT = descriProd;

                    maGueguen.PRODUIT.Add(Prod);
                    maGueguen.SaveChanges();
                }
                    


                

            }
            catch (Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }

        public static bool AjoutProdFin(int idProd, int idRestau,double PrixHT,long  seuilActuel, long seuilMin,long  seuilMax,string imgProd,bool Archi)
        {
            bool vretour = true;

            CUISINER cui;

            try
            {

                cui = new CUISINER();
                cui.ID_PRODUIT = idProd;
                cui.ID_RESTAURANT = idRestau;
                cui.PRIXHT_PRODUIT = PrixHT;
                cui.SEUILACTUEL = seuilActuel;
                cui.SEUILMAXIMAL = seuilMax;
                cui.SEUILMINIMAL = seuilMin;
                cui.IMAGE_PRODUIT = imgProd;
                cui.Archiv = Archi;

                maGueguen.CUISINER.Add(cui);
                maGueguen.SaveChanges();

            }
            catch (Exception e)
            {
                vretour = false;
                MessageBox.Show(e.Message.ToString());
            }
            return vretour;
        }
        public static PRODUIT RecuProdProduit(int idProdui)
        {

            PRODUIT unProd = new PRODUIT();
            try
            {
                unProd = maGueguen.PRODUIT.First(x => x.ID_PRODUIT == idProdui);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return unProd;
        }
        public static CUISINER RecupererProdCuisine(int idProdui)
        {

            CUISINER uneCuisine = new CUISINER();
            try
            {
                uneCuisine = maGueguen.CUISINER.First(x => x.ID_PRODUIT == idProdui);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            return uneCuisine;
        }
        public static bool modifProduitStock(int idProd,long seuilActuComp,long seuilMinComp,long seuilMaxComp,double PrixHTProdComp, string imgProdComp, string descriProdComp,string nomProdComp,int nomCategoComp)
        {
            PRODUIT unProd;
            CUISINER uneCuisine;

            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unProd = RecuProdProduit(idProd);
                unProd.NOM_PRODUIT = nomProdComp;
                unProd.ID_CATEGORIE = nomCategoComp;
                unProd.DESCRIPTION_PRODUIT = descriProdComp;

                uneCuisine = RecupererProdCuisine(idProd);
                uneCuisine.SEUILACTUEL = seuilActuComp;
                uneCuisine.SEUILMINIMAL = seuilMinComp;
                uneCuisine.SEUILMAXIMAL = seuilMaxComp;
                uneCuisine.PRIXHT_PRODUIT = PrixHTProdComp;
                uneCuisine.IMAGE_PRODUIT = imgProdComp;
                // mise à jour des champs de l'hackathon
               



                maGueguen.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }



        #endregion

        #region statistique

        /// <summary>
        /// Liste qui retourne la liste des commande par rapport à une date pour les statistique
        /// </summary>
        /// <returns></returns>
        public static List<COMMANDE> statListeDeCommandes(int periode, DateTime date)
        {
            if (periode == 0)
            {
                return maGueguen.COMMANDE.Where(x => x.dateCommande.Value.Day == date.Day).ToList();
            }

            if (periode == 1)
            {
                int semaine = CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                List<COMMANDE> list = maGueguen.COMMANDE.ToList();
                if (list.Any())
                {
                    return list.Where(x => x.dateCommande.HasValue && Decimal.Round( x.dateCommande.Value.DayOfYear / 7) == semaine && x.dateCommande.Value.Year == date.Year).ToList();
                }
                else
                {
                    return list;
                }
            }

            return maGueguen.COMMANDE.Where(x => x.dateCommande.Value.Month == date.Month).ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste des detail d'une commande par rapport à une date pour les statistique
        /// </summary>
        /// <returns></returns>
        public static List<DETAILS> statListeDetail(List<int> numCommande, string idRestau)
        {
            return maGueguen.DETAILS.Where(x => numCommande.Contains(x.NUMERO_COMMANDE) && x.ID_RESTAURANT.ToString() == idRestau ).ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste des detail d'une commande par rapport à une date pour les statistique
        /// </summary>
        /// <returns></returns>
        public static List<PRODUIT> statListeProduit(List<int> numProduit)
        {
            return maGueguen.PRODUIT.Where(x => numProduit.Contains(x.ID_PRODUIT)).ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste des commande à emporter par rapport a un numero de commande et un id de restaurant pour les statistique
        /// </summary>
        /// <returns></returns>
        public static List<COMMANDEAEMPORTER> statListeCommandeEmporter(List<int> numCommande, string idRestau)
        {
            return maGueguen.COMMANDEAEMPORTER.Where(x => numCommande.Contains(x.NUMERO_COMMANDE) && x.ID_RESTAURANT.ToString() == idRestau).ToList();
        }

        /// <summary>
        /// Liste qui retourne la liste des commande à emporter par rapport a un numero de commande et un id de restaurant pour les statistique
        /// </summary>
        /// <returns></returns>
        public static List<COMMANDESURPLACE> statListeCommandeSurPlace(List<int> numCommande)
        {
            return maGueguen.COMMANDESURPLACE.Where(x => numCommande.Contains(x.NUMERO_COMMANDE)).ToList();
        }
    }
    #endregion

}
