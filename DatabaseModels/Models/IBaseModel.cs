using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels.Models
{
	public abstract class BaseDateModel
	{
		protected DateTime UpdateDate { get; set; }
		protected DateTime CreateDate { get; set; }
		protected bool isActive { get; set; }
	}
}
