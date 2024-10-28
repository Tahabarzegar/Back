using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Entities.Base;

namespace First.API.Entities
{
    public class Borrow : Thing
    {
        public DateTime BorrowTime { get; set; }
        public DateTime? ReturnTime { get; set; }
        public Book? Book { get; set; }
        public int BookId { get; set; }
        public Member? Member { get; set; }
        public int MemberId { get; set; }
    }
}