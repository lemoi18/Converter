namespace RequestLib
{
    internal class RequestStub : IRequests
    {



       

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {
            throw new NotImplementedException();
        }

       


       

        public string[] GetUnitdimension(string description)
        {
            return new string[] { "T", "Time", "Second", "s" };
        }

        public string[] ListAlias(string uom)
        {
            return new string[] { "Meter", "Metros", "Metri" };
        }

        public string[] ListQualityclass()
        {
            return new string[] { "per length", "per area", "per volume" };
        }

        public List<string[]> ListUnitdimentions()
        {
            string[] strings = { "L", "Length", "Meter", "m" };
            string[] strings2 = { "M", "Mass", "Kilogram", "kg" };
            string[] strings3 = { "T", "Time", "Second", "s" };
            return new List<string[]> { strings, strings2, strings3 };
        }

        public string[] ListKeys(string unitName)
        {
            return new string[] { "annotation", "Name", "QuantityType" };
        }



        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string alias, string baseunit, string uom, string A, string B, string C, string D) //
        {
            throw new NotImplementedException();
    }

    public string CreateQualityclass(string name, string baseunit)
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

        public string AddQualityclass(string name, string uom)
        {
            throw new NotImplementedException();
        }

       

        public string[] GetUnit(string description)
        {
            throw new NotImplementedException();
        }

        public List<string[]> ListUnits()
        {
            throw new NotImplementedException();
        }

        public string DeleteQualityclass(string name)
        {
            throw new NotImplementedException();
        }

        public string[] GetQualityclass(string description)
        {
            return new string[] { "cm", "mm", "m" };

        }
    }
}
