namespace RequestLib
{
    public interface IRequests
    {

        public string[] GetUnitdimension(string description); //
        public List<string[]> ListUnitdimentions(); //
        public string[] GetQualityclass(string description);
        public string[] GetUnit(string description); //
        public List<string[]> ListUnits(); //
        public string[] ListQualityclass(); //
        public string[] ListAlias(string uom);
        public Tuple<double, string, string> Convert(double number, string uom1, string uom2);
        public string AddQualityclass(string name, string uom);
        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass,string alias, string baseunit, string uom, string A, string B, string C, string D); //
        public string CreateQualityclass(string name, string baseunit);
        public string EditQualityclass(string name, string newname);
        public string EditUOM(string oldName, string keyToChange, dynamic newValue); //

        public string[] ListKeys(string unitName);

        public string DeleteUOM(string name); //
        public string DeleteQualityclass(string name);
        public string RemoveQualityclass(string unit, string name);


    }
}