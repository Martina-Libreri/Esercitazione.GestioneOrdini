using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Esercitazione4.GestioneOrdini.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            HttpRequestMessage message = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44311/api/Ordine")
            };

            var response = client.SendAsync(message).Result;
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonData = response.Content.ReadAsStringAsync().Result;
                var ordini = JsonConvert.DeserializeObject<List<OrdineContract>>(jsonData);

                Console.WriteLine("Stampa ordini");
                foreach (var item in ordini)
                {
                    Console.WriteLine($"Id: {item.Id} Codice Ordine : {item.CodiceProdotto}");

                }

            }



        }
    }
}
