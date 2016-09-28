using System;
using System.IO;
using System.Xml;

namespace PresSoins
{
    internal class Program
    {
        private static void Main()
        {
            const string fileName = "jeudEssai.xml";
            var path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            var doc = new XmlDocument();
            doc.Load(path);
        }
    }
}
