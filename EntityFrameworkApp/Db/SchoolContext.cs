using EntityFrameworkApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.Db
{
	public class SchoolContext : DbContext
	{
		public SchoolContext(DbContextOptions<SchoolContext> options)
		: base(options)
		{
		}

		public DbSet<Teacher> Teachers { get; set; }
		public DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Teacher>()
				.HasMany(t => t.Students)
				.WithMany(s => s.Teachers);
		}
	}
}
