using System;
using my_wishlist_api.Models;

namespace my_wishlist_api.Services.Interfaces
{
	public interface IUserService
	{
        Task CreateUser(User user);
        Task<bool> UpdateUser(User user);
    }
}

