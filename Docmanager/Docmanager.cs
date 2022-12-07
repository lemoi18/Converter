///////////////////////////////////////////////////////////
//  GroupParser.cs
//  Implementation of the Class GroupParser
//  Generated by Enterprise Architect
//  Created on:      26-nov-2022 12:13:28
//  Original author: Lars
///////////////////////////////////////////////////////////

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using static Docmanager.Docmanager;

namespace Docmanager
{
    internal class Docmanager : IDocmanager
    {

        List<UOM> Units = JsonConvert.DeserializeObject<List<UOM>>(File.ReadAllText(Pathgetter("POSC.json")));

        List<Dimension> Dimensions = JsonConvert.DeserializeObject<List<Dimension>>(File.ReadAllText(Pathgetter("UnitDimensions.json")));

        public static string Pathgetter(string filename)
        {

            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            actualPath = actualPath.Substring(0, actualPath.LastIndexOf("/"));
            actualPath = actualPath.Substring(0, actualPath.LastIndexOf("/"));
            string projectPath = new Uri(actualPath).LocalPath;
            path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, projectPath + "/JsonGetter/" + filename);
            return path;
        }
        private UOM QueryName(string unitName)
        {
            try
            {
                UOM houseOnes = Units.First(unit => unit.Name == unitName);

                return houseOnes;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no unit with this name");
            }
        }

        private UOM QueryID(string ID)
        {
            try
            {
                UOM houseOnes = Units.First(unit => unit.id == ID);


                return houseOnes;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no unit with this ID");
            }
        }

        private UOM QueryUOM(string uom)
        {
            try
            {
                

                UOM houseOnes = Units.First(unit => ReadUom(unit) == uom);


                return houseOnes;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no unit with this uom");
            }
        }

        private Dimension QueryDimension(string symbol)
        {
            try
            {

                Dimension match = Dimensions.First(dim => dim.Symbol == symbol);
                   

                return match;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no dimension with this symbol");
            }
        }

        public List<List<KeyValuePair<string, List<String>>>> ReadUnits()
        {
            List<List<KeyValuePair<string, List<String>>>> output = new List<List<KeyValuePair<string, List<String>>>>();

            foreach (var unit in Units)
            {
                var unitKVPs = new List<KeyValuePair<string, List<string>>>();

                unitKVPs.Add(new KeyValuePair<string, List<string>>("id", new List<string>() { unit.id }));
                unitKVPs.Add(new KeyValuePair<string, List<string>>("annotation", new List<string>() { unit.annotation }));
                unitKVPs.Add(new KeyValuePair<string, List<string>>("name", new List<string>() { unit.Name }));

                string quantityTypeString = "none";
                if (unit.QuantityType != null)
                {
                    quantityTypeString = unit.QuantityType.ToString();
                }
                try
                {
                    JArray quantityTypeJArray = (JArray)JsonConvert.DeserializeObject(quantityTypeString);

                    unitKVPs.Add(new KeyValuePair<string, List<string>>("quantityType", quantityTypeJArray.ToObject<List<string>>()));
                }
                catch (JsonReaderException)
                {
                    unitKVPs.Add(new KeyValuePair<string, List<string>>("quantityType", new List<string>() { quantityTypeString }));
                }
                unitKVPs.Add(new KeyValuePair<string, List<string>>("DimensionalClass", new List<string>() { unit.DimensionalClass }));

                string sameUnitString = "none";
                try
                {
                    if (unit.SameUnit != null)
                    {
                        sameUnitString = unit.SameUnit.ToString();
                        JObject SameUnitJObject = (JObject)JsonConvert.DeserializeObject(sameUnitString);
                        unitKVPs.Add(new KeyValuePair<string, List<string>>("uom", new List<string>() { SameUnitJObject["uom"].ToString() }));
                    }
                }
                catch (InvalidCastException)
                {
                    //unitKVPs.Add(new KeyValuePair<string, List<string>>("uom", new List<string>() { sameUnitString }));
                }

                //unitKVPs.Add(new KeyValuePair<string, List<string>>("isBaseUnit", unit.BaseUnit.ToString()));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("Aliases", unit.Aliases));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("BaseUnit", unit.ConversionToBaseUnit.baseUnit));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("A", unit.ConversionToBaseUnit.Formula.A.ToString()));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("B", unit.ConversionToBaseUnit.Formula.B.ToString()));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("C", unit.ConversionToBaseUnit.Formula.C.ToString()));
                //unitKVPs.Add(new KeyValuePair<string, List<string>>("D", unit.ConversionToBaseUnit.Formula.D.ToString()));

                output.Add(unitKVPs);
            }
            return output;
        }

