using System;
using my_wishlist_api.Models;
using my_wishlist_api.Repositories.Interfaces;

namespace my_wishlist_api.Repositories
{
	public class WishlistRepository : IWishlistRepository
    {
		public WishlistRepository()
		{
		}

        public Task CreateWishlist(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteWishlist(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Wishlist>> GetAllMyWishLists()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateWishList(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}

