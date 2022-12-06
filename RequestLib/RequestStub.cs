namespace RequestLib
{
    internal class RequestStub : IRequests
    {



       

        public Tuple<double, string, string> Convert(double number, string uom1, string uom2)
        {
            throw new NotImplementedException();
        }

       


       

        public List<string> GetUnitdimension(string description)
        {
            return new List<string> { "T", "Time", "Second", "s" };
        }

        public List<string> ListAlias(string uom)
        {
            return new List<string> { "Meter", "Metros", "Metri" };
        }

        public List<string> ListQualityclass()
        {
            return new List<string> { "per length", "per area", "per volume" };
        }

        public List<List<string>> ListUnitdimentions()
        {
           
            return new List<List<string>>() { new List<string>() { "L", "Length", "Meter", "m" }, new List<string>() { "M", "Mass", "Kilogram", "kg" } };
        }

        public List<string> ListKeys(string unitName)
        {
            return new List<string> { "annotation", "Name", "QuantityType" };
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

       

        public List<string> GetUnit(string description)
        {
            throw new NotImplementedException();
        }

        public List<List<string>> ListUnits()
        {
            throw new NotImplementedException();
        }

        public string DeleteQualityclass(string name)
        {
            throw new NotImplementedException();
        }

        public List<string> GetQualityclass(string description)
        {
            return new List<string> { "cm", "mm", "m" };

        }

        public string CreateBaseUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string Aliases)
        {
            throw new NotImplementedException();
        }

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, List<string> Aliases)
        {
            throw new NotImplementedException();
        }

      

        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string Aliases)
        {
            throw new NotImplementedException();
        }
    }
}
