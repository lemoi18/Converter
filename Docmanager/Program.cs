using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

Console.WriteLine("-------------------");
foreach (var Unit in docmanager.ReadUnits())
{
    foreach (var prop in Unit)
    Console.WriteLine(prop.Value);
}
