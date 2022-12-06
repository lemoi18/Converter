using Connector;
using Docmanager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLib
{
    internal class Request : IRequests
    {

        IDocmanager docmanager;



        public string AddQualityclass(string name, string uom)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            docmanager.AddQuantityType(name, uom);
            
            return name;

        }

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {
            IC converter;
            // Test is only mm to cm
            converter = ConnectorFactory.CreateConnectorFactory("CONNECTOR");
            Tuple<double, string, string> My_Tuple1 = new Tuple<double, string, string>(number, uom1, uom2);

            converter.ConverterWrapper(My_Tuple1.Item1, My_Tuple1.Item2, My_Tuple1.Item3);
            return My_Tuple1;

        }

        public string CreateBaseUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string aliases)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            var alias = aliases.Split(',').ToList();
            var quantity = quantityType.Split(',').ToList();

            docmanager.CreateBaseUnit(id, annotation, name, quantity, dimensionalclass, uom, alias);//Aliases needs to be string
            return id;
        }

        public string CreateQualityclass(string name, string baseunit)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            
            //docmanager.CreateQuantityClass(string name, string baseunit);
            return name;

        }

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string aliases)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            var alias = aliases.Split(',').ToList();
            var quantity = quantityType.Split(',').ToList();

            docmanager.CreateSecondaryUnit(id, annotation, name, quantity, dimensionalclass, uom, baseunit, A, B, C, D, alias);//Aliases needs to be string
            return id;
        }

        public string DeleteQualityclass(string name)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            //docmanager.DeleteQantityClass(name);
            return name;
        }

        public string DeleteUOM(string name)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            docmanager.DeleteUnit(name);
            return name;

        }

        public string EditQualityclass(string name, string newname)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            //docmanager.EditQuantityclass(name, newname);
            return name;
        }

        public string EditUOM(string oldName, string keyToChange, dynamic newValue)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            docmanager.EditUnit(oldName,keyToChange, newValue);
            return newValue;
        }

        public List<string> GetQualityclass(string description)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            List<string> result = new List<string>();


            foreach (var quantity in docmanager.ReadUomFromQuantityClass(description))
            {
                result.Add(quantity);
            }
            return result;

                
            //throw new NotImplementedException();

        }

        public List<string> GetUnit(string description)
        {
            throw new NotImplementedException();
        }

        public List<string> GetUnitdimension(string description)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            List<string> result = new List<string>();

            foreach (var dim in docmanager.ReadDimension(description))
            {
                result.Add(dim.ToString());
            }

            return result;
        }

        public List<string> ListAlias(string uom)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            List<string> result = new List<string>();
            
            foreach (var alias in docmanager.ReadAliases(uom))
            {
                result.Add(alias.ToString());
            }

              return result;
        }

        public List<string> ListKeys(string unitName)
        {
            //docmanager = DocFactory.CreateDocmanager("Test");
            //List<string> result = new List<string>();

            //foreach (var keys in docmanager.Listkeys(unitName))
            //{
            //  result.Add(keys.ToString());
            //   }

            //    return result;
            throw new NotImplementedException();

        }

        public List<string> ListQualityclass()
        {
            //  docmanager = DocFactory.CreateDocmanager("Test");
            //  docmanager.ReadAliases(uom);
            //  List<string> result = new List<string>();
            //  
            //  foreach (var alias in docmanager.ReadAliases(uom))
            //  {
            //      result.Add(alias.ToString());
            //  }
            //  
            //  return result;

            throw new NotImplementedException();

        }

        public List<List<string>> ListUnitdimentions()
        {
            //  docmanager = DocFactory.CreateDocmanager("Test");
            //
            //  List<List<string>> dimensionString = new List<List<string>>();
            //
            //  foreach (var dim in docmanager.Read)
            //  {
            //      dimensionString.Add(dim);
            //
            //  }
            //
            //  return result;

            throw new NotImplementedException();

        }

        public List<List<string>> ListUnits()
        {
            //  docmanager = DocFactory.CreateDocmanager("Test");
            //  docmanager.ReadAliases(uom);
            //  List<string> result = new List<string>();
            //
            //  foreach (var alias in docmanager.ReadAliases(uom))
            //  {
            //      result.Add(alias.ToString());
            //  }
            //
            //  return result; 
            throw new NotImplementedException();

        }

        public string RemoveQualityclass(string unit, string name)
        {
            throw new NotImplementedException();
        }
    }
}
