using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Entities.Base;

namespace First.API.Entities
{
    public class Member : Thing
    {
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public string? Phonenumber { get; set; }
    }
}