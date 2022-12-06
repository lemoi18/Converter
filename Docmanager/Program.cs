using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

Console.WriteLine(docmanager.CreateSecondaryUnit("Test", "Test", "Test", "Test", "Test", "Test", "Test", 1, 2, 3, 4, bigCities));