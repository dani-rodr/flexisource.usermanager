using System;
using flexisource.usermanager.Database;
using flexisource.usermanager.Models;
using Microsoft.AspNetCore.Mvc;
using Faker;

namespace flexisource.usermanager.Controllers
{
	public class UserController : Controller
	{
		private readonly ILogger<UserController> _logger;

		public UserController(ILogger<UserController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Generate()
        {
			var numOfUsers = 50;
			List<User> users;
			using (var db = new DatabaseContext())
            {
				db.Users.RemoveRange(db.Users);
				db.Users.AddRange(GenerateRandomUsers(numOfUsers));
				db.SaveChanges();
				users = db.Users.ToList();
            }
			return Json(users);
        }

		private IEnumerable<User> GenerateRandomUsers(int num)
        {
			var users = new List<User>();
			for (int x = 0; x < num; x++)
            {
				var user = new User
				{
					Name = Faker.Name.FullName(),
					Address = $"{Faker.Address.StreetAddress()} {Faker.Address.City()} "
			};
				users.Add(user);
            }
			return users;
        }
	}
}

