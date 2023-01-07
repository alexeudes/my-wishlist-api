using System;
using my_wishlist_api.Models;
using my_wishlist_api.Repositories.Interfaces;

namespace my_wishlist_api.Repositories
{
	public class ItemWishlistRepository : IItemWishlistRepository
    {
		public ItemWishlistRepository()
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

