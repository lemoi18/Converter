
using System.Collections.Generic;
using System.Linq.Expressions;
using RESTTEST.Models;

namespace RESTTEST.Services;

public static class UnitDimensionService
{
	static List<UnitDimension> UnitDimensions { get; }
	static int nextId = 3;
	static string[] l1 = { "helve", "cuck", "ost", "taco" };
	static string[] l2 = { "helve1", "cuck", "ost", "taco" };
	static List<string[]> UN = new List<string[]> { l1, l2 };


	static UnitDimensionService()
	{
		UnitDimensions = new List<UnitDimension>
			{
				new UnitDimension { Name = "name2", Symbol = "symbol", SI = "SI", SI_symbol = "SI_symbol" },
				new UnitDimension { Name = "name1", Symbol = "symbol", SI = "SI", SI_symbol = "SI_symbol" },

			};
		foreach (string[] element in UN)
		{
			UnitDimensions.Add(new UnitDimension { Name = element[0], Symbol = element[1], SI = element[2], SI_symbol = element[3] });
		}
	}

	public static List<UnitDimension> GetAll() => UnitDimensions;

	public static UnitDimension? Get(string name) => UnitDimensions.FirstOrDefault(p => p.Name == name);

	public static void Add(UnitDimension unitDimension)
	{
		
		UnitDimensions.Add(unitDimension);
	}

	public static void Delete(string name)
	{
		var unitdimension = Get(name);
		if (unitdimension is null)
			return;

		UnitDimensions.Remove(unitdimension);
	}

	public static void Update(UnitDimension unitdimension)
	{
		var index = UnitDimensions.FindIndex(p => p.Name == unitdimension.Name);
		if (index == -1)
			return;

		UnitDimensions[index] = unitdimension;
	}
}