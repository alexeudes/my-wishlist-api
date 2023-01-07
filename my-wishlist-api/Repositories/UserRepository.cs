using System;
using my_wishlist_api.Models;
using my_wishlist_api.Repositories.Interfaces;

namespace my_wishlist_api.Repositories
{
	public class UserRepository : IUserRepository
    {
		public UserRepository()
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

