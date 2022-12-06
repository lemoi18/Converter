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

        public string CreateBaseUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string Aliases)
        {
            throw new NotImplementedException();
        }

        public string CreateQualityclass(string name, string baseunit)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            //docmanager.CreateQuantityClass(string name, string baseunit);
            return name;

        }

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string Aliases)
        {
            docmanager = DocFactory.CreateDocmanager("Test");
            //docmanager.CreateSecondaryUnit(id, annotation, name, quantityType, dimensionalclass, uom, baseunit, A, B, C, D, Aliases);//Aliases needs to be string
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
            throw new NotImplementedException();
        }

        public string EditUOM(string oldName, string keyToChange, dynamic newValue)
        {
            throw new NotImplementedException();
        }

        public string[] GetQualityclass(string description)
        {
            throw new NotImplementedException();
        }

        public string[] GetUnit(string description)
        {
            throw new NotImplementedException();
        }

        public string[] GetUnitdimension(string description)
        {
            throw new NotImplementedException();
        }

        public string[] ListAlias(string uom)
        {
            throw new NotImplementedException();
        }

        public string[] ListKeys(string unitName)
        {
            throw new NotImplementedException();
        }

        public string[] ListQualityclass()
        {
            throw new NotImplementedException();
        }

        public List<string[]> ListUnitdimentions()
        {
            throw new NotImplementedException();
        }

        public List<string[]> ListUnits()
        {
            throw new NotImplementedException();
        }

        public string RemoveQualityclass(string unit, string name)
        {
            throw new NotImplementedException();
        }
    }
}
