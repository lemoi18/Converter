using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> quantityTypes = new List<string>() { "test1", "test2" };
List<string> aliases = new List<string>() { "test3", "test4" };

docmanager.EditUnit("inverse henry", "A", "testuom");

//docmanager.EditUnit("inverse henry", "quantitytype" , "test");

