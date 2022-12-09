using Docmanager;
using static Docmanager.Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

//foreach (string quantityClass in docmanager.ReadNames())
//{
//    Console.WriteLine(quantityClass);
//}


Console.WriteLine(docmanager.RemoveAlias("inverse henry", "ape?"));

//foreach(var x in docmanager.ReadDimension("I"))
//{
//    Console.WriteLine(x);
//}


