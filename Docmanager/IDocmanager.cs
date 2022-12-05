using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Docmanager
{
    public interface IDocmanager
    {
        public bool nameExists(string unitName);
        public string ReadUOM(string unitName);
        public string ReadAnnotation(string unitName);
        public string ReadIsBase(string unitName);
        public string NameOfBaseUnit(string annotationName);
        public bool IsBase(string unitName);
        public string ReadConversion(string unitName, ref double A, ref double B, ref double C, ref double D);
        public string CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public string EditUOM(string old_id, string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public string DeleteUOM(string id);
        public string RemoveQualityType(string unitName, string quantityTypeName);

    }

}
