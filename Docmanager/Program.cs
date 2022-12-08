using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

Dictionary<string, List<string>> list = docmanager.ReadQuantityTypes();

foreach (string quantityClass in docmanager.ReadQuantityClasses())
{
    Console.WriteLine(quantityClass);
}

//Console.WriteLine(docmanager.EditUnit("inverse henry", "id", "test"));


