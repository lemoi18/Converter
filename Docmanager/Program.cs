using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

Console.WriteLine(docmanager.CreateUnit("Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test", "Test"));

//foreach (var element in docmanager.ReadDimensions())
//{
//    Console.WriteLine(element[0]);
//}
