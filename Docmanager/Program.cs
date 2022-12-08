using Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

foreach (string quantityClass in docmanager.ReadNames())
{
    Console.WriteLine(quantityClass);
}

//Console.WriteLine(docmanager.EditUnit("inverse henry", "id", "test"));