        public bool NameExists(string unitName)
        {
            try
            {
                QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                return false;
            }

            return true;
        }

        public List<string> ReadProperties(string unitName)
        {
            try
            {
                UOM match = QueryName(unitName);

                try
                {
                    List<string> output = new List<string>();

                    string matchString = JsonConvert.SerializeObject(match, Formatting.Indented);
                    JObject matchJObject = (JObject)JsonConvert.DeserializeObject(matchString);

                    foreach (var prop in matchJObject)
                    {
                        switch (prop.Value.Type.ToString())
                        {
                            case "String":
                                output.Add(prop.Key);
                                break;
                            case "Array":
                                output.Add(prop.Key);
                                break;
                            case "Object":
                                //
                                break;
                            default:
                                break;
                        }

                    }

                    output.Add("A");
                    output.Add("B");
                    output.Add("C");
                    output.Add("D");
                    output.Add("IsBaseUnit");

                    return output;
                }
                catch (NullReferenceException)
                {
                    throw new NullReferenceException("This unit does not have annotation");
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

        public string ReadAnnotation(string unitName)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                try
                {
                    match = QueryUOM(unitName);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no unti with this name or uom");
                }
            }

            try
            {
                

                try
                {
                    return match.annotation;
                }
                catch (NullReferenceException)
                {
                    return "This unit does not have annotation";
                }
            }
            catch (InvalidOperationException)
            {
                return "This name is not in file";
            }
        }

        public string ReadBaseUnit(string unitName)
        {
            try
            {
                UOM houseOnes = Units.First(unit => unit.Name == unitName);

                try
                {
                    return houseOnes.ConversionToBaseUnit.baseUnit;
                }
                catch (NullReferenceException)
                {
                    return "This unit does not have base unit";
                }
            }
            catch (InvalidOperationException)
            {
                return "This name is not in file";
            }
        }

        public List<string> ReadUom(UOM unit)
        {
            string sameUnitString = unit.SameUnit.ToString();

            List<string> output = new List<string>();

            if (unit.SameUnit.GetType() == typeof(JArray))
            {
                JArray sameUnitObject = (JArray)JsonConvert.DeserializeObject(sameUnitString);
                foreach(var obj in sameUnitObject)
                {
                    string objString = obj.ToString();
                    JObject sameUnitJObject = (JObject)JsonConvert.DeserializeObject(objString);
                    output.Add(sameUnitJObject["uom"].ToString());
                }
            }
            else
            {
                JObject sameUnitJObject = (JObject)JsonConvert.DeserializeObject(sameUnitString);
                output.Add(sameUnitJObject["uom"].ToString());
            }

            return output;
        }

        public List<String> ReadUom(string unitName)
        {
            try
            {
                UOM match = QueryName(unitName);
                return ReadUom(match);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }

        public string ReadIsBase(string unitName)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                try
                {
                    match = QueryUOM(unitName);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no unti with this name or uom");
                }
            }

            try
            {
                

                try
                {
                    return match.ConversionToBaseUnit.baseUnit;
                }
                catch (NullReferenceException)
                {
                    return "This unit does not have ConversionToBaseUnit.baseUnit";
                }
            }
            catch (InvalidOperationException)
            {
                return "This name is not in file";
            }
        }

