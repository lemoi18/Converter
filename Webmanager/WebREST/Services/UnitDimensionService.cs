
using RequestLib;
using System.Collections.Generic;
using System.Linq.Expressions;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class UnitDimensionService
{
	static List<UnitDimension> UnitDimensions { get; }
	static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");
	
	
	static UnitDimensionService()
	{
		List<List<string>> UN = request.ListUnitdimentions();
		UnitDimensions = new List<UnitDimension>
			{
				
			};
		foreach (List<string> element in UN)
		{
			UnitDimensions.Add(new UnitDimension { Definition = element[1], Symbol = element[0], SI = element[2] });
		}
	}

	public static List<UnitDimension> GetAll() => UnitDimensions;

	public static UnitDimension Get(string symbol) => UnitDimensions.FirstOrDefault(p => p.Symbol == symbol);
    //  Console.WriteLine(symbol);
    //List<string> UD = request.GetUnitdimension(symbol);
    //  Console.WriteLine(UD[0]);
    //UnitDimension unitDimension = new UnitDimension { Symbol = UD[0], Definition = UD[1], SI = UD[2] };
    //return unitDimension;

    public static void Add(UnitDimension unitDimension)
	{
		
		UnitDimensions.Add(unitDimension);
	}

	public static void Delete(string symbol)
	{
		var unitdimension = Get(symbol);
		if (unitdimension is null)
			return;

		UnitDimensions.Remove(unitdimension);
	}

	public static void Update(string Symbol, UnitDimension unitdimension)
	{
		var index = UnitDimensions.FindIndex(p => p.Symbol == Symbol);
		if (index == -1)
			return;

		UnitDimensions[index] = unitdimension;
	}
}