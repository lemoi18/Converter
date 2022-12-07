namespace Webmanager.WebREST.Models;

public class Converts
{
    public double Value { get; set; }
    public string Unit1 { get; set; }
    public string Unit2 { get; set; }

}

public class Converted
{
    public double Value { get; set; }
    public string Uom { get; set; }
    public string Annotation { get; set; }
}