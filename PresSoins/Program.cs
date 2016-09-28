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

                    if (dossier.MesPrestations.Count > 0)
                        Console.WriteLine("Liste des prestations :");
                    foreach (var prestation in dossier.MesPrestations)
                    {
                        Console.WriteLine(prestation.ToString());
                        Console.WriteLine("Intervenant :");
                        Console.WriteLine(prestation.L_intervenant.ToString());
                    }
                    Console.WriteLine("\n ------------------------------- \n");
                }
                Console.WriteLine("Appuyez sur une touche pour continuer ...");
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