using RequestLib;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Webmanager.WebREST.Models;

namespace Webmanager.WebREST.Services;

public static class ConvertService
{
    
    static IRequests request = RequestFactory.CreateRequestsFactory("REQUEST");



    public static Converted Add(Converts c)
    {
       
        Tuple<double, string, string> CON = new Tuple<double, string, string>(c.Value, c.Unit1.Replace('&', ' '), c.Unit2.Replace('&', ' '));
        List<string> UN = request.Convert(CON.Item1, CON.Item2, CON.Item3);
        Converted COND = new Converted { Value = double.Parse(UN[0]), Uom = UN[1], Annotation = UN[2] };
        return COND;

    }


}