using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace PresSoins
{
    internal abstract class XmlToObject
    {
        /// <summary>
        /// Permet de retourner une collection de dossier hydrater par un xml
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
                var dossier = new XmlDocument();
                dossier.LoadXml("<?xml version=\"1.0\" encoding=\"UTF - 8\"?><root>" + dossierNodeList.Item(i).InnerXml + "</root>");

                var nom = dossier.GetElementsByTagName("nom")[0].InnerText;
                var prenom = dossier.GetElementsByTagName("prenom")[0].InnerText;
                var dateNaissancePatient = ConvertXmlDateTime(dossier.GetElementsByTagName("datenaissance").Item(0));
                var prestations = new List<Prestation>();

                dossiers.Add(new Dossier(nom, prenom, dateNaissancePatient, prestations));
            }


            return dossiers;
        }

        private static DateTime ConvertXmlDateTime(XmlNode dateNaissanceNode)
        {
            Console.WriteLine();
            return new DateTime(Convert.ToInt32(dateNaissanceNode.ChildNodes[0].InnerText),
                Convert.ToInt32(dateNaissanceNode.ChildNodes[1].InnerText), Convert.ToInt32(dateNaissanceNode.ChildNodes[2].InnerText));
        }

    }
}
