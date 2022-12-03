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

var matches = 
    from unit in jObject
    //where unit.Name == "per Kelvin"
    select unit;

foreach (var match in matches) 
{
    Console.WriteLine(match.Name);
}



