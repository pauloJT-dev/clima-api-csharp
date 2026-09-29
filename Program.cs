using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace PracticaClimaApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Endpoint con coordenadas de abo San Lucas, BCS
            string url = "https://api.open-meteo.com/v1/forecast?latitude=22.89&longitude=-109.91&current_weather=true";

            // Se instancia HttpClient de forma segura
            using HttpClient client = new HttpClient();

            Console.WriteLine("Conectando a la API de Open-Meteo...\n");

            try
            {
                // Peticion GET asincrona
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                // Lectura del JSON como texto
                string responseBody = await response.Content.ReadAsStringAsync();
                
                // Parseo del JSON nativo de .NET
                using JsonDocument doc = JsonDocument.Parse(responseBody);
                JsonElement root = doc.RootElement;
                JsonElement current = root.GetProperty("current_weather");

                // Extraccion de varibles
                double temp = current.GetProperty("temperature").GetDouble();
                double windSpeed = current.GetProperty("windspeed").GetDouble();
                string time = current.GetProperty("time").GetString();

                // Salida en consola
                Console.WriteLine("--- REPORTE DEL CLIMA ---");
                Console.WriteLine($"Hora del reporte: {time}");
                Console.WriteLine($"Temperatura actual: {temp} °C");
                Console.WriteLine($"Velocidad del viento: {windSpeed} km/h");
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error de red: {e.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado: {ex.Message}");
            }
        }
    }
}
