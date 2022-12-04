using Docmanager;
using System.Diagnostics;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static Docmanager.Docmanager;
using System.Reflection;
using System.ComponentModel;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");



// Put changes into file
//File.WriteAllText(filepath, jObject.ToString());

//var matches = 
//from unit in jsonDeserialized
//where unit.Name == "per Kelvin"
//select unit;

//foreach (var match in matches) 
//{
//try
//{
//Console.WriteLine(match.Name);
//}
//catch (NullReferenceException)
//{
//Console.WriteLine("test");
//}
//}
double A = 404;
double B = 404;
double C = 404;
double D = 404;

docmanager.ReadConversion("degrees F square feet hours/Btu", ref A, ref B, ref C, ref D);

Console.WriteLine("A: {0}\nB: {1}\nC: {2}\nD: {3}", A, B, C, D);