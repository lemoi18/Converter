using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");


//docmanager.ReadUnits();
foreach (var Unit in docmanager.ReadUnits())
{
    Console.WriteLine("-------------------");
    foreach (var list in Unit)
    {
        foreach (var prop in list.Value)
        {
            Console.WriteLine(prop);
        }
    }

}
