


using Connector;
using System;
using Docmanager;
using Newtonsoft.Json.Linq;

IC converter;
// Test is only mm to cm
converter = ConnectorFactory.CreateConnectorFactory("Test");

converter.ConverterWrapper(10, "cm", "m");
//converter.ConverterWrapper(100, "mm", "m");
//converter.ConverterWrapper(1000, "mm", "cm");


//Tuple<double,string, string> t = converter.ConvertToBase(10,"mm","cm");
//t = converter.BaseToConvert(t.Item1, t.Item2, t.Item3);
//Console.WriteLine(converter.WriteToConsole(t));
//Console.WriteLine(converter.ConverterWrapper(t.Item1, t.Item2, t.Item3));


const string filepath = @"C:\Users\Skole\source\repos\Exam\Converter\Docmanager\POSC.json";

string jsonString = File.ReadAllText(filepath);

JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString) as JObject;


Console.WriteLine(jObject["UnitOfMeasure"].ToString());

