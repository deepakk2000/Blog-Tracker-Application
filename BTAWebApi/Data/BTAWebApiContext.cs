using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL;
using BTAWebApi.Models;

namespace BTAWebApi.Data
{
    public class BTAWebApiContext : DbContext
    {
        public BTAWebApiContext (DbContextOptions<BTAWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<DAL.AdminInfo> AdminInfo { get; set; } = default!;

        public DbSet<DAL.BlogInfo> BlogInfo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAL.BlogInfo>().HasNoKey();
        }

        public DbSet<DAL.EmpInfo>? EmpInfo { get; set; }
    }
}
