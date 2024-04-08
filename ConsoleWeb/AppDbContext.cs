using System;
using ConsoleWeb.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleWeb
{
	public class AppDbContext:DbContext
	{
		public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=web3;User ID=sa;Password=reallyStrongPwd123;");
        }
    }
}

