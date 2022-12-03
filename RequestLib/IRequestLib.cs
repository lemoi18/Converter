namespace RequestLib
{
    public interface IRequests
    {
        public IRequests CreateRequest() { return new RequestStub(); }
        public string[] GetUnitdimension(string description);
        public List<string[]> ListUnitdimentions();
        public List<string[]> GetQualityclass(string description);
        public string[] ListQualityclass();
        public string[] ListAlias(string uom);
        public Tuple<double, string, string> Convert(double number, string uom1, string uom2);
        public void AddQualityclass(string name, string uom);
        public void CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public void CreateQualityclass(string name, string baseunit);
        public void EditQualityclass(string baseunit, string name, string newname);
        public void EditUOM(string old_id, string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public void DeleteUOM(string id);
        public void DeleteQualityclass(string baseunit, string name);
        public void RemoveQualityclass(string unit, string name);

    }
}