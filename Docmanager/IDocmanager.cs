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
        struct Unit
        {
            public string _name;
            public string _SI;
            public double _A;
            public double _B;
            public double _C;
            public double _D;
        }

        public int CreateUnit(string name, string si, double[] value);


        public int EditUnit(string? newName, string? si, double[]? value);



        public int DeleteUnit(string name);


        public string[] ListUnits();


        public Unit GetUnit(string name);



        public int EditGroup(string? newName, string baseUnit);



        public void DeleteGroup(string name);



        public void AddUnit(string unitName);



        public void RemoveUnit(string name);



        public List<Group> ListGroups();



        public Group ReadGroup(string name);


    }

}
