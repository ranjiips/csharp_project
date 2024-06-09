using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;

namespace ExploreCSharp
{
    public class HandleAPIs
    {
        string apiurl;
        public HandleAPIs(string url) 
        {
            this.apiurl = url;
        }
        public void GetRequestAPI(string endpointurl)
        {
            var url = $"{apiurl}{endpointurl}";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Get);
            RestResponse response = client.Get(request);
            var Output = response.Content;
            Console.WriteLine(Output.ToString());
            //var values = JsonConvert.DeserializeObject<string>(Output);
        }

        public void PostRequestAPI(string endpointurl)
        {
            var url = $"{apiurl}{endpointurl}";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
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
            RestResponse response = client.Post(request);
            var output = response.Content;
            Console.WriteLine(output.ToString());
        }

        public void DeleteBookAPI(string endpointurl, string idvalue)
        {
            var url = $"{apiurl}{endpointurl}";
            var client = new RestClient(url);
            var request = new RestRequest(url, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            var body = new
            {
                ID = idvalue
            };
            var bodyy = JsonConvert.SerializeObject(body);
            request.AddBody(bodyy, "application/json");
            RestResponse response = client.Post(request);
            var output = response.Content;
            Console.WriteLine(output.ToString());
        }
    }
}
