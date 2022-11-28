


using Connector;
using Converter.Connector;
using Converter.Docmanager;




IC converter;
// Test is only mm to cm
converter = ConnectorFactory.CreateConnectorFactory("Test");
Tuple<double,string, string> t = converter.ConvertToBase(10,"mm","cm");
t = converter.BaseToConvert(t.Item1, t.Item2, t.Item3);
Console.WriteLine(converter.WriteToConsole(t));

