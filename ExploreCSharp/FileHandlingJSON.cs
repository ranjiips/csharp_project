using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using RestSharp;


namespace ExploreCSharp
{
    public class FileHandlingJSON
    {
        //string filepath = "C:/Ranjith/Learnings/Projects/csharp_project/ExploreCSharp/Resources/menu.json";
        private string filepath = $"{Directory.GetCurrentDirectory()}/Resources/menu.json";
        public string FilePath
        {
            get { return filepath; }
            private set { filepath = value; }
        }

        public string GetJsonObject()
        {
            string json = null;
            using (StreamReader reader = new StreamReader(FilePath))
            {
                json = reader.ReadToEnd();
            }
            return json;
        }

        public JsonSchema GetJsonSchema()
        {
            var json =  JsonSchema.Parse(File.ReadAllText(FilePath));
            return json;
        }

        public int GetValuesUsingIndex(string SingleJsonObject)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Json Methods - Get Values Using Index ***********\n", ConsoleColor.Magenta);
            //var SingleJsonObject = GetJsonObject();            
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

        public int GetValuesUsingValueMethod(string SingleJsonObject)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Json Methods - Get Values Using Value Method ***********\n", ConsoleColor.Magenta);
            //var SingleJsonObject = GetJsonObject();
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

        public void GetValuesFromJsonJTokenParseMethod(string SingleJsonObject)
        {
            StaticClassExamples.ColorfulWriteLine("\n***********  Json Methods - Get Values Using JToken Parse Method ***********\n", ConsoleColor.Magenta);
            //var SingleJsonObject = GetJsonObject();
            var make = JToken.Parse(SingleJsonObject).SelectToken("make").ToString();
            var year = JToken.Parse(SingleJsonObject).SelectToken("year").ToString();
            Console.WriteLine($"{make} {year}");
        }
    }
}
