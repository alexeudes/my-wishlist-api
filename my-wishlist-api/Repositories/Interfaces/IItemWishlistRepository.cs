using System;
using my_wishlist_api.Models;

namespace my_wishlist_api.Repositories.Interfaces
{
	public interface IItemWishlistRepository
    {
        Task CreateItemWishlist(ItemWishlist itemWishlist);
        Task<bool> DeleteItemWishlist(int id);
        Task<bool> UpdateItemWishList(Wishlist wishlist);
        Task<List<Wishlist>> GetAllItensWishLists(int idWishList);
    }
}
