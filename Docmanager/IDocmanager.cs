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
        public string ReadAnnotation(string unitName);
        public string ReadIsBase(string unitName);
        public string NameOfBaseUnit(string annotationName);
        public bool IsBase(string unitName);


        public void ReadConversion(string unitName, ref double A, ref double B, ref double C, ref double D);
        public void CreateUOM(string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public void EditUOM(string old_id, string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit);
        public void DeleteUOM(string id);
        public void RemoveQualityType(string unitName, string quantityTypeName);

    }

}
