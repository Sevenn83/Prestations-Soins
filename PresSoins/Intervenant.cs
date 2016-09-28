using System.Collections.Generic;

namespace PresSoins
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
        public Intervenant(string nom, string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            //this.LesPrestations = lesPrestations;
        }
        /// <summary>
        /// Permet d'ajouter une Prestation à une collection de Prestations
        /// </summary>
        /// <param name="unePrestation"></param>
        public void AjouterPrestation(Prestation unePrestation)
        {
            this.LesPrestations.Add(unePrestation);
        }
    }
}
