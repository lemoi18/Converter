using Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

//foreach (string quantityClass in docmanager.ReadNames())
//{
//    Console.WriteLine(quantityClass);
//}

Console.WriteLine(docmanager.ReadDimension("A"));

foreach(var x in docmanager.ReadDimension("I"))
{
    Console.WriteLine(x);
}


