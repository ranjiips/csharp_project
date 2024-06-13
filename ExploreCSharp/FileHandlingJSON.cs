using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace ExploreCSharp
{
    public class FileHandlingJSON
    {
        string filepath = "C:/Ranjith/Learnings/Projects/csharp_project/ExploreCSharp/Resources/menu.json";
        public string GetJsonObject()
        {
            string json = null;
            using (StreamReader reader = new StreamReader(filepath))
            {
                json = reader.ReadToEnd();
            }
            return json;
        }

        public int GetValuesUsingIndex()
        {
            Console.WriteLine("\n***********  Json Methods - Get Values Using Index ***********\n");
            var SingleJsonObject = GetJsonObject();
            var jsonObject = JObject.Parse(SingleJsonObject);
            var name = (string)jsonObject["name"];
            var make = (string)jsonObject["make"];
            var model = (string)jsonObject["model"];
            var year = (int)jsonObject["year"];
            var price = (JObject)jsonObject["price"];
            var amount = (int)price["amount"];
            var currency = (string)price["currency"];
            Console.WriteLine($"A {make} {name} {model} {year} costs {amount} {currency} \n");
            return jsonObject.Count;
        }

        public int GetValuesUsingValueMethod()
        {
            Console.WriteLine("\n***********  Json Methods - Get Values Using Value Method ***********\n");
            var SingleJsonObject = GetJsonObject();
            var jsonObject = JObject.Parse(SingleJsonObject);
            var name = jsonObject.Value<string>("name");
            var make = jsonObject.Value<string>("make");
            var model = jsonObject.Value<string>("model");
            var year = jsonObject.Value<string>("year");
            var amount = jsonObject.Value<JObject>("price")
               .Value<int>("amount");
            var currency = jsonObject.Value<JObject>("price")
               .Value<string>("currency");
            Console.WriteLine($"A {make} {name} {model} {year} costs {amount} {currency} \n");
            return jsonObject.Count;
        }

    }
}
