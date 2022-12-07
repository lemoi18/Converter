using RequestLib;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class AliasService
{
    static List<Alias> Aliass { get; }
    static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");


    public static List<Alias>? Get(string name) => AL(name);

    public static List<Alias> AL(string name)
    {
        string newname = name.Replace('&', ' ');
        Console.WriteLine(newname);
        List<string> UN = request.ListAlias(newname);

        List<Alias> Aliass = new List<Alias>
        {

        };
        foreach (string element in UN)
        {
            Aliass.Add(new Alias
            {
                Name = element,
            });
        }
        return Aliass;
    }
  
    public static void Add(string Unit, string Alias)
    {
        //string ADD = request.AddAlias(Unit, Alias);
        Console.WriteLine("ADD ALIAS");

    }

    public static void Update(string Unit, string Alias)
    {
        //string EDIT = request.RemoveAlias(Unit, Alias);
        Console.WriteLine("DELETE ALIAS");
    }
}