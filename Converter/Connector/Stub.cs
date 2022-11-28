using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Connector
{
    internal class Stub : IC
    {
        public Tuple<double, string, string> BaseToConvert(double value, string unitFrom, string unitTo)
        {
            double y = value;
            double a = 0;
            double b = 0.01;
            double c = 1;
            double d = 0;
            double res = 0;
            string uom = "cm";
            string annotation = "Centimeter";

            try
            {
                res = (a - (c * y)) / ((d * y)- b);
            }
            catch (Exception)
            {

                throw;
            }

            return Tuple.Create(res, uom, annotation);
        }

        public Tuple<double, string, string> ConvertToBase(double value, string unitFrom, string unitTo)
        {
            double x = value;
            double a = 0;
            double b = 0.001;
            double c = 1;
            double d = 0;
            double res = 0;
            string uom = "m";
            string annotation = "Meter";

            try
            {
                res = (a + (b * x)) / (c + (d * x));
            }
            catch (Exception)
            {

                throw;
            }

            return Tuple.Create(res, uom, annotation);
        }

        public string WriteToConsole(Tuple<double, string, string> tuple)
        {

           

            // string creation using string.Format method
            string str = string.Format("{0}  {1}" +
                         " {2}", tuple.Item1.ToString(), tuple.Item2, tuple.Item3);
            



            return str + "\n";

        }
    }
}
