using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

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

        public string[] GetUnit(string name)
        {

            if (name.ToLower() == "cm")
                return new string[]
                {
                        "cm",
                        "Centimeter",
                        (0.0).ToString(),
                        (0.01).ToString(),
                        (1).ToString(),
                        (0).ToString()
                };
            else if (name.ToLower() == "m")
                {




                return new string[]
                {
                        "m",
                        "Meter",
                        (0.0).ToString(),
                        (1.0).ToString(),
                        (0.0).ToString(),
                        (1.0).ToString()
                };               
                 }

            else return new string[] {name};
            
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
