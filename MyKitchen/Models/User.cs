using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyKitchen.Models
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Display(Name="Username")]
		[Required]
		public string Username { get; set; }

		[Display(Name="Email")]
		[Required]
		public string Email { get; set; }

		[Display(Name="Password")]
		[DataType(DataType.Password)]
		[Required]
		public string Password { get; set; }
	}
}
