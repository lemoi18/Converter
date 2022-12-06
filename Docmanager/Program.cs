using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");


foreach (var element in docmanager.ReadAliases("metre"))
{
    Console.WriteLine(element);
}
