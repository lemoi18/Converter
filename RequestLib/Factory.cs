using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RequestLib
{
    public static class RequestFactory
    {


        public static IRequests CreateRequestsFactory(string name)
        {
            IRequests requests = null;

            if (name.ToUpper() == "TEST")
                requests = new RequestStub();
            
            return requests;
        }




    }



}