using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.DevTools.V123.Emulation;

namespace ExploreCSharp
{
    public class HandleAPIs
    {
        private static string apiurl = "https://rahulshettyacademy.com";
        private string endPointurl;
        private static IRestClient client;
        private static RestRequest request;
        private static RestResponse response;
        //private static void InitializeRestClient() => client = new RestClient(apiurl);

        public string Apiurl { get { return apiurl; } }

        public string EndPointurl
        {
            get { return endPointurl; }
            set { endPointurl = value; }
        }
        public HandleAPIs() 
        {
            
        }
        public void GetRequestAPIWithOutAuth(string endpointurl)
        {
            this.EndPointurl = endpointurl;
            var url = $"{this.Apiurl}{this.EndPointurl}";
            client = new RestClient(url);
            request = new RestRequest(url, Method.Get);
            response = client.Get(request);
            var statusCode = response.StatusCode;
            var Output = response.Content;
            Console.WriteLine($"Status Code: {statusCode}, Response Content: {Output.ToString()}");
            //var values = JsonConvert.DeserializeObject<string>(Output);
        }

        public void GetRequestAPI()
        {
            string url = "https://google.com";
            client = new RestClient(url);
            request = new RestRequest(url, Method.Get);
            response = client.Get(request);
            var statuscode = response.StatusCode;
            var content = response.Content;
        }

        public async Task GetRequestAPIUsingAsyncMethod()
        {
            var restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri("https://google.com"),
                RemoteCertificateValidationCallback = (sender, certificate, chain, errors) => true
            };
            //string url = "https://google.com";
            client = new RestClient(restClientOptions);
            request = new RestRequest();
            response = await client.GetAsync(request);
            var statuscode = response.StatusCode;
            var content = response.Content;
            Console.WriteLine($"Status Code: {statuscode}, Response Content: {content.ToString()}");
        }

        public void PostRequestAPIWithOutAuth(string endpointurl)
        {
            this.EndPointurl = endpointurl;
            var url = $"{this.Apiurl}{this.EndPointurl}";
            client = new RestClient(url);
            request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                name = "CSharp",
                isbn = "AABD",
                aisle = "445",
                author = "Ranjith"
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            response = client.Post(request);
            var statusCode = response.StatusCode;
            var Output = response.Content;            
            Console.WriteLine($"Status Code: {statusCode}, Response Content: {Output.ToString()}");
            
        }

        public void DeleteBookAPI(string endpointurl, string idvalue)
        {
            var url = $"{apiurl}{endpointurl}";
            client = new RestClient(url);
            request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                ID = idvalue
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            response = client.Post(request);
            var statusCode = response.StatusCode;
            var Output = response.Content;
            Console.WriteLine($"Status Code: {statusCode}, Response Content: {Output.ToString()}"); 
        }
    }
}
