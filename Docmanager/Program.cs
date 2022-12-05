using Docmanager;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

Console.WriteLine(docmanager.AddQuantityType("per Kelvin", "Test"));