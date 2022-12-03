using Docmanager;
using System.Diagnostics;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static Docmanager.Docmanager;
using System.Reflection;
using System.ComponentModel;


UnitClass t = new UnitClass();

const string filepath = @"C:\Users\Yea\IKT300\Engineering units - mappe eksamen\Docmanager\POSC.json";

string jsonString = File.ReadAllText(filepath);

var jObject = JsonConvert.DeserializeObject<List<UnitClass>>(jsonString);

// Put changes into file
//File.WriteAllText(filepath, jObject.ToString());

//var temp = from unit in jObject["UnitOfMeasure"]
//where unit["Name"].ToString(Newtonsoft.Json.Formatting.None) == "\"per Kelvin"\"
//select unit;


//Console.WriteLine(jObject["UnitOfMeasure"]);


Console.WriteLine("{0}\n", jObject[1].QuantityType[1]);


