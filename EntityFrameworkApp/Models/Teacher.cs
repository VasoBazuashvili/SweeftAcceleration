using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.Models
{
	public class Teacher
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Gender { get; set; }
		public string Subject { get; set; }
		public List<Student> Students { get; set; }
	}
}
