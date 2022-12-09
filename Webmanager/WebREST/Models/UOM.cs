namespace Webmanager.WebREST.Models;


    public class UOM
    {
        public string Id { get; set; }
        public string Annotation { get; set; }
        public string Name { get; set; }
        public string Quantitytype { get; set; }
        public string Dimensionalclass { get; set; }
        public string Baseunit { get; set; }
        public string Uom { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public string Aliases { get; set; }
    }

    public class UOM_Update
    {
        public string Change { get; set; }
        public dynamic Newname { get; set; }

    }
