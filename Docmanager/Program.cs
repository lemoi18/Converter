using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> uoms = docmanager.ReadUom("milliEuclid");

foreach (string uom in uoms)
Console.WriteLine(uom);

//docmanager.EditUnit("inverse henry", "quantitytype" , "test");

