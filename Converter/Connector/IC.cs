using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Connector
{
    public interface IC
    {
        public void Convert(double value, string unitFrom, string unitTo);

        
    }
}
