using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    class IntervenantExterne : Intervenant
    {
        public string Specialite { get; }
        public string Adresse { get; }
        public string Tel { get; }
        /// <summary>
        /// Constructeur de la classe Itervenant Externe, héritant de la classe Intervenant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="lesPrestations"></param>
        /// <param name="specialite"></param>
        /// <param name="adresse"></param>
        /// <param name="tel"></param>
         public IntervenantExterne(string nom, string prenom, List<Prestation> lesPrestations, string specialite, string adresse, string tel) : base(nom, prenom, lesPrestations)
        {
            this.Specialite = specialite;
            this.Adresse = adresse;
            this.Tel = tel;
        }

    }
}
