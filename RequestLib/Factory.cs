namespace RequestLib
{
    public static class RequestFactory
    {


        public static IRequests CreateRequestsFactory(string name)
        {
            IRequests requests = null;

             if(name.ToUpper() == "REQUEST")
                requests = new Request();

            return requests;
        }




    }



}