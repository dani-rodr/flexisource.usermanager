using System;
using System.ComponentModel;

namespace flexisource.usermanager.Models
{
	public class User
	{
		public int UserId { get; set; }
		[DisplayName("First Name")]
		public string FirstName { get; set; }
		[DisplayName("Last Name")]
		public string LastName { get; set; }
		public string Address { get; set; }
    }

}

