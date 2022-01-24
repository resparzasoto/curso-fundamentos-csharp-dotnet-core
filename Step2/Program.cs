using CoreSchool.Entities;

namespace Step2
{
	class Program
	{
		static void Main(string[] args) {
			School school = new School("Platzi Academy", 2012, SchoolTypes.Elementary, city: "Bogota", country: "Colombia");

			Curso curso1 = new Curso() {
				Name = "101",
			};

			Curso curso2 = new Curso() {
				Name = "201"
			};

			Curso curso3 = new Curso() {
				Name = "301"
			};

			Console.WriteLine(school);
			Console.WriteLine("================");
			Console.WriteLine($"{curso1.Name} , {curso1.UniqueId}");
			Console.WriteLine($"{curso2.Name} , {curso2.UniqueId}");
			Console.WriteLine($"{curso3}");
		}
	}
}
