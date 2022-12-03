using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Docmanager
{
    public interface IDocmanager
    {
        public string ReadAnnotation(string unitName);

    }

}
