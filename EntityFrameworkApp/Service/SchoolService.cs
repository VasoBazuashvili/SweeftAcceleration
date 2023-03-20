using EntityFrameworkApp.Db;
using EntityFrameworkApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkApp.Service
{
	public class SchoolService
	{
		private readonly SchoolContext _context;

		public SchoolService(SchoolContext context)
		{
			_context = context;
		}

		public Teacher[] GetAllTeachersByStudent(string studentName)
		{
			var teachers = _context.Teachers
				.Where(t => t.Students.Any(s => s.FirstName == studentName))
				.ToArray();

			return teachers;
		}
	}
}
