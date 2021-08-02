using Microsoft.EntityFrameworkCore;
using VidlyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
