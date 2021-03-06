﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ProfetcieBO; // Référence la couche BO
using ProfetcieDAL; // Référence la couche DAL

namespace ProfetcieBLL
{
    public class GestionEleve
    {
        private static GestionEleve uneGestionEleve; // Objet BLL

        #region Accesseur en lecture
        public static GestionEleve GetGestionEleve()
        {
            if (uneGestionEleve == null)
            {
                uneGestionEleve = new GestionEleve();
            }
            return uneGestionEleve;
        }
        #endregion

        #region Méthode SetChaineConnexion définissant la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }
        #endregion

        

        #region Méthode GetEleves renvoyant une liste d'objets Eleve à partir de la méthode GetEleve de la DAL
        public static List<Eleve> GetEleves()
        {
            return EleveDAO.GetEleves();
        }
        #endregion

        
    }
}