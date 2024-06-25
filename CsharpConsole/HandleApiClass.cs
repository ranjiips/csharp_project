using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConsole
{
    public class HandleApiClass
    {
        private static string apiBaseURL = "https://rahulshettyacademy.com";
        private static string endpointurl;

        public string APIBaseURL
        {
            get { return apiBaseURL; }
            private set { apiBaseURL = value; }
        }
        public string Endpointurl
        {
            get { return endpointurl; }
            set { endpointurl = value; }
        }

        public static RestClient client;
        public static RestRequest request;
        public static RestResponse response;

        public string getBookapiurl = "/Library/GetBook.php";
        public string postBookapiurl = "/Library/Addbook.php";
        public string deleteBookapiurl = "/Library/DeleteBook.php";

        public void GetAPIMethod()
        {
            string queryParam = $"{getBookapiurl}?ID=AABD4456";
            this.Endpointurl = $"{this.APIBaseURL}{queryParam}";
            client = new RestClient(this.Endpointurl);
            request = new RestRequest(this.Endpointurl, Method.Get);
            response = client.Get(request);
            Console.WriteLine($"Status Code = {response.StatusCode}");
            Console.WriteLine($"Message = {response.Content.ToString()}");
        }

        public void PostAPIMethod()
        {
            this.Endpointurl = $"{this.APIBaseURL}{this.postBookapiurl}";
            client = new RestClient(this.Endpointurl);
            request = new RestRequest (this.Endpointurl, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "CSharp",
                isbn = "AABD",
                aisle = "4456",
                author = "Ranjith"
            };
            var requestBody = JsonConvert.SerializeObject(body);
            request.AddBody(requestBody,"application/json");
            response = client.Post(request);
            Console.WriteLine($"Status Code = {response.StatusCode}");
            Console.WriteLine($"Message = {response.Content.ToString()}");
        }
    }
}
