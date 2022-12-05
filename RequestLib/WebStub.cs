using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestLib
{
    internal class WebStub : IRequests
    {
        public string AddQualityclass(string name, string uom)
        {
            throw new NotImplementedException();
        }

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {
            throw new NotImplementedException();
        }

        public string CreateQualityclass(string name, string baseunit)
        {
            throw new NotImplementedException();
        }

        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit)
        {
            throw new NotImplementedException();
        }

        public string DeleteQualityclass(string baseunit, string name)
        {
            throw new NotImplementedException();
        }

        public string DeleteUOM(string id)
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

        public List<string[]> GetQualityclass(string description)
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

        public string RemoveQualityclass(string unit, string name)
        {
            throw new NotImplementedException();
        }
    }
}
