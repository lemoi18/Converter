namespace Docmanager
{
    public interface IDocmanager
    {

        public bool NameExists(string unitName);
        public List<string> ReadProperties(string unitName);
        public string ReadUOM(string unitName);
        public string ReadBaseUnit(string unitName);
        public string ReadAnnotation(string unitName);
        public string ReadIsBase(string unitName);
        public string ReadUnitName(string annotationName);
        public bool IsBase(string unitName);
        public string ReadConversion(string unitName, ref double A, ref double B, ref double C, ref double D);
        public string CreateUnit(string id, string annotation, string name, string quantityType, string dimensionalclass);
        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D);
        public string EditUnit(string oldName, string keyToChange, dynamic newValue);
        public string DeleteUnit(string id);
        public string AddQuantityType(string unitName, string quantityTypeName);
        public string RemoveQuantityType(string unitName, string quantityTypeName);
        public List<string[]> ReadDimensions();
        public string[] ReadDimension(string symbol);
        public List<string> ReadAliases(string unitName);
    }

}
