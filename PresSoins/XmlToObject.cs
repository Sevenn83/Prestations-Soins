using System.Collections.ObjectModel;
using System.Xml;

namespace PresSoins
{
    internal class XmlToObject
    {
        /// <summary>
        /// Permet de retourner une collection de dossier hydrater par un xml
        /// </summary>
        /// <param name="pathToXml">Lien absolu vers le xml</param>
        /// <returns>Collection de dossier issue d'un xml donnée</returns>
        public static Collection<Dossier> XmlToCollectionDossiers(string pathToXml)
        {
            // Création de la collection retournée et du reader.
            var dossiers = new Collection<Dossier>();
            var reader = XmlReader.Create(pathToXml);



            return dossiers;
        }
    }
}
