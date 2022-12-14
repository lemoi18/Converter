using Docmanager;
using System;

namespace Connector
{
    internal class Conn : IC
    {

        public double Value { get; set; }
        public string Unit { get; set; }
        public string Annotation { get; set; }
        public IDocmanager docmanager { get;  set; }


        public Conn()
        {
            IDocmanager docmanagers;
            docmanagers = DocFactory.CreateDocmanager("Test");

            docmanager = docmanagers;
            
        }



        public List<string> GetConvertion(double value, string unitFrom, string unitTo)
        {
            var converter = new Conn();

            converter =  converter.ConverterWrapper(value, unitFrom, unitTo);

            List<string> result = new List<string>();

            
            result.Add(converter.Value.ToString());
            result.Add(converter.Unit);
            result.Add(converter.Annotation);

            return  result;
         
        }


        private Conn BaseToConvert(double value, string unitfrom)
        {
            double y = value;
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            double res = 0;
            docmanager.ReadConversion(unitfrom, ref A, ref B, ref C, ref D);

            string uom = unitfrom;
            string uom_annotation = docmanager.ReadUOMAnnotation(uom);

            try
            {
                res = (A - C * y) / (D * y - B);
            }
            catch (Exception)
            {
                throw;
            }

            var result = new Conn();
            result.Value = res;
            result.Unit = unitfrom;
            result.Annotation = uom_annotation;
            return result;
        }

        private Conn ConverterWrapper(double value, string unitFrom, string unitTo)
        {
            var result = new Conn();

            if (docmanager.IsBase(unitFrom))
            {
                result = BaseToConvert(value, unitTo);
            }
            else
            {
                result = ConvertToBase(value, unitFrom);

                if (result.Unit != unitTo)
                {
                    result = BaseToConvert(value, unitTo);
                }
            }

            return result;
        }
       

        private Conn ConvertToBase(double value, string unitFrom)
        {
            double x = value;
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            double res = 0;

            docmanager.ReadConversion(unitFrom, ref A, ref B, ref C, ref D);

            string base_annotation = docmanager.ReadIsBase(unitFrom);
            string uom_annotation = docmanager.ReadUOMAnnotation(unitFrom);


            try
            {
                res = (A + B * x) / (C + D * x);
            }
            catch (Exception)
            {
                throw;
            }

            var result = new Conn();
            result.Value = res;
            result.Unit = base_annotation;
            result.Annotation = uom_annotation;
            return result;
        }



    }
}
