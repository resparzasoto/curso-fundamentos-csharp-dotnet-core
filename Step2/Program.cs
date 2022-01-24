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
			PrintCourses(courses);
		}

		private static void PrintCourses(Course[] courses) {
			int counter = 0;

			while (counter < courses.Length)
			{
				Console.WriteLine($"Name {courses[counter]}, Id {courses[counter].UniqueId}");
				counter++;
			}
		}
	}
}
