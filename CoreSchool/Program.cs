using System;

namespace CoreSchool
{
	class School
	{
		public string name;
		public string address;
		public int foundationYear;
		public string CEO;

		public void Ring() {
			Console.Beep(1000, 1000);
		}
	}

	class Program
	{
		static void Main(string[] args) {
			School mySchool = new School();
			
			mySchool.name = "Platzi Academy";
			mySchool.address = "Cr 9 Calle 72";
			mySchool.foundationYear = 2012;

			Console.WriteLine("Timbre");

			mySchool.Ring();
		}
	}
}