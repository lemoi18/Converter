using Docmanager;
using System.Diagnostics;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static Docmanager.Docmanager;
using System.Reflection;
using System.ComponentModel;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");


//docmanager.CreateUOM("test", "test", "test", "test", "test", "test");
Console.WriteLine(docmanager.RemoveQualityType("per Kelvin", "linear thermal expansion"));