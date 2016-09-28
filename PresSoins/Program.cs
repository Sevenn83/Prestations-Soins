using System;
using System.IO;

namespace PresSoins
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                const string fileName = "jeudEssai.xml";
                var path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
                var dossiers = XmlToObject.XmlToCollectionDossiers(path);
                foreach (var dossier in dossiers)
                {
                    Console.WriteLine(dossier.ToString());
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Appuyez sur une touche pour continuer ...");
                Console.ReadKey();
            }
        }
    }
}