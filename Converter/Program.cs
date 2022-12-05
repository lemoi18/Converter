


using Connector;
using WebServer;
using Converter.Connector;
using Converter.Docmanager;
using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using RequestManager;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Versioning;
using System.Numerics;



IC converter;
// Test is only mm to cm
converter = ConnectorFactory.CreateConnectorFactory("Test");
Tuple<double,string, string> t = converter.ConvertToBase(10,"mm","cm");
// Create a Http server and start listening for incoming connections
WebServer.HttpServer.Server();
t = converter.BaseToConvert(t.Item1, t.Item2, t.Item3);
Console.WriteLine(converter.WriteToConsole(t));

