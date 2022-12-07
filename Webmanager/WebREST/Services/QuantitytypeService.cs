
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
        string ADD = request.AddQualityclass(qc.Name, qc.Unit);
        
    }

    public static void Delete(string Name)
    {
        
        string DEL = request.DeleteQualityclass(Name);
        
    }

    public static void Update(string Name, Quantitytype qt)
    {
        string EDIT = request.EditQualityclass(Name, qt.Name);
    }
}