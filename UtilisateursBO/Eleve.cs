using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilisateursBO
{
    public class Eleve
    {
        #region Attributs de la classe Eleve
        private string nom;
        private string prenom;
        private string demiClasse;
        private string sexe;
        private string origine;
        private string asso;
        private string couleurCheveux;
        private string longueur;
        private string bouclesRaides;
        private string couleurYeux;
        private string lunettes;
        private string taille;
        private string passion;
        private string surnom;
        private string qualite;
        private string defaut;
        private string special1;
        private string special2;

        #endregion

        #region Encapsulation des attributs

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public string DemiClasse
        {
            get { return demiClasse; }
            set { demiClasse = value; }
        }

        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }

        public string Origine
        {
            get { return origine; }
            set { origine = value; }
        }

        public string Asso
        {
            get { return asso; }
            set { asso = value; }
        }

        public string CouleurCheveux
        {
            get { return couleurCheveux; }
            set { couleurCheveux= value; }
        }

        public string Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public string BouclesRaides
        {
            get { return bouclesRaides; }
            set { bouclesRaides = value; }
        }

        public string CouleurYeux
        {
            get { return couleurYeux; }
            set { couleurYeux = value; }
        }

        public string Lunettes
        {
            get { return lunettes; }
            set { lunettes = value; }
        }

        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public string Passion
        {
            get { return passion; }
            set { passion = value; }
        }

        public string Surnom
        {
            get { return surnom; }
            set { surnom = value; }
        }

        public string Qualite
        {
            get { return qualite; }
            set { qualite = value; }
        }


        public string Defaut
        {
            get { return defaut; }
            set { defaut = value; }
        }


        public string Special1
        {
            get { return special1; }
            set { special1 = value; }
        }

        public string Special2
        {
            get { return special2; }
            set { special2 = value; }
        }

        #endregion

        #region Constructeurs de la classe Eleve

        public Eleve(string nom, string prenom, string demiClasse, string sexe, string origine, string asso, string couleurCheveux, string longueur, string bouclesRaides, string couleurYeux, string lunettes, string taille, string passion, string surnom, string qualite, string defaut, string special1, string special2)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.demiClasse = demiClasse;
            this.sexe = sexe;
            this.origine = origine;
            this.asso = asso;
            this.couleurCheveux = couleurCheveux;
            this.longueur = longueur;
            this.bouclesRaides = bouclesRaides;
            this.couleurYeux = couleurYeux;
            this.lunettes = lunettes;
            this.taille = taille;
            this.passion = passion;
            this.surnom = surnom;
            this.qualite = qualite;
            this.defaut = defaut;
            this.special1 = special1;
            this.special2 = special2;

        }
        #endregion
    }
}