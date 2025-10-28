using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pryecto_nicol.Models;

namespace pryecto_nicol.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<usuarioModel1> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel1>().HasKey(U => U.UserId);

        modelBuilder.Entity<usuarioModel1 >().Property(U => U.UserId).ValueGeneratedOnAdd(); }
    }
}