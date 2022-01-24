namespace CoreSchool.Entities
{
	class School
	{
		string? name;
		public string Name
		{
			get { return "Copia " + name; }

			set { name = value.ToUpper(); }
		}
		public int FoundationYear { get; set; }
		public string? Country { get; set; }
		public string? City { get; set; }
		public SchoolTypes SchoolType { get; set; }

		public Course[] Courses { get; set; }
		public School(string name, int foundationYear) => (Name, FoundationYear) = (name, foundationYear);
		public School(string name, int foundationYear, SchoolTypes schoolType, string country = "", string city = "")
		{
			(Name, FoundationYear) = (name, foundationYear);
			Country = country;
			City = city;
		}

		public override string ToString()
		{

			return $"Name: \"{Name}\", Type: {SchoolType}{System.Environment.NewLine}Country: {Country}, City: {City}";
		}
	}
}