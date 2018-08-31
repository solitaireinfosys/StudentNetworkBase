using AccountCore.DataModels;
using DatabaseModels.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseModels
{


	public class appDBContext : DbContext
	{

		public appDBContext()
		{



		}
		public DbSet<ApplicationUsers> applicationUsers { get; set; }
		public DbSet<UserDetail> userDetails { get; set; }
	}

}
