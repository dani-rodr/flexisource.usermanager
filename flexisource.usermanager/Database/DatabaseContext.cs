using System;
using flexisource.usermanager.Models;
using Microsoft.EntityFrameworkCore;

namespace flexisource.usermanager.Database
{
	public class DatabaseContext : DbContext
	{
		public DbSet<User> Users { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=database.db");
		}
	}
}

