using System;
using my_wishlist_api.Models;

namespace my_wishlist_api.Repositories.Interfaces
{
	public interface IUserRepository
	{
        Task CreateUser(User user);
        Task<bool> UpdateUser(User user);
    }
}

