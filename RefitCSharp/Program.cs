using Refit;
using RefitCSharp.Interface;
using RefitCSharp.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RefitCSharp
{
    class Program
    {
        public static async Task<List<Todos>> GetTodosAsync()
        {
            List<Todos> todos = new List<Todos>();
            var myApi = RestService.For<IMyApi>("http://jsonplaceholder.typicode.com");

            return await myApi.GetTodos();
        }
        static async Task  Main(string[] args)
        {
            var todos =await GetTodosAsync();
            foreach (var item in todos)
            {
                Console.WriteLine("Id: "+item.id+" -"+item.title);
            }
            Console.ReadKey();
        }
    }
}
