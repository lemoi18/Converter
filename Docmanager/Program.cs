using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> UOMforGivenQuantityClass = docmanager.ReadUOM("volumerw");

Console.WriteLine("-------");
foreach (string item in UOMforGivenQuantityClass)
{
    Console.WriteLine(item);
}


