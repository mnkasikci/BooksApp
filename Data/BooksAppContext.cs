using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksApp.Models;

namespace BooksApp.Data
{
    public class BooksAppContext : DbContext
    {
        public BooksAppContext (DbContextOptions<BooksAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<BooksApp.Models.BookModel> BookModel { get; set; }

        public DbSet<BooksApp.Models.AuthorModel> AuthorModel { get; set; }
    }
}
