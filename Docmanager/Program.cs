using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

double A = 404;
double B = 404;
double C = 404;
double D = 404;

docmanager.ReadConversion("klx", ref A, ref B, ref C, ref D);

Console.WriteLine("A: {0}\nB: {1}\nC: {2}\nD: {3}", A, B, C, D);
