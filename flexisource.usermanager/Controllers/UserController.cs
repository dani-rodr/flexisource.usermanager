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

		public IActionResult Data()
        {
			return Json(GetUsers());
        }

		[HttpPost]
		public IActionResult Add(User user)
        {
			using (var db = new DatabaseContext())
            {
				db.Users.Add(user);
				db.SaveChanges();
            }
			return Redirect("/User");
        }

		public IActionResult Generate()
		{
			int numOfUsers = 5;
			using (var db = new DatabaseContext())
			{
				db.Users.AddRange(GenerateRandomUsers(numOfUsers));
				db.SaveChanges();
			}
			return Redirect("/User");
		}

		public IActionResult Clear()
        {
			using (var db = new DatabaseContext())
			{
				db.Users.RemoveRange(db.Users);
				db.SaveChanges();
			}
			return Redirect("/User");
		}

		private List<User> GetUsers()
		{
			List<User> users;
			using (var db = new DatabaseContext())
            {
				users = db.Users.ToList();
            }
			return users;
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

