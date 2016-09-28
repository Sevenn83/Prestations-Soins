using System;

namespace PresSoins
{
    /// <summary>
    /// </summary>
    public class Prestation
    {
        /// <summary>
        ///     Constructeur de la classe Prestation
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="dateSoin"></param>
        /// <param name="heureSoin"></param>
        /// <param name="intervenant"></param>
        public Prestation(string libelle, DateTime dateSoin, DateTime heureSoin, Intervenant intervenant)
        {
            Libelle = libelle;
            DateSoin = dateSoin;
            HeureSoin = heureSoin;
            L_intervenant = intervenant;
        }

        public Prestation()
        {
        }

        public string Libelle { get; }
        public DateTime DateSoin { get; }
        public DateTime HeureSoin { get; }
        public Intervenant L_intervenant { get; }

        /// <summary>
        ///     Permet de comparer une date à une autre, Seulement le JOUR / MOIS / ANNEE et non les heures
        ///     retourne :
        ///     0 Si elles sont égales
        ///     1 Si la date est supérieur
        ///     -1 si la date est inférieur
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns></returns>
        public int compareTo(Prestation unePrestation)
        {
            if (DateSoin.Day == unePrestation.DateSoin.Day
                && DateSoin.Month == unePrestation.DateSoin.Month
                && DateSoin.Year == unePrestation.DateSoin.Year) return 0;
            if (DateSoin.Day > unePrestation.DateSoin.Day
                && DateSoin.Month > unePrestation.DateSoin.Month
                && DateSoin.Year > unePrestation.DateSoin.Year) return 1;
            return -1;
        }

        public override string ToString()
        {
            return Libelle + " - Date de soin : " + DateSoin.ToString("dd/mmmm/yyyy") + " Heure de soin : " + HeureSoin.ToString("t");
        }
    }
}