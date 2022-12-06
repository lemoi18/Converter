﻿namespace RequestLib
{
    public interface IRequests
    {

        // Get a spesific Unit Dimension [Symbol,Description,Name, SI Symbol]
        public List<string> GetUnitdimension(string description); //

        // Get ALL Unit Dimensions[Symbol,Description,Name, SI Symbol]
        public List<string[]> ListUnitdimentions(); //
        // Get Quantity Classes Given Name of Unit
        public List<string> GetQualityclass(string description);

        // Get a Given Unit
        public List<string> GetUnit(string description); //

        // List All Units
        public List<string[]> ListUnits(); //
        // List All Quantiy Classes
        public List<string> ListQualityclass(); //

        // List Aliases Given UOM
        public List<string> ListAlias(string uom);
        public Tuple<double, string, string> Convert(double number, string uom1, string uom2);

        // List Available Attributes to Edit
        public List<string> ListKeys(string unitName);

        //Create Unit
        public string CreateBaseUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string Aliases);
        public string CreateSecondaryUnit(string id, string annotation, string name, string quantityType, string dimensionalclass, string uom, string baseunit, double A, double B, double C, double D, string Aliases);
        //Create Quantity type
        public string CreateQualityclass(string name, string baseunit);
        // Edit Unit
        public string EditUOM(string oldName, string keyToChange, dynamic newValue); //
        // Edit Quantity Type(Name of)
        public string EditQualityclass(string name, string newname);

        // Delete Unit or Quantity Type
        public string DeleteUOM(string name); //
        public string DeleteQualityclass(string name);

        // Add or Remove a Quantity type from a Unit
        public string AddQualityclass(string name, string uom);
        public string RemoveQualityclass(string unit, string name);


    }
}