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


const string filepath = @"C:\Users\Yea\IKT300\Engineering units - mappe eksamen\Docmanager\POSC.json";

string jsonString = File.ReadAllText(filepath);

var jsonDeserialized = JsonConvert.DeserializeObject<List<Root>>(jsonString);

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

docmanager.ReadAnnotation("test");