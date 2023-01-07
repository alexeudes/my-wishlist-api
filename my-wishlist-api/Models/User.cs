using System;
namespace my_wishlist_api.Models
{
	public class User
	{
		public User()
		{

		}

		public int ID { get; set; }
		public string Name { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
    }
}

