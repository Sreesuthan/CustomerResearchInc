using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResearchInc.Shared
{
	public class Customer_Export
	{
		[NotMapped]
		public int SrNo { get; set; }
		public int CustNo { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public string LaborType { get; set; } = string.Empty;
		public string Advisor { get; set; } = string.Empty;
		public DateTime Date { get; set; }
		public string Technician { get; set; } = string.Empty;
		public string VINno { get; set; } = string.Empty;
		public long TelePhone { get; set; }
		public string Vehicle { get; set; } = string.Empty;
		public decimal OvarallCSI { get; set; }
		public string CallCenterAgent { get; set; } = string.Empty;
		[NotMapped]
		public string Comments { get; set; } = string.Empty;
	}
}
