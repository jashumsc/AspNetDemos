using Microsoft.EntityFrameworkCore;
using MVCformvalidation.Models;
using System.Collections.Generic;

// Add the following Nuget packages:
//  (a) Microsoft.EntityFrameworkCore.SqlServer         (ver 3.x)
//  (b) Microsoft.EntityFrameworkCore.Tools             (ver 3.x)
// NOTE: ensure that both nuget packages have the same version!

namespace MVCformvalidation.Data
{
    public class ApplicationDbContext
        : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<MVCformvalidation.Models.Category> Category { get; set; }

    }
}