using RequestManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Webmanager
{
    public interface IRequests
    {
        public string[] GetUnitdimension(string description);
        public List<string[]> ListUnitdimentions();
        public List<string[]> GetQualityclass(string description); 
        public string[] ListQualityclass(); 
        public string[] ListAlias(string uom);
        public Tuple<double, string, string> Convert(double number, string uom1, string uom2);
        public string AddQualityclass(string name, string uom); 
        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public string CreateQualityclass(string name, string baseunit);
        public string EditQualityclass(string baseunit, string name, string newname);
        public string EditUOM(string oldName, string keyToChange, dynamic newValue);
        public string DeleteUOM(string id);
        public string DeleteQualityclass(string baseunit, string name);
        public string RemoveQualityclass(string unit, string name);



    }
}
