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

JObject jObject = JsonConvert.DeserializeObject(jsonString) as JObject;

// Put changes into file
//File.WriteAllText(filepath, jObject.ToString());
//var temp = from unit in jObject["UnitOfMeasure"]
//where unit["Name"].ToString(Newtonsoft.Json.Formatting.None) == "\"per Kelvin"\"
//select unit;

IEnumerable<UnitClass> temp =
    from unit in jObject["UnitOfMeasure"]
    where unit["Name"].Value<string>() == "per Kelvin"
    select new UnitClass
    {
        Name = unit["Name"].Value<string>(),
        QuantityType = unit["QuantityType"].ToObject<List<String>>(),
        //DimensionalClass =
    };

//Console.WriteLine(jObject["UnitOfMeasure"]);

foreach (var unit in temp)
{
    Console.WriteLine("{0}\n", unit.QuantityType[0]);
}

