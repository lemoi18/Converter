using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

//List<string> uoms = docmanager.ReadUom("inverse henry");

//foreach (string uom in uoms)
//Console.WriteLine(uom);

//docmanager.EditUnit("inverse henry", "quantitytype" , "test");

Console.WriteLine(docmanager.ReadAnnotation("1/Ksdff"));