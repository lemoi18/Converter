///////////////////////////////////////////////////////////
//  GroupParser.cs
//  Implementation of the Class GroupParser
//  Generated by Enterprise Architect
//  Created on:      26-nov-2022 12:13:28
//  Original author: Lars
///////////////////////////////////////////////////////////

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Docmanager
{
    internal class Docmanager : IDocmanager
    {

        List<UOM> Units;
        List<Dimension> ListDimensions;
        Dictionary<string, Dimension> Dimensions;

        public Docmanager()
        {
            Units = JsonConvert.DeserializeObject<List<UOM>>(File.ReadAllText(Pathgetter("POSC.json")));
            ListDimensions = JsonConvert.DeserializeObject<List<Dimension>>(File.ReadAllText(Pathgetter("UnitDimensions.json")));
            Dimensions = ListDimensions.ToDictionary(d => d.Symbol, d => d);

        }

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

        public List<string> ReadNames()
        {
            List<string> output = new List<string>();
            foreach (UOM unit in Units)
            {
                output.Add(unit.Name);
            }

            output.Sort();
            output.RemoveAll(x => x == null);
            return output;
        }

        private UOM QueryUOM(string uom)
        {
            try
            {


                UOM houseOnes = Units.First(unit => ReadUom(unit).Contains(uom));


                return houseOnes;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no unit with this uom");
            }
        }

        private Dimension QueryDimension(string symbol)
        {
            if (Dimensions.ContainsKey(symbol))
            {
                return Dimensions[symbol];
            }
            else
            {
                return Dimensions["none"];
            }
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
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            bool test;
            try
            {
                test = (bool)match.BaseUnit;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("This unit does not have BaseUnit property");
            }

            List<string> output = new List<string>();

            if (test)
            {
                output = new List<string>()
                    {
                        "ID",
                        "Annotation",
                        "Name",
                        "QuantityType",
                        "DimensionalClass",
                        "uom",
                        "IsBaseUnit"
                    };
            }
            else
            {
                output = new List<string>()
                    {
                        "ID",
                        "Annotation",
                        "Name",
                        "QuantityType",
                        "DimensionalClass",
                        "uom",
                        "IsBaseUnit",
                        "A",
                        "B",
                        "C",
                        "D"
                    };
            }

            return output;

        }

        public string ReadAnnotation(string uom)
        {
            UOM match = new UOM();

            try
            {
                match = QueryUOM(uom);
            }
            catch (InvalidOperationException)
            {
                throw new Exception("This unit is not in file");
            }

            try
            {
                return match.annotation;
            }
            catch (NullReferenceException)
            {
                throw new Exception("This unit is not in file");
            }
        }

        private List<string> ReadUom(UOM unit)
        {
            string sameUnitString;
            try
            {
                sameUnitString = unit.SameUnit.ToString();
            }
            catch (NullReferenceException)
            {
                return new List<string> { null };
            }

            List<string> output = new List<string>();

            if (unit.SameUnit.GetType() == typeof(JArray))
            {
                JArray sameUnitObject = (JArray)JsonConvert.DeserializeObject(sameUnitString);
                foreach (var obj in sameUnitObject)
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

        public List<string> ReadUom(string unitName)
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

        public bool IsBase(string uom)
        {
            // Retrieve the UOM object that corresponds to the input UOM
            var match = QueryUOM(uom);

            // Use the null coalescing operator to provide a default value for the BaseUnit property if it is null
            return match.BaseUnit != null;
        }

        public string ReadName(string uom)
        {
            UOM match = new UOM();
            try
            {
                match = QueryUOM(uom);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            try
            {
                return match.Name;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("This unit does not have a name");
            }
        }

        public string ReadIsBase(string unitName)
        {
            UOM match = new UOM();

            try
            {
                match = QueryUOM(unitName);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("There is no unti with this name or uom");
            }

            try
            {
                return match.ConversionToBaseUnit.baseUnit;
            }
            catch (NullReferenceException)
            {
                return "This unit does not have ConversionToBaseUnit.baseUnit";
            }

        }

        public string ReadBaseUnit(string uom)
        {
            UOM match = new UOM();
            try
            {
                match = QueryUOM(uom);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            return match.ConversionToBaseUnit.baseUnit;
        }

        public string ReadConversion(string uom, ref double A, ref double B, ref double C, ref double D)
        {
            UOM match = new UOM();

            try
            {
                match = QueryUOM(uom);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            A = B = C = D = 0;
            CultureInfo culture = CultureInfo.GetCultureInfo("en-US");

            if (match.ConversionToBaseUnit != null || match.BaseUnit != null)
            {
                C = 1;
                B = 1;
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Formula != null && match.ConversionToBaseUnit.Formula.A != null)
            {
                A = double.Parse(match.ConversionToBaseUnit.Formula.A, culture);
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Formula != null && match.ConversionToBaseUnit.Formula.B != null)
            {
                B = double.Parse(match.ConversionToBaseUnit.Formula.B, culture);
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Formula != null && match.ConversionToBaseUnit.Formula.C != null)
            {
                C = double.Parse(match.ConversionToBaseUnit.Formula.C, culture);
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Formula != null && match.ConversionToBaseUnit.Formula.D != null)
            {
                D = double.Parse(match.ConversionToBaseUnit.Formula.D, culture);
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Factor != null)
            {
                B = double.Parse(match.ConversionToBaseUnit.Factor, culture);
            }
            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Fraction != null && match.ConversionToBaseUnit.Fraction.Numerator != null)
            {
                B = double.Parse(match.ConversionToBaseUnit.Fraction.Numerator, culture);
            }

            if (match.ConversionToBaseUnit != null && match.ConversionToBaseUnit.Fraction != null && match.ConversionToBaseUnit.Fraction.Denominator != null)
            {
                C = double.Parse(match.ConversionToBaseUnit.Fraction.Denominator, culture);
            }

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

        public string EditUnit(string unitName, string propertyToChange, dynamic newValue)
        {
            try
            {
                UOM match = QueryName(unitName);

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
                            AddQuantityType(unitName, newValue);
                            break;
                        case "dimensionalclass":
                            match.DimensionalClass = newValue;
                            break;
                        case "uom":
                            JObject SameUnitJObject = new JObject
                            {
                                ["uom"] = newValue,
                            };
                            match.SameUnit = SameUnitJObject;
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
            return "Edited " + unitName;
        }

        public string DeleteUnit(string unitName)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            Units.Remove(match);

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);

            File.WriteAllText(Pathgetter("POSC.json"), output);

            return "Deleted" + unitName;
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
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            List<string> quantityList = ReadQuantityClass(match);
            string QuantityString = match.QuantityType.ToString();

            foreach (UOM unit in Units)
            {
                if (unit.QuantityType != null)
                {
                    if (unit != match && quantityList.Intersect(ReadQuantityClass(unit)).Any() && match.DimensionalClass != unit.DimensionalClass)
                    {
                        throw new Exception("It is only allowed to add UOMs from the same unit dimention.");
                    }
                }
            }

            try
            {
                JArray QuantityTypeJArray = (JArray)JsonConvert.DeserializeObject(QuantityString);
                QuantityTypeJArray.Add(quantityTypeName);
                match.QuantityType = QuantityTypeJArray;
            }
            catch (JsonReaderException)
            {
                List<string> QuantityTypeArray = new List<string>() { QuantityString, quantityTypeName };
                match.QuantityType = QuantityTypeArray;
            }

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);
            File.WriteAllText(Pathgetter("POSC.json"), output);

            return "Added Quantity Type to " + quantityTypeName;
        }

        public string RemoveQuantityType(string unitName, string quantityTypeName)
        {
            UOM match = new UOM();
            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

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
                catch (JsonReaderException)
                {
                    throw new NullReferenceException("Can not remove a units last quantity type");

                }
            }
            else
            {
                throw new InvalidOperationException("The unit does not have this quantity type");
            }


            return "Removed " + quantityTypeName + "from" + unitName;
        }

        public List<string> ReadUOMsFromQuantityType(string quantityClass)
        {
            List<string> output = new List<string>();


            foreach (UOM unit in Units)
            {
                List<string> quantitys = ReadQuantityClass(unit);
                if (quantitys != null) 
                {
                    foreach (string quantity in quantitys)
                    {
                        if (quantity == quantityClass) {
                            foreach (string uom in ReadUom(unit))
                            {
                                output.Add(uom);
                            }
                        }
                    }
                }
            }

            output = output.Distinct().ToList();
            output.Sort();
            return output;
        }

        public List<string> ReadDimension(string symbol)
        {
            Dimension match = QueryDimension(symbol);
            try
            {
                match = QueryDimension(symbol);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

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

        private List<string> ReadQuantityClass(UOM unit)
        {
            List<string> output = new List<string>();

            if (unit.QuantityType == null)
                return null;
            if (unit.QuantityType.ToString().Contains(","))
            {

                var pattern = @"""[^""]*""";
                var matches = Regex.Matches(unit.QuantityType.ToString(), pattern);

                // Output the extracted values
                foreach (Match match in matches)
                {
                    var values = matches.Select(m => m.Value.Trim('"')).ToList();
                    output.AddRange(values);
                }
            }
            else
            {
                if (unit.QuantityType != null)
                {
                    output.Add(unit.QuantityType.ToString());
                }
            }

            return output;
        }

        public List<string> ReadAllQuantityClass()
            {
                List<string> output = new List<string>();

                //Check each unit for spesefied quantityClassName

                List<UOM> houseOnes = Units.FindAll(unit => unit.QuantityType != null).ToList();


                foreach (UOM unit in houseOnes)
                {

                    if (unit.QuantityType.ToString().Contains("["))
                    {

                        var pattern = @"""[^""]*""";
                        var matches = Regex.Matches(unit.QuantityType.ToString(), pattern);

                        // Output the extracted values
                        foreach (Match match in matches)
                        {
                            var values = matches.Select(m => m.Value.Trim('"')).ToList();
                            output.AddRange(values);
                        }

                    }
                    else
                    {
                        if (unit.QuantityType != null)
                        {
                            output.Add(unit.QuantityType.ToString());
                        }
                    }

                }


                output = output.Distinct().ToList();
                output.Sort();

                return output;
            }


        

        public List<List<string>> ReadDimensions()
        {
            List<List<string>> output = new List<List<string>>();

            foreach (var dimension in ListDimensions)
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

        private string DimensionSymbolsToDefinition(string symbols)
        {
            List<string> symbolsList = new List<string>();
            Dictionary<char, string> conversions = new Dictionary<char, string>
            {
                { '1', "1" },
                { '/', "/" }
            };
            string whitespace = "";

            foreach (char symbol in symbols)
            {
                string definition;
                if (conversions.TryGetValue(symbol, out definition))
                {
                    symbolsList.Add(whitespace + definition);
                }
                else if (Char.IsDigit(symbol))
                {
                    symbolsList.Add("^" + symbol);
                }
                else
                {
                    Dimension dimension = QueryDimension(symbol.ToString());
                    if (dimension.Symbol.ToString() == "none")
                    {
                        symbolsList.Add(whitespace + "none");
                    }
                    else
                    {
                        symbolsList.Add(whitespace + dimension.Definition);
                    }
                }
                whitespace = " ";
            }

            return string.Join("", symbolsList);
        }

        public string ReadUOMAnnotation(string uom)
        {
            UOM match = new UOM();
            try
            {
                match = QueryUOM(uom);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            return DimensionSymbolsToDefinition(match.DimensionalClass);
        }

        public List<string> ReadAliases(string uom)
        {
            List<string> output = new List<string>();
            try
            {
                output = QueryUOM(uom).Aliases;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            if (output == null)
            {
                throw new NullReferenceException("Unit with this name or uom has no aliases.");
            }
            return output;
        }

        public string AddAlias(string unitName, string aliasName)
        {
            UOM match = new UOM();

            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            match.Aliases ??= new List<string>();
            match.Aliases.Add(aliasName);

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);
            File.WriteAllText(Pathgetter("POSC.json"), output);

            return "Added alias " + aliasName + " to " + unitName;
        }

        public string RemoveAlias(string unitName, string aliasName)
        {
            UOM match = new UOM();

            try
            {
                match = QueryName(unitName);
            }
            catch (InvalidOperationException)
            {
                throw;
            }

            bool aliasFound = match.Aliases.Remove(aliasName);

            string output = JsonConvert.SerializeObject(Units, Formatting.Indented);
            File.WriteAllText(Pathgetter("POSC.json"), output);

            if (aliasFound)
                return "Removed alias " + aliasName + " from " + unitName;
            return "Could not remove alias " + aliasName + " from " + unitName + ". Are you shure " + unitName + " has this alias?";
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