        public bool IsBase(string unitName)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                try
                {
                    match = QueryUOM(unitName);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no unti with this name or uom");
                }
            }




            try
            {
               

                try
                {
                    return match.BaseUnit != null;
                }
                catch (NullReferenceException)
                {
                    throw new NullReferenceException("Logfile cannot be read-only");
                }
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("This name is not in file");
            }
            return true;
        }

        public string ReadUnitName(string annotationName)
        {
            try
            {
                

                UOM houseOnes = Units.First(unit => unit.annotation == annotationName);


                try
                {
                    return houseOnes.Name;
                }
                catch (NullReferenceException)
                {
                    return "This unit does not have a name";
                }
            }
            catch (InvalidOperationException)
            {
                return "This annotation is not in file";
            }
        }

        public string ReadConversion(string input, ref double A, ref double B, ref double C, ref double D)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(input);
            }
            catch (InvalidOperationException)
            {
                try
                {
                    match = QueryUOM(input);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no unti with this name or uom");
                }
            }

            A = B = C = D = 0;

            try
            {
                if (match.ConversionToBaseUnit.baseUnit != null)
                {
                    C = 1;
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Formula.A != null)
                {
                    A = double.Parse(match.ConversionToBaseUnit.Formula.A, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Formula.B != null)
                {
                    B = double.Parse(match.ConversionToBaseUnit.Formula.B, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Formula.C != null)
                {
                    C = double.Parse(match.ConversionToBaseUnit.Formula.C, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Formula.D != null)
                {
                    D = double.Parse(match.ConversionToBaseUnit.Formula.D, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Factor != null)
                {
                    B = double.Parse(match.ConversionToBaseUnit.Factor, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Fraction.Numerator != null)
                {
                    B = double.Parse(match.ConversionToBaseUnit.Fraction.Numerator, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }

            try
            {
                if (match.ConversionToBaseUnit.Fraction.Denominator != null)
                {
                    C = double.Parse(match.ConversionToBaseUnit.Fraction.Denominator, CultureInfo.GetCultureInfo("en-US"));
                }
            }
            catch (NullReferenceException) { }


            return "0";
        }

        public string CreateBaseUnit(string id, string annotation, string name, List<string> quantityTypes, string dimensionalclass, string uom, List<string> aliases)
        {
            JObject SameUnitJObject = new JObject
            {
                ["uom"] = uom,
            };


            UOM newUnit = new UOM();

            newUnit.id = id;
            newUnit.annotation = annotation;
            newUnit.Name = name;
            newUnit.QuantityType = quantityTypes.ToArray();
            newUnit.DimensionalClass = dimensionalclass;
            newUnit.Aliases = aliases;
            newUnit.SameUnit = SameUnitJObject;
            newUnit.BaseUnit = true;

            Units.Add(newUnit);

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

            File.WriteAllText(Pathgetter("POSC.json"), output);

            return "0";
        }

        public string CreateSecondaryUnit(string id, string annotation, string name, List<string> quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, List<string> Aliases)
        {
            Formula formulaformula = new Formula
            {
                A = A.ToString(),
                B = B.ToString(),
                C = C.ToString(),
                D = D.ToString()
            };
            ConversionToBaseUnit conversionConversion = new ConversionToBaseUnit
            {
                baseUnit = baseunit,
                Formula = formulaformula
            };

            UOM newUnit = new UOM();

            newUnit.id = id;
            newUnit.annotation = annotation;
            newUnit.Name = name;
            newUnit.QuantityType = quantityType.ToArray();
            newUnit.DimensionalClass = dimensionalclass;
            newUnit.ConversionToBaseUnit = conversionConversion;
            newUnit.Aliases = Aliases;
            newUnit.BaseUnit = false;

            Units.Add(newUnit);

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

            File.WriteAllText(Pathgetter("POSC.json"), output);

            return "0";
        }

        public string EditUnit(string oldName, string propertyToChange, dynamic newValue)
        {
            try
            {
                UOM match = QueryName(oldName);

                try 
                {
                    switch (propertyToChange.ToString().ToLower())
                    {
                        case "id":
                            propertyToChange.ToString().ToLower();
                            match.id = newValue;
                            break;
                        case "name":
                            match.Name = newValue;
                            break;
                        case "annotation":
                            match.annotation = newValue;
                            break;
                        case "quantitytype":
                            AddQuantityType(oldName, newValue);
                            break;
                        case "dimensionalclass":
                            match.DimensionalClass = newValue;
                            break;
                        //case "uom":
                        //    match.SameUnit.uom = newValue;
                        //    break;
                        case "catalogname":
                            match.CatalogName = newValue;
                            break;
                        case "catalogsymbolisexplicit":
                            match.CatalogSymbol.isExplicit = newValue;
                            break;
                        case "catalogsymboltext":
                            match.CatalogSymbol.text = newValue;
                            break;
                        case "isbaseunit":
                            match.BaseUnit = newValue;
                            break;
                        case "baseunit":
                            match.ConversionToBaseUnit.baseUnit = newValue;
                            break;
                        case "a":
                            match.ConversionToBaseUnit.Formula.A = newValue;
                            break;
                        case "b":
                            match.ConversionToBaseUnit.Formula.B = newValue;
                            break;
                        case "c":
                            match.ConversionToBaseUnit.Formula.C = newValue;
                            break;
                        case "d":
                            match.ConversionToBaseUnit.Formula.D = newValue;
                            break;
                        default:
                            throw new Exception("Invalid propertyToChange value");
                    } 
                }
                catch (NullReferenceException)
                {
                    throw new Exception("Unit does not have this property");
                }

                string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

                File.WriteAllText(Pathgetter("POSC.json"), output);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            return "0";
        }

        public string DeleteUnit(string id)
        {
            try
            {
                UOM match = QueryName(id);

                Units.Remove(match);

                string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

                File.WriteAllText(Pathgetter("POSC.json"), output);
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            return "0";
        }

        private bool hasQuantityType(UOM unit, string quantityType)
        {
            string quantityString = "none";
            if (unit.QuantityType != null)
            {
                quantityString = unit.QuantityType.ToString();
            }
            //QuantityType is array
            try
            {
                JArray quantityJArray = (JArray)JsonConvert.DeserializeObject(quantityString);
                return quantityJArray.Any(t => t.Value<string>() == quantityType);
            }
            //QuantityType is object
            catch (JsonReaderException)
            {
                return (quantityString == quantityType);
            }
        }

        public string AddQuantityType(string unitName, string quantityTypeName)
        {
            try
            {
                UOM match = QueryName(unitName);

                string QuantityTypeString = match.QuantityType.ToString();

                try
                {
                    JArray QuantityTypeJArray = (JArray)JsonConvert.DeserializeObject(QuantityTypeString);
                    QuantityTypeJArray.Add(quantityTypeName);
                    match.QuantityType = QuantityTypeJArray;
                }
                catch(JsonReaderException)
                {
                    List<string>QuantityTypeArray = new List<string>() {QuantityTypeString, quantityTypeName};
                    match.QuantityType = QuantityTypeArray;
                }

                string output = JsonConvert.SerializeObject(Units, Formatting.Indented);
                File.WriteAllText(Pathgetter("POSC.json"), output);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            return "0";
        }

        public string RemoveQuantityType(string unitName, string quantityTypeName)
        {
            try
            {
                UOM match = QueryName(unitName);

                if (hasQuantityType(match, quantityTypeName))
                {
                    string QuantityTypeString = match.QuantityType.ToString();

                    try
                    {
                        JArray QuantityTypeJArray = (JArray)JsonConvert.DeserializeObject(QuantityTypeString);
                        QuantityTypeJArray.Where(i => (string)i == quantityTypeName).ToList().ForEach(i => i.Remove());

                        match.QuantityType = QuantityTypeJArray;
                        string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

                        File.WriteAllText(Pathgetter("POSC.json"), output);
                }
                    catch (JsonReaderException e) 
                    {
                        throw new NullReferenceException("Can not remove a units last quantity type");

                    }
                }
                else
                {
                    throw new InvalidOperationException("The unit does not have this quantity type");
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            return "0";
        }

        public List<string> ReadUomFromQuantityClass(string quantityClass)
        {
            List<string> output = new List<string>();

            //Check each unit for spesefied quantityClassName

            List<UOM> houseOnes = Units.FindAll(unit => unit.QuantityType != null && unit.QuantityType.ToString().Contains(quantityClass)).ToList(); 

            foreach (UOM unit in houseOnes)
            {
                
                
                output.Add(ReadUom(unit));
            }

            return output;
        }

            public List<string> ReadDimension(string symbol)
        {
            try
            {
                Dimension match = QueryDimension(symbol);
                try
                {
                    List<string> output = new List<string>() { match.Symbol.ToString(), match.Definition, match.SIUnit };
                    return output;
                }
                catch (NullReferenceException)
                {
                    throw new Exception("This dimension is missing parameters");
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }
        public List<string> ReadAllQuantityClass()
        {
            List<string> output = new List<string>();

            //Check each unit for spesefied quantityClassName

            List<UOM> houseOnes = Units.FindAll(unit => unit.QuantityType != null).ToList();


          

            foreach (UOM unit in houseOnes)
            {

                if (unit.QuantityType.ToString().Contains(","))
                {

                    //var flatten = unit.QuantityType.ToString().Split("[").Split(",").Split("\r\n").ToList();
                    //var flatten = Regex.Replace(unit.QuantityType.ToString(), "[\\[,\\]\"]", "").ToList();
                    var flatten = Regex.Split(unit.QuantityType.ToString(), @"[\[,\r\n"" \t]+|[^ ]")
                        .Where(s => !string.IsNullOrEmpty(s))
                        .ToList();

                    output.AddRange(flatten);
                }
                else
                {
                    output.Add(unit.QuantityType.ToString());
                }

            }
            
                
            output = output.Distinct().ToList();
            output.Sort();
            
            return output;
        }


        public List<List<string>> ReadDimensions()
        {
            List<List<string>> output = new List<List<string>>();

            foreach (var dimension in Dimensions)
            {
                List<string> dimensionList = new List<string>()
                    {
                        dimension.Symbol,
                        dimension.Definition,
                        dimension.SIUnit
                    };

                output.Add(dimensionList);

            }
            return output;
        }

        public List<string> ReadAliases(string input)
        {
            List<string> output = new List<string>();
            try
            {
                output = QueryName(input).Aliases;
            }
            catch (InvalidOperationException)
            {
                output = QueryUOM(input).Aliases;
            }
            if (output == null)
            {
                throw new NullReferenceException("Unit with this name or uom has no aliases.");
            }
            return output;
        }

        public List<string> ReadQuantityType()
        {
            List<string> output = new List<string>();

            return output;
        }

        public List<string> ReadQuantityClasses()
        {
            throw new NotImplementedException();
        }

        public class CatalogSymbol
        {
            public string isExplicit { get; set; }
            public string text { get; set; }
        }

        public class ConversionToBaseUnit
        {
            public string baseUnit { get; set; }
            public string Factor { get; set; }
            public Fraction Fraction { get; set; }
            public Formula Formula { get; set; }
        }

        public class Formula
        {
            public string A { get; set; }
            public string B { get; set; }
            public string C { get; set; }
            public string D { get; set; }
        }

        public class Fraction
        {
            public string Numerator { get; set; }
            public string Denominator { get; set; }
        }

        public class UOM
        {
            public string id { get; set; }
            public string annotation { get; set; }
            public string Name { get; set; }
            public object QuantityType { get; set; }
            public string DimensionalClass { get; set; }
            public object SameUnit { get; set; }
            public string CatalogName { get; set; }
            public CatalogSymbol CatalogSymbol { get; set; }
            public object BaseUnit { get; set; }
            public string Deprecated { get; set; }
            public List<string> Aliases { get; set; }
            public ConversionToBaseUnit ConversionToBaseUnit { get; set; }
        }

        public class Dimension
        {
            public string Symbol { get; set; }
            public string Definition { get; set; }
            public string SIUnit { get; set; }
        }


    }//end GroupParser

}//end namespace Docmanager