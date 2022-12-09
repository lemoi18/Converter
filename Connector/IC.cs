using Docmanager;

namespace Connector
{
    public interface IC
    {

         double Value { get; set; }
         string Unit { get; set; }
         string Annotation { get; set; }
        public IDocmanager docmanager { get; set; }


        public List<string> Convert(double value, string unit, string annotation);

    }
}
