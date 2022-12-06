using Connector;
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
        public string AddQualityclass(string name, string uom)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string Aliases)
        {
            throw new NotImplementedException();
        }

        public string DeleteQualityclass(string name)
        {
            throw new NotImplementedException();
        }

        public string DeleteUOM(string name)
        {
            throw new NotImplementedException();
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
