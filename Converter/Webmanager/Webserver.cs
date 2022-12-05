// Filename:  HttpServer.cs        
// Author:    Benjamin N. Summerton <define-private-public>        
// License:   Unlicense (http://unlicense.org/)

using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Versioning;
using System.Numerics;
using Converter.Webmanager;
using RequestManager;
using Microsoft.VisualBasic;
using PageDataManager;
using System.Configuration;


namespace WebServer
{
    class HttpServer
    {
        public static HttpListener listener;
        public static string url1 = "http://localhost:8000/";
        public static string returns = "Empty";
        public static int requestCount = 0;
        public static string[] Response = Array.Empty<string>();
        public static string pageData = PageDataManager.PageData.pageData_Con;
        

        public static async Task HandleIncomingConnections(string url)
        {
            string url_r = url;
            bool runServer = true;
            IRequests requests;

            requests = new WebManagere();
            
            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (runServer)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                // Print out some info about the request
                Console.WriteLine();
                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);



                // If `shutdown` url requested w/ POST, then shutdown the server after serving the page
                if ((req.HttpMethod == "GET" && req.Url.AbsolutePath != "/favicon.ico"))
                {
                    string Response;
                    string[] urlList = req.Url.AbsolutePath.ToString().Split("/");
                    if (urlList.Length > 20) { break; }
                    if (urlList[1] == "Page")
                    {
                        Response = GetPages(urlList, requests);
                    }
                    else { Response = GetRequests(urlList, requests); }
                    
                    returns = Response;
                    

                }
                if ((req.HttpMethod == "POST" && req.Url.AbsolutePath != "/favicon.ico"))
                {
                    {

                        returns = PostRequests(req.Url.AbsolutePath, requests, ctx);
                    }
                }



                // Write the response info
                string disableSubmit = !runServer ? "disabled" : "";
                byte[] data = Encoding.UTF8.GetBytes(String.Format(pageData, disableSubmit, url_r, returns));
                resp.ContentType = "text/html";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);

