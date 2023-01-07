using System;
namespace my_wishlist_api.Models
{
	public class ItemWishlist
	{
		public ItemWishlist()
		{
		}

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } = string.Empty;
        public string SourceOfBuy { get; set; } = string.Empty;
        public DateTime DateOfDesire { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public byte Photo { get; set; }
        public string Priority { get; set; }

        public int IdWishList { get; set; }
    }
}

