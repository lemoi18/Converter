using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Docmanager
{
    internal class DocStub : IDocmanager
    {
        public string _name;
        public string _SI;
        public double _A;
        public double _B;
        public double _C;
        public double _D;


        public void AddUnit(string unitName)
        {
            throw new NotImplementedException();
        }

        public int CreateUnit(string name, string si, double[] value)
        {
            throw new NotImplementedException();
        }

        public void DeleteGroup(string name)
        {
            throw new NotImplementedException();
        }

        public int DeleteUnit(string name)
        {
            throw new NotImplementedException();
        }

        public int EditGroup(string? newName, string baseUnit)
        {
            throw new NotImplementedException();
        }

        public int EditUnit(string? newName, string? si, double[]? value)
        {
            throw new NotImplementedException();
        }

        public Unit GetUnit(string name)
        {
            return new Unit(name, "m", 0.0, 100.0, 1.0, 0.0);
        }

        public List<Group> ListGroups()
        {
            throw new NotImplementedException();
        }

        public string[] ListUnits()
        {
            throw new NotImplementedException();
        }

        public Group ReadGroup(string name)
        {
            throw new NotImplementedException();
        }

        public void RemoveUnit(string name)
        {
            throw new NotImplementedException();
        }

       
    }

}
