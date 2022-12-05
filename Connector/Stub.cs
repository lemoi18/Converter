

using Docmanager;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace Connector
{
    
    internal class Stub : IC
    {
        public Tuple<double, string, string> BaseToConvert(double value, string unitTo)
        {

            IDocmanager docmanager;
            docmanager = DocFactory.CreateDocmanager("Test");

            double y = value;
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            double res = 0;
            docmanager.ReadConversion(unitTo, ref A, ref B, ref C, ref D);

            string uom = unitTo;
            string annotation = docmanager.ReadAnnotation(unitTo);

            try
            {
                res = (A - C * y) / (D * y - B);
            }
            catch (Exception)
            {

                throw;
            }

            return Tuple.Create(res, uom, annotation);
        }

        public Tuple<double, string, string> ConverterWrapper(double value, string unitFrom, string unitTo)

        {

            IDocmanager docmanager;
            docmanager = DocFactory.CreateDocmanager("Test");

            

            Tuple<double, string, string> My_Tuple2 = new Tuple<double, string, string>(value, unitFrom, unitTo);

            Tuple<double, string, string> My_Tuple1 = new Tuple<double, string, string>(value, unitFrom, unitTo);

            if (docmanager.IsBase(unitFrom))
            {
                My_Tuple2 = BaseToConvert(My_Tuple1.Item1, unitTo);
                Console.WriteLine(WriteToConsole(My_Tuple2));
                return My_Tuple2;

            }
            else
            {

                My_Tuple1 = ConvertToBase(My_Tuple2.Item1, My_Tuple2.Item2);

                if (docmanager.ReadAnnotation(unitTo) == My_Tuple1.Item2)
                {
                    Tuple<double, string, string> Edited = new Tuple<double, string, string>(My_Tuple1.Item1, My_Tuple1.Item2, My_Tuple1.Item3);

                    Console.WriteLine(WriteToConsole(Edited));
                    return Edited;

                }
                else
                {
                    My_Tuple2 = BaseToConvert(My_Tuple1.Item1, unitTo);
                    Console.WriteLine(WriteToConsole(My_Tuple2));
                    return My_Tuple2;

                }
            }



        }

        public Tuple<double, string, string> ConvertToBase(double value, string unitFrom)
        {

            IDocmanager docmanager;
            docmanager = DocFactory.CreateDocmanager("Test");
            
          

            double x = value;
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            double res = 0;
            docmanager.ReadConversion(unitFrom, ref A, ref B, ref C, ref D);


            string uom = unitFrom;
            string annotation = docmanager.ReadAnnotation(unitFrom);
            string base_annotation = docmanager.ReadIsBase(unitFrom);
            string Base = docmanager.NameOfBaseUnit(base_annotation);

            try
            {
                res = (A + B * x) / (C + D * x);
            }
            catch (Exception)
            {

                throw;
            }

            return Tuple.Create(res, base_annotation, Base);
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
