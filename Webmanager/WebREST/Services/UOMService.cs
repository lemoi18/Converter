
using RequestLib;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Xml.Linq;
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
        
        string ADD = request.CreateSecondaryUnit(Uom.Id.Replace('&', ' '), Uom.Annotation.Replace('&', ' '), Uom.Name.Replace('&', ' '), 
            Uom.Quantitytype.Replace('&', ' '), Uom.Dimensionalclass.Replace('&', ' '), Uom.Baseunit.Replace('&', ' '),
            Uom.Uom.Replace('&', ' '), Uom.A, Uom.B, Uom.C, Uom.D, Uom.Aliases.Replace('&', ' '));
        UOMs.Add(Uom);
    }

    public static void Delete(string name)
    {
        string DEL = request.DeleteUOM(name.Replace('&', ' '));
        
    }

    public static void Update(string Name, UOM_Update Uom)
    {
        

        if (Uom.Change.ToUpper() == "id".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "id", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "annotation".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "annotation", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "name".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "name", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "quantitytype".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "quantity", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "dimensionalclass".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "dimensionalclass", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "baseunit".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "baseunit", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "uom".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "uom", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "a".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "a", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "b".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "b", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "c".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "c", Uom.Newname.ToString().Replace('&', ' ')); }
        if (Uom.Change.ToUpper() == "d".ToUpper()) { string NO = request.EditUOM(Name.Replace('&', ' '), "d", Uom.Newname.ToString().Replace('&', ' ')); }


        
    }
}