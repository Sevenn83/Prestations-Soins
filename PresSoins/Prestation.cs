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
    public class Prestation
    {
        public string Libelle { get; }
        public DateTime DateSoin { get; }
        public DateTime HeureSoin { get; }
        public Intervenant L_intervenant { get; }

        /// <summary>
        /// Constructeur de la classe Prestation
        /// </summary>
        /// <param name="libelle"></param>
        /// <param name="dateSoin"></param>
        /// <param name="heureSoin"></param>
        /// <param name="intervenant"></param>
        public Prestation(string libelle, DateTime dateSoin,DateTime heureSoin, Intervenant intervenant )
        {
            this.Libelle = libelle;
            this.DateSoin = dateSoin;
            this.HeureSoin = heureSoin;
            this.L_intervenant = intervenant;


        }
        public Prestation()
        {

        }
        /// <summary>
        /// Permet de comparer une date à une autre, Seulement le JOUR / MOIS / ANNEE et non les heures
        /// retourne : 
        /// 0 Si elles sont égales
        /// 1 Si la date est supérieur
        /// -1 si la date est inférieur
        /// </summary>
        /// <param name="unePrestation"></param>
        /// <returns></returns>
        public int compareTo(Prestation unePrestation)
        {
            if (this.DateSoin.Day == unePrestation.DateSoin.Day 
                && this.DateSoin.Month == unePrestation.DateSoin.Month 
                && this.DateSoin.Year == unePrestation.DateSoin.Year) return 0;
            else if (this.DateSoin.Day > unePrestation.DateSoin.Day 
                && this.DateSoin.Month > unePrestation.DateSoin.Month 
                && this.DateSoin.Year > unePrestation.DateSoin.Year) return 1;
            else return -1;
        }


    }
}
