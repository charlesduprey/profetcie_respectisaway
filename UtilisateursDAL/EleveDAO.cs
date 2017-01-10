using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql;
using UtilisateursBO; // Référence la couche BO

namespace UtilisateursDAL
{
    public class EleveDAO
    {
        private static EleveDAO unEleveDAO; // Objet DAL

        #region Accesseur en lecture, renvoi une instance
        public static EleveDAO GetunUtilisateurDAO()
        {
            if (unEleveDAO == null)
            {
                unEleveDAO = new EleveDAO();
            }
            return unEleveDAO;
        }
        #endregion

        #region GetLEleve retourne un élève
        public static Eleve GetLEleve(int id)
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            string nom = string.Empty;
            string prenom = string.Empty;
            string demiClasse = string.Empty;
            string sexe = string.Empty;
            string origine = string.Empty;
            string asso = string.Empty;
            string couleurCheveux = string.Empty;
            string longueur = string.Empty;
            string bouclesRaides = string.Empty;
            string couleurYeux = string.Empty;
            string lunettes = string.Empty;
            string taille = string.Empty;
            string passion = string.Empty;
            string surnom = string.Empty;
            string qualite = string.Empty;
            string defaut = string.Empty;
            string special1 = string.Empty;
            string special2 = string.Empty;
            Eleve unEleve;
            #endregion

            // Connexion à la BD
            MySqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            #region Création d'une commande SQL pour obtenir un élève à partir de son id
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM ELEVES WHERE ID = '" + id + "'";
            #endregion

            // Récupération du résultat dans une variable
            MySqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
            do
            {
                if (monReader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom"].ToString();
                }

                if (monReader["prenom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["prenom"].ToString();
                }


                if (monReader["demiClasse"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["demiClasse"].ToString();
                }


                if (monReader["sexe"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["sexe"].ToString();
                }


                if (monReader["origine"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["origine"].ToString();
                }


                if (monReader["asso"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["asso"].ToString();
                }


                if (monReader["couleurCheveux"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["couleurCheveux"].ToString();
                }


                if (monReader["longueur"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["longueur"].ToString();
                }


                if (monReader["bouclesRaides"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["bouclesRaides"].ToString();
                }


                if (monReader["couleursYeux"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["couleursYeux"].ToString();
                }


                if (monReader["lunettes"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["lunettes"].ToString();
                }


                if (monReader["taille"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["taille"].ToString();
                }


                if (monReader["passion"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["passion"].ToString();
                }

                if (monReader["surnom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["surnom"].ToString();
                }

                if (monReader["qualite"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["qualite"].ToString();
                }

                if (monReader["defaut"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["defaut"].ToString();
                }

                if (monReader["special1"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["special1"].ToString();
                }

                if (monReader["special2"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["special2"].ToString();
                }

                unEleve = new Eleve(
                    nom,
                    prenom,
                    demiClasse,
                    sexe,
                    origine,
                    asso,
                    couleurCheveux,
                    longueur,
                    bouclesRaides,
                    couleurYeux,
                    lunettes,
                    taille,
                    passion,
                    surnom,
                    qualite,
                    defaut,
                    special1,
                    special2);

                  
            } while (int.Parse(monReader["id_eleves"].ToString()) == id);
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return unEleve;
        }
        #endregion

        #region GetEleves retourne une List d'objets Eleves contenus dans la table ELEVES
        public static List<Eleve> GetEleves()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            string nom = string.Empty;
            string prenom = string.Empty;
            string demiClasse = string.Empty;
            string sexe = string.Empty;
            string origine = string.Empty; 
            string asso = string.Empty;
            string couleurCheveux = string.Empty;
            string longueur = string.Empty;
            string bouclesRaides = string.Empty;
            string couleurYeux = string.Empty;
            string lunettes = string.Empty;
            string taille = string.Empty;
            string passion = string.Empty;
            string surnom = string.Empty;
            string qualite = string.Empty;
            string defaut = string.Empty;
            string special1 = string.Empty;
            string special2 = string.Empty;

            Eleve unEleve;
            #endregion

            // Connexion à la BD
            MySqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Eleve> lesEleves = new List<Eleve>();

            #region Création d'une commande SQL pour selectionner les élèves
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM table 1";
            #endregion

            // Récupération du résultat dans une variable
            MySqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
            while (monReader.Read())
            {

                if (monReader["nom"] == DBNull.Value)
                {
                    nom = default(string);
                }
                else
                {
                    nom = monReader["nom"].ToString();
                }

                if (monReader["prenom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["prenom"].ToString();
                }


                if (monReader["demiClasse"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["demiClasse"].ToString();
                }


                if (monReader["sexe"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["sexe"].ToString();
                }


                if (monReader["origine"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["origine"].ToString();
                }


                if (monReader["asso"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["asso"].ToString();
                }


                if (monReader["couleurCheveux"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["couleurCheveux"].ToString();
                }


                if (monReader["longueur"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["longueur"].ToString();
                }


                if (monReader["bouclesRaides"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["bouclesRaides"].ToString();
                }


                if (monReader["couleursYeux"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["couleursYeux"].ToString();
                }


                if (monReader["lunettes"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["lunettes"].ToString();
                }


                if (monReader["taille"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["taille"].ToString();
                }


                if (monReader["passion"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["passion"].ToString();
                }

                if (monReader["surnom"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["surnom"].ToString();
                }

                if (monReader["qualite"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["qualite"].ToString();
                }

                if (monReader["defaut"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["defaut"].ToString();
                }

                if (monReader["special1"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["special1"].ToString();
                }

                if (monReader["special2"] == DBNull.Value)
                {
                    prenom = default(string);
                }
                else
                {
                    prenom = monReader["special2"].ToString();
                }

                unEleve = new Eleve(
                    nom,
                    prenom,
                    demiClasse,
                    sexe,
                    origine,
                    asso,
                    couleurCheveux,
                    longueur,
                    bouclesRaides,
                    couleurYeux,
                    lunettes,
                    taille,
                    passion,
                    surnom,
                    qualite,
                    defaut,
                    special1,
                    special2);


                lesEleves.Add(unEleve);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesEleves;
        }
        #endregion       
    }
}
