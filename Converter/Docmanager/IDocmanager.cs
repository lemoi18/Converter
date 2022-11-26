using Docmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Converter.Docmanager
{
    public interface IDocmanager
    {

        public int CreateUnit(string name, string si, double[] value);
       

        public int EditUnit( string? newName, string? si, double[]? value);



        public int DeleteUnit(string name);


        public string[] ListUnits();


        public IDocmanager GetUnit();



        public void EditGroup(string? newName,string baseUnit, string[]? units);



        public void DeleteGroup(string name);



        public void AddUnit(string unitName);



        public void RemoveUnit(string name);



        public string[] ListGroups();



        public IDocmanager ReadGroup();
        

    }

}
