using System;
using my_wishlist_api.Models;
using my_wishlist_api.Services.Interfaces;

namespace my_wishlist_api.Services
{
	public class WishlistService : IWishlistService
	{
		public WishlistService()
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

        public Task<bool> UpdateWishList(Wishlist wishlist)
        {
            throw new NotImplementedException();
        }

        public Task<List<Wishlist>> GetAllMyWishLists()
        {
            throw new NotImplementedException();
        }
    }
}

