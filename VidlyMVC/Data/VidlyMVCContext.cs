using Microsoft.EntityFrameworkCore;
using VidlyMVC.Models;

namespace VidlyMVC.Data
{
    public class VidlyMVCContext: DbContext
    {
        public VidlyMVCContext(DbContextOptions<VidlyMVCContext> options)
            :base(options)
        {
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }
        public DbSet<Genre> Genre { get; set; }
    }
}
