using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FetchData
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //URL of the website you want to fetch data from
            string url = "https://prakticum.fi/";
            //Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    //Get a request to the specified URL
                    HttpResponseMessage response = await client.GetAsync(url);
                    //Check if the request was succesful
                    if (response.IsSuccessStatusCode)
                    {
                        //Read the content of the response as a string
                        string data = await response.Content.ReadAsStringAsync();

                        //Print the fetched data in the console
                        Console.WriteLine(data);
                    }
                    else
                    {
                        //If the request was not succesful, print the status code
                        Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
                    }
                }
                catch (HttpRequestException e)
                {
                    //Print any exception that ocurred during the request
                    Console.WriteLine($"An error occured: {e.Message}");
                }
            }

        }
    }
}
