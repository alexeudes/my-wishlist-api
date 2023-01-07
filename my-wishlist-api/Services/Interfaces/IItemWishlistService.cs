using System;
using my_wishlist_api.Models;

namespace my_wishlist_api.Services.Interfaces
{
	public interface IItemWishlistService
	{
        Task CreateItemWishlist(ItemWishlist itemWishlist);
        Task<bool> DeleteItemWishlist(int id);
        Task<bool> UpdateItemWishList(Wishlist wishlist);
        Task<List<Wishlist>> GetAllItensWishLists(int idWishList);
    }
}

