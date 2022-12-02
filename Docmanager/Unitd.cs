///////////////////////////////////////////////////////////
//  Unit.cs
//  Implementation of the Class Unit
//  Generated by Enterprise Architect
//  Created on:      27-nov-2022 14:10:02
//  Original author: Skole
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Docmanager
{
    public class Unit : IDocmanager {

		public string _name;
		public string _SI;
		public double _A;
		public double _B;
		public double _C;
		public double _D;

		public Unit()
		{
		}

		public Unit(string name, string sI, double a, double b, double c, double d)
		{
			_name = name;
			_SI = sI;
			_A = a;
			_B = b;
			_C = c;
			_D = d;
		}

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

		public Unit GetUnit()
		{
			throw new NotImplementedException();
		}

		public Unit GetUnit(string name)
		{
			throw new NotImplementedException();
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

		
	}//end Unit

}//end namespace Docmanager