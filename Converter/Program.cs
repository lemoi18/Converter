


using Connector;

IC converter;
// Test is only mm to cm
converter = ConnectorFactory.CreateConnectorFactory("CONNECTOR");



converter.ConverterWrapper(1, "millimetres", "centimetre");
//converter.ConverterWrapper(100, "mm", "m");
//converter.ConverterWrapper(1000, "mm", "cm");


//Tuple<double,string, string> t = converter.ConvertToBase(10,"mm","cm");
//t = converter.BaseToConvert(t.Item1, t.Item2, t.Item3);
//Console.WriteLine(converter.WriteToConsole(t));
//Console.WriteLine(converter.ConverterWrapper(t.Item1, t.Item2, t.Item3));



