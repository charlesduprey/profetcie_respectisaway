using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using ProfetcieBO; // Référence la couche BO
using ProfetcieDAL;

namespace ProfetcieDAL
{
    public class QuestionDAO
    {
        private static QuestionDAO uneQuestionDAO; // Objet DAL

        #region Accesseur en lecture, renvoi une instance
        public static QuestionDAO GetuneQuestionDAO()
        {
            if (uneQuestionDAO == null)
            {
                uneQuestionDAO = new QuestionDAO();
            }
            return uneQuestionDAO;
        }
        #endregion

        #region GetQuestions retourne une List d'objets Eleves contenus dans la table QUESTION
        public static List<Question> GetLesQuestionDAO()
        {
            #region Liste des attributs nécessaires pour récupérer et retourner le résultat attendu
            string questiont = string.Empty;
            string rang = string.Empty;
            Question uneQuestion;
            #endregion

            // Connexion à la BD
            MySqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Eleve
            List<Question> lesQuestions = new List<Question>();

            #region Création d'une commande SQL pour selectionner les élèves
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM table 2";
            #endregion

            // Récupération du résultat dans une variable
            MySqlDataReader monReader = cmd.ExecuteReader();

            #region Remplissage de la liste à partir du reader
            while (monReader.Read())
            {

                if (monReader["question"] == DBNull.Value)
                {
                    questiont = default(string);
                }
                else
                {
                    questiont = monReader["question"].ToString();
                }

                if (monReader["rang"] == DBNull.Value)
                {
                    rang = default(string);
                }
                else
                {
                    rang = monReader["rang"].ToString();
                }


                uneQuestion = new Question(
                    questiont,
                    rang
                    );


                lesQuestions.Add(uneQuestion);
            }
            #endregion

            // Fermeture de la connexion
            maConnexion.Close();

            // Résultat retourné
            return lesQuestions;
        }
        #endregion   
    }
}
