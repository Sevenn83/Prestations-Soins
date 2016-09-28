using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesMetier
{
    /// <summary>
    /// 
    /// </summary>
   public class Intervenant
    {
        public string Nom { get; }
        public string Prenom { get; }
        public List<Prestation> LesPrestations { get; }

        /// <summary>
        /// Constructeur de la classe Intervenant
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="lesPrestations"></param>
        public Intervenant(string nom, string prenom, List<Prestation>lesPrestations)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.LesPrestations = lesPrestations;
        }
        /// <summary>
        /// Permet d'ajouter une Prestation à une collection de Prestations
        /// </summary>
        /// <param name="unePrestation"></param>
        public void ajouterPrestation(Prestation unePrestation)
        {
            this.LesPrestations.Add(unePrestation);
        }
    }
}
