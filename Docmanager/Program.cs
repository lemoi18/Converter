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

Console.WriteLine(docmanager.AddQuantityType("per Kelvin", "Test"));