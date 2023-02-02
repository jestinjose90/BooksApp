using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBooksApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EBooksApp.Infrastructure
{
    public class CartContext : DbContext
    {
        public CartContext(DbContextOptions<CartContext> options)
            : base(options)
            {
            }

        public DbSet<Page> Pages { get; set; } 
      

    }
}
