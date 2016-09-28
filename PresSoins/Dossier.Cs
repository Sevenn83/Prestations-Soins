using System;
using System.Collections.Generic;
using System.Linq;

namespace PresSoins
{
    /// <summary>
    /// </summary>
    public class Dossier
    {
        public Dossier()
        {
        }

        /// <summary>
        ///     Constructeur de la classe Dossier
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        /// <param name="mesPrestations"></param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient,
            List<Prestation> mesPrestations)
        {
            NomPatient = nomPatient;
            PrenomPatient = prenomPatient;
            DateNaissancePatient = dateNaissancePatient;
            MesPrestations = mesPrestations;
        }

        /// <summary>
        ///     Constructeur de la classe Dossier sans Collection de Prestations
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient)
        {
            NomPatient = nomPatient;
            PrenomPatient = prenomPatient;
            DateNaissancePatient = dateNaissancePatient;
        }

        /// <summary>
        ///     Constructeur de la classe Dossier avec une seule Prestation
        /// </summary>
        /// <param name="nomPatient"></param>
        /// <param name="prenomPatient"></param>
        /// <param name="dateNaissancePatient"></param>
        /// <param name="unePrestation"></param>
        public Dossier(string nomPatient, string prenomPatient, DateTime dateNaissancePatient, Prestation unePrestation)
        {
            NomPatient = nomPatient;
            PrenomPatient = prenomPatient;
            DateNaissancePatient = dateNaissancePatient;
            UnePrestation = unePrestation;
        }

        public string NomPatient { get; }
        public string PrenomPatient { get; }
        public DateTime DateNaissancePatient { get; }
        public List<Prestation> MesPrestations { get; }
        public Prestation UnePrestation { get; }

        /// <summary>
        ///     Permet d'ajouter une Prestation à une collection de Prestations
        /// </summary>
        /// <param name="unLibelle"></param>
        /// <param name="uneDate"></param>
        /// <param name="uneHeure"></param>
        /// <param name="unIntervenant"></param>
        public void AjouterPrestation(string unLibelle, DateTime uneDate, DateTime uneHeure, Intervenant unIntervenant)
        {
            MesPrestations.Add(new Prestation(unLibelle, uneDate, uneHeure, unIntervenant));
        }

        /// <summary>
        ///     Permet de retourner le nombre de prestations externe dans la collection MesPrestations
        /// </summary>
        /// <returns></returns>
        public int GetNbPrestationsExternes()
        {
            return MesPrestations.Count(p => p.L_intervenant is IntervenantExterne);
        }

        /// <summary>
        ///     Retourne le nombre de prestations
        /// </summary>
        /// <returns></returns>
        public int GetNbPrestations()
        {
            return MesPrestations.Count;
        }

        /// <summary>
        ///     Retourne le nombre de jours de soins
        /// </summary>
        /// <returns></returns>
        public int GetNbJoursSoins()
        {
            var datesTemp = (from meh in MesPrestations where MesPrestations.Contains(meh) select meh.DateSoin).ToList();
            return datesTemp.Count;
        }

        public override string ToString()
        {
            return NomPatient + " " + PrenomPatient + " " + DateNaissancePatient.ToShortDateString();
        }
    }
}