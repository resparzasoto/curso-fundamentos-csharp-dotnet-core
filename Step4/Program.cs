using CoreSchool.App;
using CoreSchool.Entities;

namespace CoreSchool
{
	class Program
	{
		static void Main(string[] args)
		{
			SchoolEngine engine = new SchoolEngine();
			engine.Initializing();

			PrintCoursesSchool(engine.School);
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
