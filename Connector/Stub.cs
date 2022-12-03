

using Docmanager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Connector
{
    
    internal class Stub : IC
    {
        public Tuple<double, string, string> BaseToConvert(double value, string unitFrom, string unitTo)
        {

            IDocmanager docmanager;
            docmanager = DocFactory.CreateDocmanager("Test");


            string[] strings = docmanager.GetUnit("cm");

            double y = value;
            double a = 0;
            double b = 0.01;
            double c = 1;
            double d = 0;
            double res = 0;
            string uom = strings[0];
            string annotation = strings[1];

            try
            {
                res = (a - c * y) / (d * y - b);
            }
            catch (Exception)
            {

                throw;
            }

            return Tuple.Create(res, uom, annotation);
        }

        public Tuple<double, string, string> ConverterWrapper(double value, string unitFrom, string unitTo)

        {
            bool Isbase = true;
            Tuple<double, string, string> My_Tuple2 = new Tuple<double, string, string>(value, unitFrom, unitTo);

            My_Tuple2 = ConvertToBase(My_Tuple2.Item1, My_Tuple2.Item2, My_Tuple2.Item3);


            if (My_Tuple2.Item2.ToLower() == unitTo)
            {
                Tuple<double, string, string> Edited = new Tuple<double, string, string>(My_Tuple2.Item1, My_Tuple2.Item2, My_Tuple2.Item3);

                Console.WriteLine(WriteToConsole(Edited));
                return Edited;

            }
            else
            {
                My_Tuple2 = BaseToConvert(My_Tuple2.Item1, My_Tuple2.Item2, My_Tuple2.Item3);
                Console.WriteLine(WriteToConsole(My_Tuple2));
                return My_Tuple2;

            }



        }

        public Tuple<double, string, string> ConvertToBase(double value, string unitFrom, string unitTo)
        {

            IDocmanager docmanager;
            docmanager = DocFactory.CreateDocmanager("Test");
            string[] From = docmanager.GetUnit("cm");
            string[] To = docmanager.GetUnit("m");

            double x = value;
            double a = double.Parse(From[2]);
            double b = double.Parse(From[3]);
            double c = double.Parse(From[4]);
            double d = double.Parse(From[5]);
            double res = 0;
            string uom = To[0];
            string annotation = To[1];

            try
            {
                res = (a + b * x) / (c + d * x);
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
