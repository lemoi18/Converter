using Docmanager;
using static Docmanager.Docmanager;
using System.Xml.Linq;

IDocmanager docmanager;
docmanager = DocFactory.CreateDocmanager("Test");

double A = 404;
double B = 404;
double C = 404;
double D = 404;

docmanager.EditUnit("inverse henry", "iD", "test");

