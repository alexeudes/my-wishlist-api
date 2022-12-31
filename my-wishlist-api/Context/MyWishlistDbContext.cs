using System;
using Microsoft.EntityFrameworkCore;
using my_wishlist_api.Models;

namespace my_wishlist_api.Context
{
	public class MyWishlistDbContext : DbContext
	{
		public MyWishlistDbContext(DbContextOptions<MyWishlistDbContext> options) : base(options)
		{}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SqliteConnectionString");
            optionsBuilder.UseSqlite(connectionString);
        }

        public DbSet<Wishlist> Wishlists { get; set; }
	}
}

