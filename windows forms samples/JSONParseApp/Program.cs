using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JSONParseApp
{
    class Program
    {
        HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            Program program = new Program();
            await program.GetTodoItems();
        }

        private async Task GetTodoItems()
        {
            string response = await client.GetStringAsync("https://my-json-server.typicode.com/typicode/demo/posts");
            
            Console.WriteLine(response);

            List<Todo> todo = JsonConvert.DeserializeObject<List<Todo>>(response);
            foreach (var item in todo) 
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Title);
            }

            Console.Read();
        }

        class Todo 
        { 
            public int Id { get; set; } 
            public string Title { get; set; }
        }
    }
}
