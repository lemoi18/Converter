using RequestLib;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class QuantityclassService
{

    static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");



    public static void Add(string Unit, Quantity q)
    {
        string ADD = request.CreateQualityclass(q.Name, Unit);

    }

    public static void Update(string Unit, Quantity q)
    {
        string EDIT = request.RemoveQualityclass(Unit, q.Name);
    }
}