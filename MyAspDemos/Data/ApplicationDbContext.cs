using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyAspDemos.Models;
using System.Collections.Generic;

// Add the following Nuget packages:
//  (a) Microsoft.EntityFrameworkCore.SqlServer         (ver 3.x)
//  (b) Microsoft.EntityFrameworkCore.Tools             (ver 3.x)
// NOTE: ensure that both nuget packages have the same version!

namespace MyAspDemos.Data
{
    public class ApplicationDbContext
        : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<NewsPaper> NewsPapers { get; set; }

        public DbSet<Artist> Artists { get; set; }


    }
}