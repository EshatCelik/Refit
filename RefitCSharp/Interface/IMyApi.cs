using Refit;
using RefitCSharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitCSharp.Interface
{
    public interface IMyApi
    {
        [Get("/todos")]
        Task<List<Todos>> GetTodos();
    }
}
