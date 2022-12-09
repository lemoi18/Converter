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

        public Request()
        {
            IC converters;
            converters = ConnectorFactory.CreateConnectorFactory("CONNECTOR");
            converter = converters;

            IDocmanager docmanagers;
            docmanagers = DocFactory.CreateDocmanager("Test");

            docmanager = docmanagers;
            
        }

        public IC converter { get; set; }
        public IDocmanager docmanager { get; set; }

        public string AddQualityclass(string unit, string name)
        {
            return docmanager.AddQuantityType(unit, name);
        }

        private bool canConvert(double number, string uom1, string uom2)
        {
            bool unit1IsBase = docmanager.IsBase(uom1);
            bool unit2IsBase = docmanager.IsBase(uom2);


            if (unit1IsBase)
            {

                if (uom1 != docmanager.ReadBaseUnit(uom2))
                {
                    return false;
                }   
            }
            else if (unit2IsBase)
            {
                if (uom2 != docmanager.ReadBaseUnit(uom1))
                {
                    return false;
                }
            }
            else
            {
                if (docmanager.ReadBaseUnit(uom1) != docmanager.ReadBaseUnit(uom2))
                {
                    return false;
                }
            }

            return true;
        }
        public List<string> Convert(double number, string uom1, string uom2)
        {
            if (uom1 == uom2)
            {
                return new List<string>() { number.ToString() + uom1 };
            }

            if (canConvert(number, uom1, uom2))
            {

                
                return converter.GetConvertion(number, uom1.Trim(), uom2.Trim());
            }
            else
            {
                throw new Exception("Units dont have the same base unit.");
            }
        }
            

        

        public string CreateBaseUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string aliases)
        {
            var alias = aliases.Split(',').ToList();
            var quantity = quantityType.Split(',').ToList();

            docmanager.CreateBaseUnit(id, annotation, name, quantity, dimensionalclass, uom, alias);//Aliases needs to be string
            return id;
        }

        public string CreateQualityclass(string name, string baseunit)
        {
            
            //docmanager.CreateQuantityClass(string name, string baseunit);
            return name;

        }

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string aliases)
        {
            var alias = aliases.Split(',').ToList();
            var quantity = quantityType.Split(',').ToList();
            Console.WriteLine("CreateUNIT");
            docmanager.CreateSecondaryUnit(id, annotation, name, quantity, dimensionalclass, uom, baseunit, A, B, C, D, alias);//Aliases needs to be string
            return id;
        }

        

        public string DeleteUOM(string name)
        {
            docmanager.DeleteUnit(name);
            return name;

        }

       

        public string EditUOM(string oldName, string keyToChange, dynamic newValue)
        {
            docmanager.EditUnit(oldName,keyToChange, newValue);
            return newValue;
        }

        public List<string> GetQualityclass(string description)
        {
            
            List<string> result = new List<string>();


            foreach (var quantity in docmanager.ReadAllQuantityClass())
            {
                result.Add(quantity);
            }
            return result;


        }

       

        public List<string> GetUnitdimension(string description)
        {
            
            return docmanager.ReadDimension(description);
        }

        public List<string> ListAlias(string uom)
        {
            
            List<string> result = new List<string>();
            
            foreach (var alias in docmanager.ReadAliases(uom))
            {
                result.Add(alias.ToString());
            }

              return result;
        }

        public List<string> ReadProp(string unitName)
        {
            
           
            return docmanager.ReadProperties(unitName);
        }

        public List<string> ListQualityclass()
        {
             
            
            return docmanager.ReadAllQuantityClass();

        }

        public List<List<string>> ListUnitdimentions()
        {
              
            return docmanager.ReadDimensions();
        }


        

        public string RemoveQualityclass(string unit, string name)
        {
            
            return docmanager.RemoveQuantityType(unit, name);
        }

        public List<string> ListNames()
        {

            return docmanager.ReadNames();
        }

        public string RemoveAlias(string unitName, string aliasName)
        {
            return docmanager.RemoveAlias(unitName, aliasName);
        }

        public string AddAlias(string unitName, string aliasName)
        {

            return docmanager.AddAlias(unitName, aliasName);

        }
    }
}
