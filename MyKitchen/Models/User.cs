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
		public int user_id { get; set; }

		[Display(Name="Username")]
		[Required]
		public string username { get; set; }

		[Display(Name="Email")]
		[Required]
		public string email { get; set; }

		[Display(Name="Password")]
		[DataType(DataType.Password)]
		[Required]
		public string password { get; set; }
	}
}
