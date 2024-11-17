using Microsoft.Extensions.DependencyInjection;
using lekcjaApi.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lekcjaApi.Repositories.Interface;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddHttpClient();
            var repositoryProvider=services.BuildServiceProvider();

            var httpClientFactory=repositoryProvider.GetRequiredService<IHttpClientFactory>();

            var url = "https://localhost:7059/api/Pet";

            try
            {
                var httpClient = httpClientFactory.CreateClient();

                using var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Response from GetAsync:");
                    Console.WriteLine(responseString);
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
        }
    }
}