


using Connector;
using Converter.Connector;
using Converter.Docmanager;


Console.WriteLine("hahaha");

IC converter;
IDocmanager docmanager;
double A = 0;
double B = 2;
double C = 2 ;
double D = 0;
string name = "Meter";
string SI = "m";
docmanager = DocFactory.CreatePSU("Test");
converter = ConnectorFactory.CreateConnectorFactory("Test");
docmanager.GetUnit("meter");
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(SI);
Console.WriteLine(name);

converter.Convert(32.2, "mm", "m");

