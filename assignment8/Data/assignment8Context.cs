using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using assignment8.Models;

namespace assignment8.Data
{
    public class assignment8Context : DbContext
    {
        public assignment8Context (DbContextOptions<assignment8Context> options)
            : base(options)
        {
        }

        public DbSet<assignment8.Models.Order> Order { get; set; } = default!;
    }
}
