using AssignThurs.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignThurs.Data
{
    public class ApplicationDbContext
       : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Artist> Artists { get; set; }



    }
}
