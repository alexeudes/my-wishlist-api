using System;
using my_wishlist_api.Models;

namespace my_wishlist_api.Repositories.Interfaces
{
	public interface IWishlistRepository
	{
        Task CreateWishlist(Wishlist wishlist);
        Task<bool> DeleteWishlist(int id);
        Task<bool> UpdateWishList(Wishlist wishlist);
        Task<List<Wishlist>> GetAllMyWishLists();
    }
}

