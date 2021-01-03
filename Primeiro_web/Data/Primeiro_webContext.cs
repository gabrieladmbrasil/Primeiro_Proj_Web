using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Primeiro_web.Models;

namespace Primeiro_web.Data
{
    public class Primeiro_webContext : DbContext
    {
        public Primeiro_webContext (DbContextOptions<Primeiro_webContext> options)
            : base(options)
        {
        }

        public DbSet<Primeiro_web.Models.Department> Department { get; set; }
    }
}