                resp.Close();
            }
        }


        public static void Server()
        {
            // Create a Http server and start listening for incoming connections
            listener = new HttpListener();
            listener.Prefixes.Add(url1);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url1);
            // Handle requests
            Task listenTask = HandleIncomingConnections(url1);
            listenTask.GetAwaiter().GetResult();


            // Close the listener
            listener.Close();
        }

        public static string PostRequests(string url, IRequests requests, HttpListenerContext ctx)
        {
            string[] urlList = url.Split("/");
            if (urlList[1] == "Convert")
            {
                using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                {

                    string OutputString = new string(reader.ReadToEnd());
                    OutputString = OutputString.Replace("+", " ");
                    string[] Seperator = { "&", "=" };
                    string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
   
                    string[] PostValues = new string[3];
                    for (int i = 0; i < TempSlice.Length; i += 1)
                    {
                        
                        if (TempSlice[i] == "number")
                        {
                            bool isNumber = double.TryParse(TempSlice[i+1], out double numericValue);
                            if (isNumber == false) { return "Not A Number"; }
                            PostValues[0] = TempSlice[i+1];
                        }
                        if (TempSlice[i] == "uom1")
                        {
                            PostValues[1] = TempSlice[i+1];
                        }
                        if (TempSlice[i] == "uom2")
                        {
                            PostValues[2] = TempSlice[i+1];
                        }
                    }
                    
                    Console.WriteLine("Lenght of message: " + PostValues.Length);
                    double dob = Convert.ToDouble(PostValues[0]);
                    Tuple<double, string, string> Information = requests.Convert(dob, PostValues[1], PostValues[2]);
                    string ConvertReturn = Information.Item1.ToString() + Information.Item2 + Information.Item3;
                    return ConvertReturn;
                }
            }

            if (urlList[1] == "CQC")
            {
                using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                {

                    string OutputString = new string(reader.ReadToEnd());
                    Console.WriteLine(OutputString);
                    OutputString = OutputString.Replace("+", " ");
                    string[] Seperator = { "&", "=" };
                    string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                    string[] PostValues = new string[3];
                    Console.WriteLine(TempSlice[0] + ": " + TempSlice[1] + ": " + TempSlice[2] + ": " + TempSlice[3] + ": " + TempSlice[4] + ": " + TempSlice[5] + ": ");
                    for (int i = 0; i < TempSlice.Length; i += 1)
                    {
                        Console.WriteLine(PostValues[i]);
                        if (TempSlice[i] == "name")
                        {
                            PostValues[0] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "baseunit")
                        {
                            PostValues[1] = TempSlice[i + 1];

                        }

                        Console.WriteLine("Lenght of message: " + PostValues.Length);
                        
                        string Information = requests.CreateQualityclass(PostValues[0], PostValues[1]);
                        return Information;
                    }
                }
            }
            if (urlList[1] == "CUOM")
            {
                using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                {

                    string OutputString = new string(reader.ReadToEnd());
                    OutputString = OutputString.Replace("+", " ");
                    string[] Seperator = { "&", "=" };
                    string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);

                    string[] PostValues = new string[6];
                    for (int i = 0; i < TempSlice.Length; i += 1)
                    {
                        Console.WriteLine(TempSlice[i]);
                        //string id, string annotation, string name, string qualitytype, string dimensionalclass, string baseunit
                        if (TempSlice[i] == "id")
                        {
                            PostValues[0] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "annotation")
                        {
                            PostValues[1] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "name")
                        {
                            PostValues[2] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "qualitytype")
                        {
                            PostValues[3] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "dimensionalclass")
                        {
                            PostValues[4] = TempSlice[i + 1];
                        }
                        if (TempSlice[i] == "baseunit")
                        {
                            PostValues[5] = TempSlice[i + 1];
                        }
                    }

                    Console.WriteLine("Lenght of message: " + PostValues.Length);
                    string Information = requests.CreateUOM(PostValues[0], PostValues[1],
                        PostValues[2], PostValues[3], PostValues[4], PostValues[5]);
                    return Information;
                }
            }


            if (urlList[1] == "Qualityclass")
            {
                using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                {

                    string OutputString = new string(reader.ReadToEnd());
                    Console.WriteLine(OutputString);
                    OutputString = OutputString.Replace( "+", " ");
                    string[] Seperator = { "&", "=" };
                    string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                    string PostValues;
                    for (int i = 0; i < TempSlice.Length; i += 1)
                    {
                        if(TempSlice[i] == "QC") {   
                            PostValues = TempSlice[i+1];
                            List<string[]> Result_QC = requests.GetQualityclass(PostValues);
                            string value = ConvertListArraytoString(Result_QC);
                            return value; 
                        }
                    }
                    
                }
            }
            if (urlList[1] == "Dimension")
            {
                using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                {

                    string OutputString = new string(reader.ReadToEnd());
                    Console.WriteLine(OutputString);
                    OutputString = OutputString.Replace("+", " ");
                    string[] Seperator = { "&", "=" };
                    string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                    string PostValues;
                    for (int i = 0; i < TempSlice.Length; i += 1)
                    {
                        if (TempSlice[i] == "UD")
                        {
                            PostValues = TempSlice[i + 1];
                            string[] Result_UD = requests.GetUnitdimension(PostValues);
                            string value = ConvertArraytoString(Result_UD);
                            return value;
                        }
                    }

                }
            }
            if (urlList[1] == "List")
            {
                if (urlList[2] == "Alias")
                {
                    using (System.IO.StreamReader reader = new StreamReader(ctx.Request.InputStream, ctx.Request.ContentEncoding))
                    {

                        string OutputString = new string(reader.ReadToEnd());
                        Console.WriteLine(OutputString);
                        OutputString = OutputString.Replace("+", " ");
                        string[] Seperator = { "&", "=" };
                        string[] TempSlice = OutputString.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
                        string PostValues;
                        for (int i = 0; i < TempSlice.Length; i += 1)
                        {
                            if (TempSlice[i] == "U")
                            {
                                PostValues = TempSlice[i + 1];
                                string[] Result_LA = requests.ListAlias(PostValues);
                                string value = ConvertArraytoString(Result_LA);
                                return value;
                            }
                        }

                    }
                }
            }
            return "Not Found";
        }
        public static string GetRequests(string[] urlList, IRequests requests)
        {            
            
            if (urlList[1] == "List")
            {
                Console.Write("List {0}\n", urlList[2]);
                if (urlList[2] == "Dimensions") { List<string[]> Result_pre = requests.ListUnitdimentions(); string Result_LD = ConvertListArraytoString(Result_pre); return Result_LD; }
                if (urlList[2] == "Qualityclass") { string[] Result_pre2 = requests.ListQualityclass(); string Result_LQC = ConvertArraytoString(Result_pre2); return Result_LQC; }

            }
            string Result = "Not found";
            return Result;
        }

        public static string GetPages(string[] urlList, IRequests requests)
        {
            if (urlList[2] == "LUD")
            {
                pageData = PageDataManager.PageData.pageData_LUD;
                return "List Unit Dimensions Page";
            }
            if (urlList[2] == "CO")
            {
                pageData = PageDataManager.PageData.pageData_Con;
                return "Converter Page";
            }
            if (urlList[2] == "UD")
            {
                pageData = PageDataManager.PageData.pageData_UD;
                return "Unit Dimension Page";
            }
            if (urlList[2] == "LA")
            {
                pageData = PageDataManager.PageData.pageData_LA;
                return "List Alias Page";
            }
            if (urlList[2] == "LQC")
            {
                pageData = PageDataManager.PageData.pageData_LQC;
                return "List Quality class Page";
            }

            if (urlList[2] == "QC")
            {
                pageData = PageDataManager.PageData.pageData_QC;
                return "Quality class Page";
            }

            //CUOM, CQC, AQC
            //EUOM, EQC, RQC
            //DUOM, DQC

            if (urlList[2] == "CUOM")
            {
                pageData = PageDataManager.PageData.pageData_CUOM;
                return "Create UOM Page";
            }
            if (urlList[2] == "CQC")
            {
                pageData = PageDataManager.PageData.pageData_CQC;
                return "Create Quality class Page";
            }
            if (urlList[2] == "AQC")
            {
                pageData = PageDataManager.PageData.pageData_AQC;
                return "Add Quality class Page";
            }
            if (urlList[2] == "EUOM")
            {
                pageData = PageDataManager.PageData.pageData_EUOM;
                return "Edit UOM Page";
            }
            if (urlList[2] == "EQC")
            {
                pageData = PageDataManager.PageData.pageData_EQC;
                return "Edit Quality class Page";
            }
            if (urlList[2] == "RQC")
            {
                pageData = PageDataManager.PageData.pageData_RQC;
                return "Remove Quality class Page";
            }
            if (urlList[2] == "DUOM")
            {
                pageData = PageDataManager.PageData.pageData_DUOM;
                return "Delete UOM Page";
            }
            if (urlList[2] == "DQC")
            {
                pageData = PageDataManager.PageData.pageData_DQC;
                return "Delete Quality class Page";
            }


            string Result = "Not found";
            return Result;
        }

        public static string ConvertArraytoString(string[] array)
        {
            string value = "";
            foreach (string element in array)
            {
                value += element;
                value += "<br>";
            }
            return value;
        }

        public static string ConvertListArraytoString(List<string[]> list)
        {
            string str = "";
            foreach (string[] element in list)
            {
                foreach (string item in element)
                {
                    str += item + "/ ";
                }
                str += "<br>";
                Console.WriteLine(str);
                
            }
            return str;
        }
    }
}