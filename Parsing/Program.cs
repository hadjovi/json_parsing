using System;
using System.IO;
using System.Text.Json;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {            

            using (StreamReader reader = new StreamReader("wikidata_sample.json"))
            {
                string jsonFile = reader.ReadToEnd();

                JsonDocument jDoc = JsonSerializer.Deserialize<JsonDocument>(jsonFile);
                var labels = jDoc.RootElement.GetProperty("labels");
                var en = labels.GetProperty("en");
                var value = en.GetProperty("value");
                Console.WriteLine(value);
            }
        }
    }
}
