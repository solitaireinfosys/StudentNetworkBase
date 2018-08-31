using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels.Models
{
	public class SubjectMst : BaseDateModel
	{
		public Guid SubjectMastId { get; set; }
		public string SubjectName { get; set; }
		public string SubjectKey { get; set; }
		public string SubjectDetail { get; set; }
		public string SubjectShortDetail { get; set; }
	}
}
