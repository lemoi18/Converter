namespace Docmanager
{
    public interface IDocmanager
    {
        public bool NameExists(string unitName);
        public List<String> ReadUom(string unitName);
        public string ReadAnnotation(string unitName);
        public string ReadIsBase(string unitName);
        public string ReadName(string uom);
        public bool IsBase(string unitName);
        public string ReadConversion(string unitName, ref double A, ref double B, ref double C, ref double D);
        public string CreateBaseUnit(string id, string annotation, string name, List<string> quantityType, string dimensionalclass, string uom, List<string> Aliases);
        public string CreateSecondaryUnit(string id, string annotation, string name, List<string> quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, List<string> Aliases);
        public List<string> ReadProperties(string unitName);
        public string EditUnit(string oldName, string porpToChange, dynamic newValue);
        public string DeleteUnit(string id);
        public string AddQuantityType(string unitName, string quantityTypeName);
        public string RemoveQuantityType(string unitName, string quantityTypeName);
        public Dictionary<string, List<string>> ReadQuantityTypes();
        public List<List<string>> ReadDimensions();
        public List<string> ReadDimension(string symbol);
        public List<string> ReadAliases(string input);
        public List<string> ReadUomFromQuantityClass(string quantityClass);
        public List<string> ReadAllQuantityClass();

    }

}
