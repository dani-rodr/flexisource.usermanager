using System;
using Microsoft.AspNetCore.Mvc;

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
			return View("test");
        }
	}
}

