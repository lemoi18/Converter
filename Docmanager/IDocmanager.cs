using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static Docmanager.Docmanager;

namespace Docmanager
{
    public interface IDocmanager
    {
        public bool NameExists(string unitName);
        public List<string> ReadProperties(string unitName);
        public string ReadUOM(string unitName);
        public string ReadAnnotation(string unitName);
        public string ReadIsBase(string unitName);
        public string NameOfBaseUnit(string annotationName);
        public bool IsBase(string unitName);
        public string ReadConversion(string unitName, ref double A, ref double B, ref double C, ref double D);
        public string CreateUnit(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public string EditUnit(string oldName, string keyToChange, dynamic newValue);
        public string DeleteUnit(string id);
        public string AddQuantityType(string unitName, string quantityTypeName);
        public string RemoveQuantityType(string unitName, string quantityTypeName);

    }

}
