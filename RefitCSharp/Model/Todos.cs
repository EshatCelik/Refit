﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitCSharp.Model
{
    public class Todos
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
        //[JsonProperty("userId")]
        //public int UserId { get; set; }
        //[JsonProperty("id")]
        //public int  Id { get; set; }
        //[JsonProperty("title")]
        //public string Title { get; set; }
        //[JsonProperty("completed")]
        //public bool Completed { get; set; }
    }
}
