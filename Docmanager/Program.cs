using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

List<string> quantityTypes = new List<string>() { "test1", "test2" };
List<string> aliases = new List<string>() { "test3", "test4" };

docmanager.CreateSecondaryUnit("id", "annotation", "name", quantityTypes, "dimensionalclass", "uom", "baseunit", 2, 2, 2, 2, aliases);

//docmanager.EditUnit("inverse henry", "quantitytype" , "test");

