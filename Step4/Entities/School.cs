namespace CoreSchool.Entities
{
	public class School
	{
		string name;
		public string Name
		{
			get { return "Copia " + name; }

			set { name = value.ToUpper(); }
		}
		public int FoundationYear { get; set; }
		public string Country { get; set; }
		public string City { get; set; }
		public SchoolTypes SchoolType { get; set; } = SchoolTypes.Elementary;

		public List<Course> Courses { get; set; } = new List<Course>();
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