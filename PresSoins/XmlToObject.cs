using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace PresSoins
{
    internal abstract class XmlToObject
    {
        /// <summary>
        ///     Permet de retourner une collection de dossier hydrater par un xml
        /// </summary>
        /// <param name="pathToXml">Lien absolu vers le xml</param>
        /// <returns>Collection de dossier issue d'un xml donnée</returns>
        public static Collection<Dossier> XmlToCollectionDossiers(string pathToXml)
        {
            // Création de la collection retournée
            var dossiers = new Collection<Dossier>();
            // Chargement du XML
            var doc = new XmlDocument();
            doc.Load(pathToXml);

            var dossierNodeList = doc.GetElementsByTagName("dossier");

            for (var i = 0; i < dossierNodeList.Count; i++)
            {
                // Génération d'un xml par dossier, exploitable.
                var dossierXml = new XmlDocument();
                dossierXml.LoadXml("<?xml version=\"1.0\" encoding=\"UTF - 8\"?><root>" +
                                   dossierNodeList.Item(i).InnerXml + "</root>");

                var nom = dossierXml.GetElementsByTagName("nom")[0].InnerText;
                var prenom = dossierXml.GetElementsByTagName("prenom")[0].InnerText;
                var dateNaissancePatient = ConvertXmlDate(dossierXml.GetElementsByTagName("datenaissance").Item(0));
                var prestations = ConvertPrestations(dossierXml.GetElementsByTagName("prestations"));

                dossiers.Add(new Dossier(nom, prenom, dateNaissancePatient, prestations));
            }


            return dossiers;
        }

        private static DateTime ConvertXmlDate(XmlNode dateNaissanceNode)
        {
            return new DateTime(Convert.ToInt32(dateNaissanceNode.ChildNodes[0].InnerText),
                Convert.ToInt32(dateNaissanceNode.ChildNodes[1].InnerText),
                Convert.ToInt32(dateNaissanceNode.ChildNodes[2].InnerText));
        }

        private static DateTime ConvertXmlTime(XmlNode heure)
        {
            return new DateTime(Convert.ToInt32(heure.ChildNodes[0].InnerText),
                Convert.ToInt32(heure.ChildNodes[1].InnerText), Convert.ToInt32(heure.ChildNodes[2].InnerText),
                Convert.ToInt32(heure.ChildNodes[3].InnerText), Convert.ToInt32(heure.ChildNodes[4].InnerText), 0);
        }

        private static List<Prestation> ConvertPrestations(XmlNodeList presNodeList)
        {
            var prestations = new List<Prestation>();
            for (var i = 0; i < presNodeList.Count; i++)
            {
                var prestationXml = new XmlDocument();
                prestationXml.LoadXml("<?xml version=\"1.0\" encoding=\"UTF - 8\"?><root>" +
                                      presNodeList.Item(i).InnerXml + "</root>");

                var libelle = prestationXml.GetElementsByTagName("libelle")[0].InnerText;
                var dateSoin = ConvertXmlDate(prestationXml.GetElementsByTagName("dateprestation").Item(0));
                var heureSoin = ConvertXmlTime(prestationXml.GetElementsByTagName("dateprestation").Item(0));
                var intervenant =
                    new Intervenant(prestationXml.GetElementsByTagName("intervenant").Item(0).ChildNodes[0].InnerText,
                        prestationXml.GetElementsByTagName("intervenant").Item(0).ChildNodes[1].InnerText);


                prestations.Add(new Prestation(libelle, dateSoin, heureSoin, intervenant));
            }


            return prestations;
        }
    }
}