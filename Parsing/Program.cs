using System;
using System.IO;
using System.Text.Json;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            using (StreamReader reader = new StreamReader("wikidata_sample.json"))
            {
                string jsonFile = reader.ReadToEnd();

                JsonDocument jDoc = JsonDocument.Parse(jsonFile);

                var labels = jDoc.RootElement.GetProperty("labels");

                //JsonDocument jDoc = JsonSerializer.Deserialize<JsonDocument>(jsonFile);
                //var labels = jDoc.RootElement.GetProperty("labels");
                //var en = labels.GetProperty("en");
                // value = en.GetProperty("value");
                Console.WriteLine(labels);
            }*/

            //Check if the code works with one word
            using (StreamReader reader = new StreamReader("oneWord_sample.json"))
            {
                string jsonFile = reader.ReadToEnd();

                JsonDocument jDoc = JsonDocument.Parse(jsonFile);

                var labels = jDoc.RootElement.GetProperty("labels");

                //string[] langs = { "en", "el", "fr" };

                var en = labels.GetProperty("en");

                var value = en.GetProperty("value");

                /*
                foreach(string l in langs)
                {
                    var lang = labels.GetProperty(l);
                    var value = lang.GetProperty("value");
                    Console.WriteLine(value);
                }
                */

                //JsonDocument jDoc = JsonSerializer.Deserialize<JsonDocument>(jsonFile);
                //var labels = jDoc.RootElement.GetProperty("labels");
                //var en = labels.GetProperty("en");
                // value = en.GetProperty("value");
                Console.WriteLine(value);
            }
        }
    }
}

