using System;
using my_wishlist_api.Models;
using my_wishlist_api.Services.Interfaces;

namespace my_wishlist_api.Services
{
	public class UserService : IUserService
    {
		public UserService()
		{
		}

        public Task CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

