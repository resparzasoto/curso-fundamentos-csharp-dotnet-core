using CoreSchool.App;
using CoreSchool.Entities;
using CoreSchool.Util;

namespace CoreSchool
{
	class Program
	{
		static void Main(string[] args)
		{
			SchoolEngine engine = new SchoolEngine();
			engine.Initializing();

			Printer.WriteTitle("WELCOME TO THE SCHOOL");
			Printer.Beep(10000, count: 10);

			PrintCoursesSchool(engine.School);
		}

		private static void PrintCoursesSchool(School school)
		{
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
