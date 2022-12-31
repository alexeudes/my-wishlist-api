using System;
namespace my_wishlist_api.Models
{
	public class Wishlist
	{
		public Wishlist()
		{
			
		}

		public int ID { get; set; }
		public string Title { get; set; }
		public string? Description { get; set; }
        public string? SourceOfBuy { get; set; }
		public DateTime DateOfDesire { get; set; } = DateTime.Now;
		public decimal Price { get; set; }
		public byte Photo { get; set; }
		public string Priority { get; set; }
	}
}
