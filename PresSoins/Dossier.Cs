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
    public class Dossier
    {
        public string NomPatient { get; }
        public string PrenomPatient { get; }
        public DateTime DateNaissancePatient { get; }
        public List<Prestation> MesPrestations { get; }
        public Prestation UnePrestation { get; }
        /// <summary>
        /// Constructeur de la classe Dossier
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        /// <param name="mesPrestations"></param>
        public Dossier() { }
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient, List<Prestation> mesPrestations)
        {
            this.NomPatient = nomPatient;
            this.PrenomPatient = prenomPatient;
            this.DateNaissancePatient = dateNaissancePatient;
            this.MesPrestations = mesPrestations;
        }
        /// <summary>
        /// Constructeur de la classe Dossier sans Collection de Prestations
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient)
        {
            this.NomPatient = nomPatient;
            this.PrenomPatient = prenomPatient;
            this.DateNaissancePatient = dateNaissancePatient;
        }
        /// <summary>
        /// Constructeur de la classe Dossier avec une seule Prestation
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        /// <param name="unePrestation"></param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient, Prestation unePrestation)
        {
            this.NomPatient = nomPatient;
            this.PrenomPatient = prenomPatient;
            this.DateNaissancePatient = dateNaissancePatient;
            this.UnePrestation = unePrestation;
        }
        /// <summary>
        /// Permet d'ajouter une Prestation à une collection de Prestations
        /// </summary>
        /// <param name="unLibelle"></param>
        /// <param name="uneDate"></param>
        /// <param name="uneHeure"></param>
        /// <param name="unIntervenant"></param>
        public void ajouterPrestation(string unLibelle, DateTime uneDate, DateTime uneHeure, Intervenant unIntervenant)
        {
            MesPrestations.Add(new Prestation(unLibelle, uneDate, uneHeure, unIntervenant));
        }

        /// <summary>
        /// Permet de retourner le nombre de prestations externe dans la collection MesPrestations
        /// </summary>
        /// <returns></returns>
        public int getNbPrestationsExternes()
        {
            int i = 0;
            foreach (Prestation p in MesPrestations) if (p.L_intervenant is IntervenantExterne) i++;
            return i;

        }
        /// <summary>
        /// Retourne le nombre de prestations
        /// </summary>
        /// <returns></returns>
        public int getNbPrestations()
        {
            return MesPrestations.Count();
        }
        /// <summary>
        /// Retourne le nombre de jours de soins
        /// </summary>
        /// <returns></returns>
        public int getNbJoursSoins()
        {
            List<DateTime> datesTemp = new List<DateTime>();
            foreach (Prestation Meh in MesPrestations)
            {
                if (MesPrestations.Contains(Meh))
                {
                    datesTemp.Add(Meh.DateSoin);
                }
            }
            return datesTemp.Count();

            /*
            int i = 0;
            var temp = MesPrestations[0];
            foreach (Prestation p in MesPrestations)
            {
                if (p.DateSoin != temp.DateSoin) i++;
                temp = MesPrestations[i];
            }
            return 0;
            */
        }
        public override string ToString()
        {
            return NomPatient.ToString() + " " + PrenomPatient.ToString() + " " + DateNaissancePatient.ToShortDateString();
        }

    }
}
