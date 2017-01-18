

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilisateursGUI;
using smoCommon = Microsoft.SqlServer.Management.Common;
using smo = Microsoft.SqlServer.Management.Smo;
using System.Configuration;
using System.Globalization;
using System.Data.SqlClient;
using ProfetcieDAL; // Référence la couche DAL
using System.IO;

namespace UtilisateursGUI
{
    public partial class Menu : Form
    {
        #region Initialisation du menu
        public Menu()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            ProfetcieBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);
        }


        #endregion

        #region Module Gestion des élèves

        #endregion

        #region Bouton pour lancer le mode classique
        private void btnClassique(object sender, EventArgs e)
        {
            //affiche le mode de jeu classique
            Classique FrmModLect;
            FrmModLect = new Classique();
            FrmModLect.ShowDialog();
        }
        #endregion
    }
}