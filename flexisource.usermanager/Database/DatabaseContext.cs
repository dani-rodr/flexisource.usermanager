using System;
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


	public class User
    {
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
    }
}

