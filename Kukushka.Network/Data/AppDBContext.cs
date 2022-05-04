using Kukushka.Network.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kukushka.Network.Data
{
    public class AppDBContext : DbContext
    {
        public string DbPath { get; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
