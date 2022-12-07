
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
        UOMs.Add(new UOM
        {
            Id = "Id",
            Annotation = "Annotation",
            Name = "Name",
            Quantitytype = "Quantitytype",
            Dimensionalclass = "Dimensionalclass",
            Baseunit = "Baseunit",
            Uom = "Uom",
            A = Convert.ToDouble("0"),
            B = Convert.ToDouble("0"),
            C = Convert.ToDouble("0"),
            D = Convert.ToDouble("0"),
            Aliases = "Aliases"
        });
        //foreach (List<string> element in UN)
        //{
        //    UOMs.Add(new UOM { Id = element[0], Annotation = element[1], Name = element[2], Quantitytype = element[3], 
        //    Dimensionalclass = element[4], Baseunit = element[5], Uom = element[6], A = Convert.ToDouble(element[7]), B = Convert.ToDouble(element[8]), C = Convert.ToDouble(element[9]), D = Convert.ToDouble(element[10]), Aliases = element[11]  });;
        //}
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

    public static void Update(string Name, UOM_Update Uom)
    {
        Console.WriteLine("Up_UNIT1");
        Console.WriteLine(Uom.NewName + " " + Uom.Change );



       
        if (Uom.Change == "id" || Uom.Change == "Id") { string NO = request.EditUOM(Name, "id", Uom.NewName.ToString()); }
        if (Uom.Change == "annotation " || Uom.Change == "Annotation") { string NO = request.EditUOM(Name, "annotation", Uom.NewName.ToString()); }
        if (Uom.Change == "name" || Uom.Change == "Name") { string NO = request.EditUOM(Name, "name", Uom.NewName.ToString()); }
        if (Uom.Change == "quantitytype" || Uom.Change == "Quantitytype") { string NO = request.EditUOM(Name, "quantity", Uom.NewName.ToString()); }
        if (Uom.Change == "dimensionalclass" || Uom.Change == "Dimensionalclass") { string NO = request.EditUOM(Name, "dimensionalclass", Uom.NewName.ToString()); }
        if (Uom.Change == "baseunit" || Uom.Change == "Baseunit") { string NO = request.EditUOM(Name, "baseunit", Uom.NewName.ToString()); }
        if (Uom.Change != "uom" || Uom.Change != "Uom") { string NO = request.EditUOM(Name, "uom", Uom.NewName.ToString()); }
        if (Uom.Change != "a" || Uom.Change != "A") { string NO = request.EditUOM(Name, "a", Uom.NewName.ToString()); }
        if (Uom.Change != "b" || Uom.Change != "B") { string NO = request.EditUOM(Name, "b", Uom.NewName.ToString()); }
        if (Uom.Change != "c" || Uom.Change != "C") { string NO = request.EditUOM(Name, "c", Uom.NewName.ToString()); }
        if (Uom.Change != "d" || Uom.Change != "D") { string NO = request.EditUOM(Name, "d", Uom.NewName.ToString()); }


        
    }
}