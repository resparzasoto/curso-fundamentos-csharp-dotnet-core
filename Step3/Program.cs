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

			school.Courses = new List<Course>()
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

			school.Courses.Add(new Course() { Name = "102", Journey = JourneyTypes.Afternoon });
			school.Courses.Add(new Course() { Name = "202", Journey = JourneyTypes.Afternoon });

			var anotherCollection = new List<Course>()
			{
				new Course()
				{
					Name = "401",
				},
				new Course()
				{
					Name = "501"
				},
				new Course()
				{
					Name = "502"
				}
			};

			school.Courses.AddRange(anotherCollection);
			PrintCoursesSchool(school);

			Predicate<Course> match = MatchRemoveCourse;
			school.Courses.RemoveAll(match);

			Console.WriteLine("=====================");
			Console.WriteLine("Print then of remove");
			PrintCoursesSchool(school);
		}

		private static bool MatchRemoveCourse(Course course)
		{
			return course.Name == "301";
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
