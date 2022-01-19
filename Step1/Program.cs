using CoreSchool.Entities;

namespace Step1
{
	class Program
	{
		static void Main(string[] args) {
			School school = new School("Platzi Academy", 2012);
			
			school.Country =  "Colombia";
			school.City = "Bogota";

			Console.WriteLine(school.Name);
		}
	}
}
