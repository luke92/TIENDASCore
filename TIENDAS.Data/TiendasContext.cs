using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TIENDAS.Data.Entities;

namespace TIENDAS.Data
{
    public class TiendasContext : DbContext
    {
        public TiendasContext(DbContextOptions<TiendasContext> options) : base(options) {  }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptionsBuilder) { }
    }
}
