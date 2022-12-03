using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connector
{
    internal class Conn : IC
    {
        public Tuple<double, string, string> BaseToConvert(double value, string unitFrom, string unitTo)
        {
            throw new NotImplementedException();
        }

        public Tuple<double, string, string> ConverterWrapper(double value, string unitFrom, string unitTo)
        {
            throw new NotImplementedException();
        }

        public Tuple<double, string, string> ConvertToBase(double value, string unitFrom, string unitTo)
        {
            throw new NotImplementedException();
        }

        public string WriteToConsole(Tuple<double, string, string> tuple)
        {
            throw new NotImplementedException();
        }
    }
}
