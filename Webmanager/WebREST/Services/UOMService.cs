
using RequestLib;
using System.Collections.Generic;
using System.Linq.Expressions;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class UOMService
{
    static List<UOM> UOMs { get; }
    static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");


    static UOMService()
    {
        List<List<string>> UN = request.ListUnits();
        UOMs = new List<UOM>
        {

        };
        foreach (List<string> element in UN)
        {
            UOMs.Add(new UOM { Id = element[0], Annotation = element[1], Name = element[2], Quantitytype = element[3], 
            Dimensionalclass = element[4], Baseunit = element[5], Uom = element[6], A = Convert.ToDouble(element[7]), B = Convert.ToDouble(element[8]), C = Convert.ToDouble(element[9]), D = Convert.ToDouble(element[10]), Aliases = element[11]  });;
        }
    }

    public static List<UOM> GetAll() => UOMs;

    public static UOM? Get(string name) => UOMs.FirstOrDefault(p => p.Name == name);

    public static void Add(UOM Uom)
    {
        
        string ADD = request.CreateSecondaryUnit(Uom.Id, Uom.Annotation, Uom.Name, 
            Uom.Quantitytype, Uom.Dimensionalclass, Uom.Baseunit, Uom.Uom, Uom.A, Uom.B, Uom.C, Uom.D, Uom.Aliases);
        UOMs.Add(Uom);
    }

    public static void Delete(string name)
    {
        var Uom = Get(name);
        if (Uom is null)
            return;
        string DEL = request.DeleteUOM(name);
        UOMs.Remove(Uom);
    }

    public static void Update(string Name, UOM Uom)
    {
        var index = UOMs.FindIndex(p => p.Name == Name);
        if (index == -1)
            return;
        //if (Uom.Id != null) { string NO = request.EditUOM(UOMs[index].Id, "id", Uom.Id); }
        //if (Uom.Annotation != null) { string NO = request.EditUOM(UOMs[index].Annotation, "annotation", Uom.Annotation); }
        //if (Uom.Name != null) { string NO = request.EditUOM(UOMs[index].Name, "name", Uom.Name); }
        //if (Uom.Quantitytype != null) { string NO = request.EditUOM(UOMs[index].Quantitytype, "quantity", Uom.Quantitytype); }
        //if (Uom.Dimensionalclass != null) { string NO = request.EditUOM(UOMs[index].Dimensionalclass, "dimensionalclass", Uom.Dimensionalclass); }
        //if (Uom.Baseunit != null) { string NO = request.EditUOM(UOMs[index].Baseunit, "baseunit", Uom.Baseunit); }
        //if (Uom.Uom != null) { string NO = request.EditUOM(UOMs[index].Uom, "uom", Uom.Uom); }
        //if (Uom.A != null) { string NO = request.EditUOM(UOMs[index].A.ToString(), "a", Uom.A); }
        //if (Uom.B != null) { string NO = request.EditUOM(UOMs[index].B.ToString(), "b", Uom.B); }
        //if (Uom.C != null) { string NO = request.EditUOM(UOMs[index].C.ToString(), "c", Uom.C); }
        //if (Uom.D != null) { string NO = request.EditUOM(UOMs[index].D.ToString(), "d", Uom.D); }

        UOMs[index] = Uom;
    }
}