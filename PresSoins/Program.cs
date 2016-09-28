using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classesMetier;
using maBoiteAOutils;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using maBoiteAOutils.Extensions;
using System.Xml.Linq;

namespace PresSoins
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNaissancePatientUn = new DateTime(1992, 04, 04);
            DateTime datePatientUn = new DateTime(2016, 09, 04);
            DateTime datePatientDeux = new DateTime(2015, 12, 01);

            DateTime heurePatientUn = new DateTime(2016, 09, 04, 11, 34, 11);
            DateTime heurePatientDeux = new DateTime(2015, 12, 01, 12, 11, 41);

            List<Prestation> desPrestations = new List<Prestation>();
            Prestation unePrestation = new Prestation("numPrestation1", datePatientUn, heurePatientUn, new Intervenant("BIDON", "BIDONPRENOM", desPrestations));
            Prestation deuxPrestation = new Prestation("numPrestation2", datePatientDeux, heurePatientDeux, new Intervenant("BIDONNE", "MICHON", desPrestations));

            desPrestations.Add(unePrestation);

            IntervenantExterne intervExterne = new IntervenantExterne("Raimon", "Dylan", desPrestations, "maths Sup", "100 rue des Chats", "0606060606");


            Dossier dossierUnePrestation =new Dossier("PatientDossierVide", "PrenomPatientDossierVide", dateNaissancePatientUn, unePrestation);
            Dossier dossierListePrestation = new Dossier("DossierList", "PrenomDossierList", dateNaissancePatientUn, desPrestations);
            Dossier dossierVide = new Dossier("Dossier vide", "dossier vide", dateNaissancePatientUn);

            dossierListePrestation.ajouterPrestation("Meh", datePatientUn, heurePatientUn, intervExterne);



            /** 
             * XML
             * **/
            // var xmlString = desPrestations.Serialize();
            // Utilisation de la bibliothéque LINQ


            string fileName = "jeudEssai.xml";
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);



            // Console.WriteLine(unePrestation.ToString() + "\n" + xmlString.ToString());


        }
    }
}
