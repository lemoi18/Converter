using Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

//foreach (string quantityClass in docmanager.ReadNames())
//{
//    Console.WriteLine(quantityClass);
//}


List<string> uomList = docmanager.ReadUOMsFromQuantityType("admittance");

// Iterate over the list and print each string
foreach (string uom in uomList)
{
    Console.WriteLine(uom);
}