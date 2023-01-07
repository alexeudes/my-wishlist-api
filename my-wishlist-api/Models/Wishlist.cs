using System;
namespace my_wishlist_api.Models
{
	public class Wishlist
	{
		public Wishlist()
		{
			
		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public byte Photo { get; set; }

		public List<ItemWishlist> itensWishlist { get; set; } = new List<ItemWishlist>();
		public User user { get; set; }
	}
}
