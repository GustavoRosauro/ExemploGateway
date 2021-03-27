using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading;

namespace Carros.Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(40000);
            using (var client = new HttpClient())
            {
                var result = client.GetAsync("https://localhost:44353/gateway/carros").Result;
                if (result.IsSuccessStatusCode)
                {
                    string json = result.Content.ReadAsStringAsync().Result;
                    string[] carros = JsonConvert.DeserializeObject<string[]>(json);
                    MostrarCarros(carros);
                }
            }
        }
        static void MostrarCarros(string[] carros)
        {
            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine($"Carro: {carros[i]}");
            }
        }
    }
}
