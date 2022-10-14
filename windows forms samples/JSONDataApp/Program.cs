using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

//  use this link to transform json content into objects (classes): https://json2csharp.com/
namespace JSONDataApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://my-json-server.typicode.com/typicode/demo/posts";
            // http client to send the get request
            HttpClient httpClient = new HttpClient();

            try
            {
                var httpResponseMessage = await httpClient.GetAsync(url);

                // read the string from the response content
                string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
                // print jsonResponse
                Console.WriteLine(jsonResponse);

                // Deserialize the json response into a C# array of type Post[]
                var myPosts = JsonConvert.DeserializeObject<Post[]>(jsonResponse);

                // print the array objects using a for each loop
                foreach (var post in myPosts)
                {
                    // print the id and the title of each post
                    Console.WriteLine($"{post.Id} {post.Title}");
                }
                Console.Read();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                // Dispose of the httpClient
                httpClient.Dispose();
            }

        }
    }
}
