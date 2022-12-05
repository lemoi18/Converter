namespace RequestLib
{
    internal class RequestStub : IRequests
    {



        public void AddQualityclass(string name, string uom)
        {
            throw new NotImplementedException();
        }

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {
            throw new NotImplementedException();
        }

        public void CreateQualityclass(string name, string baseunit)
        {
            throw new NotImplementedException();
        }

        public void CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit)
        {
            throw new NotImplementedException();
        }

        public void DeleteQualityclass(string baseunit, string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteUOM(string id)
        {
            throw new NotImplementedException();
        }

        public void EditQualityclass(string baseunit, string name, string newname)
        {
            throw new NotImplementedException();
        }

        public void EditUOM(string old_id, string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit)
        {
            throw new NotImplementedException();
        }

        public List<string[]> GetQualityclass(string description)
        {
            string[] strings = { "kilogram/metre fourth" };
            string[] strings2 = { "kilograms/metre" };
            string[] strings3 = { "radians/metre" };
            return new List<string[]> { strings, strings2, strings3 };
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

        public void RemoveQualityclass(string unit, string name)
        {
            throw new NotImplementedException();
        }
    }
}
