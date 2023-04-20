using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerResearchInc.Shared
{
	public class Survey
	{
		public int Id { get; set; }
        public int CusId { get; set; }
        public bool Q1 { get; set; }
		public bool Q2 { get; set; }
		public bool Q3 { get; set; }
		public bool Q4 { get; set; }
		public bool Q5 { get; set; }
		public bool Q6 { get; set; }
		public bool Q7 { get; set; }
		public bool Q8 { get; set; }
		public string Q9 { get; set; } = string.Empty;
		public string Comments { get; set; } = string.Empty;
	}
}
