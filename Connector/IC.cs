using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Connector
{
    public interface IC
    {

        public Tuple<double, string, string> ConverterWrapper(double value, string unitFrom, string unitTo);
        public Tuple<double, string, string> ConvertToBase(double value, string unitFrom);

        public Tuple<double, string, string> BaseToConvert(double value, string unitTo);

        public string WriteToConsole(Tuple<double, string, string> tuple);
    }
}
