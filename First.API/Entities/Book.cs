using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Entities.Base;

namespace First.API.Entities
{
    public class Book 
    {
        public string? Title { get; set; }
        public string? Writer { get; set; }
        public double Price { get; set; }
    }
}