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
		[DisplayName("Delivery Address")]
		public string DeliveryAddress { get; set; }
		[DisplayName("Billing Address")]
		public string BillingAddress { get; set; }
    }

}

