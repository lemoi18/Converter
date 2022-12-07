using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> list = docmanager.ReadProperties("per Kelvin");

foreach (string entry in list)
{
    Console.WriteLine(entry);
}




//Console.WriteLine(docmanager.ReadProperties("per Kelvin"));