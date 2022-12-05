using Converter.Webmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace RequestManager
{
    internal class WebManagere : IRequests
    {
        
        

        public WebManagere CreateWebManager()
        {
            return new WebManagere();
        }
       

        public string[] GetUnitdimension(string description)
        {
            string[] UnitDValue = {"Return value: ", description };
            Console.Write("\n{0}\n", UnitDValue[1]);
            return UnitDValue;
        }

        public List<string[]> ListUnitdimentions()
        {
            string[] L1 = { "Return value: ", "List Unit Dimention", "LIST" };
            string[] L2 = { "Return value: ", "List Unit Dimention", "LIST" };
            List<string[]> arrayList = new List<string[]>()
            {
                L1,
                L2
            };
            Console.Write("\n{0}\n", L1[1]);
            return arrayList;
        }

        public List<string[]> GetQualityclass(string description)
        {
            string[] QualityTValue = { "Return value: ", description };
            string[] L1 = { "Return value: ", "Unit ", "LIST" };
            string[] L2 = { "Return value: ", "Unit ", "LIST" };
            List<string[]> arrayList = new List<string[]>()
            {
                QualityTValue,
                L1,
                L2
            };
            Console.Write("\n{0}\n", QualityTValue[1]);
            return arrayList;
        }

        public string[] ListQualityclass()
        {
            string[] QualityTValue = { "Return value:", "List Quality Types" };
            Console.Write("\n{0}\n", QualityTValue[1]);
            return QualityTValue;
        }

        public string[] ListAlias(string uom)
        {
            string[] AliasValue = { "Return value: {0}" + "cat " + "dog ", uom };
            Console.Write("\n{0}\n", uom);
            return AliasValue;
        }

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {

            Console.Write("Convert {0} from {1} to {2}\n", number, uom1, uom2);

            if (number != 0)
            {
                Tuple<double, string, string> Answare_found = new Tuple<double, string, string>(number, uom1, uom2);
                return Answare_found;
                
            }
            Tuple<double, string, string> Answare = new Tuple<double, string, string>(400, "Wrong", "Format");
            
            return Answare;
        }

        public string AddQualityclass(string name, string uom)
        {
            return "200 ok: " + name + ": " + uom;
        }

        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit)
        {
            return "200 ok: " + id + ": " + annotation + ": " + name + ": " + qualitytype + ": " + dimensionalclass + ": " + baseunit;
        }

        public string CreateQualityclass(string name, string baseunit)
        {
            return "200 ok: " + name + ": " + baseunit;
        }

        public string EditQualityclass(string baseunit, string name, string newname)
        {
            throw new NotImplementedException();
        }

        public string EditUOM(string oldName, string keyToChange, dynamic newValue)
        {
            return "200 ok: " + oldName + ": " + keyToChange + ": " + newValue;
        }

        public string DeleteUOM(string id)
        {
            throw new NotImplementedException();
        }

        public string DeleteQualityclass(string baseunit, string name)
        {
            throw new NotImplementedException();
        }

        public string RemoveQualityclass(string unit, string name)
        {
            throw new NotImplementedException();
        }
        public List<string> GetUnitAttributes(string name)
        { 
            throw new NotImplementedException(); 
        }
    }
}
