using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;

namespace CoreSchool.App
{
	public class SchoolEngine
	{
		public School School { get; set; }

		public SchoolEngine()
		{
		}

		public void Initializing()
		{
			LoadSchool();

			LoadCourses();
			// LoadSignatures();
			LoadStudents();

			LoadEvaluations();
		}

		private void LoadSchool()
		{
			School = CreateSchool();
		}

		private School CreateSchool()
		{
			var school = new School
			(
				"Platzi Academy",
				2012,
				SchoolTypes.Elementary,
				city: "Bogota",
				country: "Colombia"
			);

			return school;
		}

		private void LoadCourses()
		{
			School.Courses = new List<Course>(CreateCourses());
		}

		private IEnumerable<Course> CreateCourses()
		{
			var courses = new List<Course>
			{
				new Course()
				{
					Name = "101",
				},
				new Course()
				{
					Name = "201"
				},
				new Course()
				{
					Name = "301"
				},
				new Course()
				{
					Name = "401",
					Journey = JourneyTypes.Afternoon,
				},
				new Course()
				{
					Name = "501",
					Journey = JourneyTypes.Afternoon,
				},
			};

			return courses;
		}

		private void LoadStudents()
		{
			foreach (Course course in School.Courses)
			{
				course.Students.AddRange(CreateStudents());
			}
		}

		private IEnumerable<Student> CreateStudents()
		{
			string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
			string[] lastname1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
			string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

			var students = from n1 in name1
						   from n2 in name2
						   from a1 in lastname1
						   select new Student { Name = $"{n1} {n2} {a1}" };

			return students;
		}

		private void LoadSignatures()
		{
			throw new NotImplementedException();
		}


		private void LoadEvaluations()
		{
			foreach (Course course in School.Courses)
			{
				course.Signatures.AddRange(CreateSignatures());
			}
		}

		private IEnumerable<Signature> CreateSignatures()
		{
			var signatures = new List<Signature>
			{
				new Signature { Name = "Matemáticas" },
				new Signature { Name = "Educación Física" },
				new Signature { Name = "Castellano" },
				new Signature { Name = "Ciencias Naturales" },
			};

			return signatures;
		}
	}
}