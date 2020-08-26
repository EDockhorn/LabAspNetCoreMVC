using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoDominandoAspNetCore.Models
{
    public class CursoDominandoAspNetCoreContext : DbContext
    {
        public CursoDominandoAspNetCoreContext (DbContextOptions<CursoDominandoAspNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<CursoDominandoAspNetCore.Models.Movie> Movie { get; set; }
    }
}
