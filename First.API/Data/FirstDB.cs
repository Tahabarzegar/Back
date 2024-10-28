using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace First.API.Data
{
    public class FirstDB : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Book> Books { get; set; }

        public DbSet<Borrow> Borrows { get; set; }

        public FirstDB(DbContextOptions options)
            : base(options)
        {

        }
    }
}