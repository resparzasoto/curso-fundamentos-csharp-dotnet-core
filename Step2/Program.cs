using System.Runtime.InteropServices.ComTypes;
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

			Course[] courses = new Course[3];

			courses[0] = new Course()
			{
				Name = "101",
			};

			Course curso2 = new Course()
			{
				Name = "201"
			};

			courses[1] = curso2;

			courses[2] = new Course()
			{
				Name = "301"
			};

			Console.WriteLine(school);
			Console.WriteLine("================");
			PrintCoursesWhile(courses);
			Console.WriteLine("================");
			PrintCoursesDoWhile(courses);
			Console.WriteLine("================");
			PrintCoursesFor(courses);
			Console.WriteLine("================");
			PrintCoursesForeach(courses);
		}

		private static void PrintCoursesWhile(Course[] courses)
		{
			int counter = 0;

			while (counter < courses.Length)
			{
				Console.WriteLine($"Name {courses[counter].Name}, Id {courses[counter].UniqueId}");
				counter++;
			}
		}

		private static void PrintCoursesDoWhile(Course[] courses)
		{
			int counter = 0;

			do
			{
				Console.WriteLine($"Name {courses[counter].Name}, Id {courses[counter].UniqueId}");
				counter++;
			} while (counter < courses.Length);
		}

		private static void PrintCoursesFor(Course[] courses)
		{
			for (int i = 0; i < courses.Length; i++)
			{
				Console.WriteLine($"{nameof(Course.Name)} {courses[i].Name}, {nameof(Course.UniqueId)} {courses[i].UniqueId}");
			}
		}

		private static void PrintCoursesForeach(Course[] courses)
		{
			foreach (var course in courses)
			{
				Console.WriteLine($"{nameof(Course.Name)} {course.Name}, {nameof(Course.UniqueId)} {course.UniqueId}");
			}
		}
	}
}
