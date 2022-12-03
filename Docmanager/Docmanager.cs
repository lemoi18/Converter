///////////////////////////////////////////////////////////
//  GroupParser.cs
//  Implementation of the Class GroupParser
//  Generated by Enterprise Architect
//  Created on:      26-nov-2022 12:13:28
//  Original author: Lars
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Docmanager;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Docmanager
{
    internal class Docmanager
    {
        //https://stackoverflow.com/questions/18994685/how-to-handle-both-a-single-item-and-an-array-for-the-same-property-using-json-n
        class SingleOrArrayConverter<T> : JsonConverter
        {
            public override bool CanConvert(Type objectType)
            {
                return (objectType == typeof(List<T>));
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                JToken token = JToken.Load(reader);
                if (token.Type == JTokenType.Array)
                {
                    return token.ToObject<List<T>>();
                }
                return new List<T> { token.ToObject<T>() };
            }

            public override bool CanWrite
            {
                get { return false; }
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }
        public class UnitClass
        {
            public string id { get; set; }
            public string annotation { get; set; }
            public string Name { get; set; }
            [JsonConverter(typeof(SingleOrArrayConverter<string>))]
            public List<string> QuantityType { get; set; }
            public string DimensionalClass { get; set; }
            //public SameUnit SameUnit { get; set; }
            
        }

        public class SameUnit
        {
            public string uom { get; set; }
            public string namingSystem { get; set; }
        }

        const string filepath = @"C:\\Users\\Yea\\IKT300\\Engineering units - mappe eksamen\\Converter\\POSC.json";

        string jsonString = File.ReadAllText(filepath);

        JObject jObject = Newtonsoft.Json.JsonConvert.DeserializeObject(File.ReadAllText(filepath)) as JObject;


        // Put changes into file
        //File.WriteAllText(filepath, jObject.ToString());
        //var temp = from unit in jObject["UnitOfMeasure"]
        //where unit["Name"].ToString(Newtonsoft.Json.Formatting.None) == "\"per Kelvin"\"
        //select unit;

        //Console.WriteLine(jObject["UnitOfMeasure"]);


        //Console.WriteLine();
    }//end GroupParser

}//end namespace Docmanager