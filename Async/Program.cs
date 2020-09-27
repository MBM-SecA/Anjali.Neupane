using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static async Task Main()
        {
            HttpClient client = new HttpClient();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var google = client.GetStringAsync("https://google.com/").Result;
            var Microsoft = client.GetStringAsync("https://Microsoft.com/").Result;
            var facebook = client.GetStringAsync("https://facebook.com/").Result;
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            var G = await client.GetStringAsync("https://google.com/");
            var M = await client.GetStringAsync("https://Microsoft.com/");
            var F = await client.GetStringAsync("https://facebook.com/");
            Console.WriteLine($"It took {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}