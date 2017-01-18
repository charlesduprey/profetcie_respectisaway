using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ProfetcieBO; // Référence la couche BO
using ProfetcieDAL; // Référence la couche DAL

namespace profetcieBLL
{
    public class GestionQuestion
    {
        private static GestionQuestion uneGestionQuestion; // Objet BLL

        #region Accesseur en lecture
        public static GestionQuestion GetGestionQuestion()
        {
            if (uneGestionQuestion == null)
            {
                uneGestionQuestion = new GestionQuestion();
            }
            return uneGestionQuestion;
        }
        #endregion

        #region Méthode SetChaineConnexion définissant la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        #region Méthode GetQuestions renvoyant une liste d'objets Question à partir de la méthode GetQuestion de la DAL
        public static List<Question> GetQuestions()
        {
            return QuestionDAO.GetLesQuestionDAO();
        }
        #endregion
    }
}
