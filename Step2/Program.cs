using CoreSchool.Entities;

namespace Step2
{
	class Program
	{
		static void Main(string[] args)
		{
			School school = new School
			(
				"Platzi Academy",
				2012,
				SchoolTypes.Elementary,
				city: "Bogota",
				country: "Colombia"
			);

			school.Courses = new Course[]
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
				}
			};

			PrintCoursesSchool(school);
		}

		private static void PrintCoursesSchool(School school)
		{
			Console.WriteLine("=====================");
			Console.WriteLine("Courses of the School");
			Console.WriteLine("=====================");

			if (school?.Courses != null)
			{
				foreach (var course in school.Courses)
				{
					Console.WriteLine($"{nameof(Course.Name)} {course.Name}, {nameof(Course.UniqueId)} {course.UniqueId}");
				}
			}
		}
	}
}
