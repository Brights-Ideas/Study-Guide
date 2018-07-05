using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CityInfo.API.Controllers
{
    public class LatitudeObject
    {
        public string Address { get; set; }
        public string Latitude { get; set; } 
        public string Longitude { get; set; }
    }

    [Route("api/properties")]
    public class PropertiesController : Controller
    {

        [HttpGet()]
        public IActionResult GetProperties()
        {
            var latitudeObjects = new List<LatitudeObject>();
            string json = null;

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://services.jupix.co.uk/");
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = httpClient
                    .GetAsync("api/get_properties.php?clientID=ce5385e4d6f49ce36a5e1c0b3fa981d4&passphrase=GHvYG9f")
                    .Result;

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;

                    var xml = new XmlDocument();
                    xml.LoadXml(data);

                    XmlNodeList elemList = xml.GetElementsByTagName("property");

                    var node = elemList.Cast<XmlNode>().Where(n => n["department"].InnerText == "Sales" && n["latitude"].InnerText != null || n["latitude"].InnerText != null);

                    foreach (XmlNode xn in node)
                    {
                        if (xn != null)
                        {
                            latitudeObjects.Add(new LatitudeObject
                            {
                                Address = xn["displayAddress"].InnerText,
                                Latitude = xn["latitude"].InnerText,
                                Longitude = xn["longitude"].InnerText
                            });
                        }
                    }

                    json = JsonConvert.SerializeObject(latitudeObjects);
                }
                
            }

            return Ok(JArray.Parse(json));
        }

        [HttpGet("{propertyId}")]
        public IActionResult GetProperties(string propertyId)
        {
            string json = null;

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("http://services.jupix.co.uk/");
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36");
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = httpClient
                    .GetAsync("api/get_properties.php?clientID=ce5385e4d6f49ce36a5e1c0b3fa981d4&passphrase=GHvYG9f")
                    .Result;

                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsStringAsync().Result;

                    var xml = new XmlDocument();
                    xml.LoadXml(data);

                    XmlNodeList elemList = xml.GetElementsByTagName("property");

                    var node = elemList.Cast<XmlNode>().Where(n => n["propertyID"].InnerText == propertyId);

                    json = JsonConvert.SerializeObject(node);
                }

            }

            return Ok(JArray.Parse(json));
        }
    }
}