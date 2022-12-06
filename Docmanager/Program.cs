using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");


foreach(var element in docmanager.ReadDimensions())
{
    foreach(var prop in element)
    Console.WriteLine(prop);
}

