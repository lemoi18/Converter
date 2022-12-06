using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> test = docmanager.ReadAliases("mdfsf");

Console.WriteLine("-------");
foreach (string item in test)
{
    Console.WriteLine(item);
}

//Console.WriteLine(docmanager.ReadUOM("per Kelvin"));

