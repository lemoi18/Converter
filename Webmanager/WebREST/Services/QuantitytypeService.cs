
using RequestLib;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class QuantitytypeService
{
    static List<Quantitytype> Quantitytypes { get; }
    static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");







    public static List<Quantitytype> GetAll() => QT();
    public static List<Quantityclass>? Get(string name) => QC(name);

    public static List<Quantityclass> QC(string name) {
        string newname = name.Replace('&', ' ');
        Console.WriteLine(newname);
        List<string> UN = request.GetQualityclass(newname);

        List<Quantityclass> Quantityclasss = new List<Quantityclass>
        {

        };
        foreach (string element in UN)
        {
            Quantityclasss.Add(new Quantityclass
            {
                Unit = element,
            });
        }
        return Quantityclasss; 
    }
    public static List<Quantitytype> QT()
    {
        List<string> UN = request.ListQualityclass();

        List<Quantitytype> Quantitytypes = new List<Quantitytype>
        {

        };
        foreach (string element in UN)
        {
            Quantitytypes.Add(new Quantitytype
            {
                Name = element,
            });
        }
        return Quantitytypes;
    }
    public static void Add(QuantityA qc)
    {
        string ADD = request.AddQualityclass( qc.Unit.Replace('&', ' '), qc.Name.Replace('&', ' '));
        
    }

    public static void Update(string Unit, string name)
    {
        string EDIT = request.RemoveQualityclass(Unit, name);
    }


}