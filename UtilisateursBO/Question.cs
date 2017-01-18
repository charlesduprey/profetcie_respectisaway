using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProfetcieBO
{
    public class Question
    {
        #region Attributs de la classe Question
        private string questiont;
        private string rang;
        #endregion

        #region Encapsulation des attributs

        public string Questiont
        {
            get { return questiont; }
            set { questiont = value; }
        }

        public string Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        #endregion
         
        #region Constructeurs de la classe Question

        public Question(string questiont, string rang)
        {
            this.questiont = questiont;
            this.rang = rang;

        }
        #endregion
    }
}
