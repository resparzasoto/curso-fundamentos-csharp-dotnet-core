using CoreSchool.Entities;

namespace Step1
{
	class Program
	{
		static void Main(string[] args) {
			School school = new School("Platzi Academy", 2012, SchoolTypes.Elementary, city: "Bogota", country: "Colombia");

			Console.WriteLine(school);
		}
	}
}
