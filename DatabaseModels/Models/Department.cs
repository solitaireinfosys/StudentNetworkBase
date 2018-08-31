using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseModels.Models
{
	public class Department : BaseDateModel
	{
		public Guid DepartmentId { get; set; }
		public string DepartmentName { get; set; }
		public string DepartmentKey { get; set; }
		public string DepartmentDetail { get; set; }
		public string DepartmentShortDetail { get; set; }
		public virtual ICollection<SubjectMst> DepartmentSubjects { get; set; }
	}
}
