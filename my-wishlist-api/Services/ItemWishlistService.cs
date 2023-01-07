using System;
using my_wishlist_api.Models;
using my_wishlist_api.Services.Interfaces;

namespace my_wishlist_api.Services
{
	public class ItemWishlistService : IItemWishlistService
    {
		public ItemWishlistService()
		{
		}

        public Task CreateItemWishlist(ItemWishlist itemWishlist)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemWishlist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Wishlist>> GetAllItensWishLists(int idWishList)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemWishList(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}

