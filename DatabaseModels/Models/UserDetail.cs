using AccountCore.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DatabaseModels.Models
{
	public class UserDetail
	{

		public Guid UserDetailId { get; set; }
		public Guid UserFK { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }

		[ForeignKey("UserFK")]
		public virtual ApplicationUsers applicationUsers { get; set; }
	}
}
