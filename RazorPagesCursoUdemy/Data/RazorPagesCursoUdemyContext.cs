using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesCursoUdemy.Model;

namespace RazorPagesCursoUdemy.Data
{
    public class RazorPagesCursoUdemyContext : DbContext
    {
        public RazorPagesCursoUdemyContext (DbContextOptions<RazorPagesCursoUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
