///////////////////////////////////////////////////////////
//  Factory.cs
//  Implementation of the Class Factory
//  Generated by Enterprise Architect
//  Created on:      26-nov-2022 12:13:25
//  Original author: Skole
///////////////////////////////////////////////////////////

namespace Docmanager
{



    public static class DocFactory
    {

        public static IDocmanager CreateDocmanager(string name)
        {


            IDocmanager psu = null;

            //if (name.ToUpper() == "UNIT")
            //psu = new Unit();
            if (name.ToUpper() == "TEST")
                psu = new Docmanager();
            return psu;
        }



    }//end Factory

}//end namespace Docmanager