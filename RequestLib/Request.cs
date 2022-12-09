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
            IDocmanager docmanagers;
            docmanagers = DocFactory.CreateDocmanager("Test");

            docmanager = docmanagers;
        }

        public IDocmanager docmanager { get; set; }

        public string AddQualityclass(string unit, string name)
        {

            return docmanager.AddQuantityType(unit, name);
            

        }

        public  List<string> Convert(double number, string uom1, string uom2)
        {
            IC converter;
            converter = ConnectorFactory.CreateConnectorFactory("CONNECTOR");
            

            return  converter.Convert(number, uom1.Trim(), uom2.Trim()); 

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


            foreach (var quantity in docmanager.ReadUOMsFromQuantityType(description))
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
    }
}
