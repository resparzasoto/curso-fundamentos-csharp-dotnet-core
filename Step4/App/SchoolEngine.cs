using CoreSchool.Entities;

namespace CoreSchool.App
{
	public class SchoolEngine
	{
		public School School { get; set; }

		public SchoolEngine()
		{
		}

		public void Initializing()
		{
			School = new School
			(
				"Platzi Academy",
				2012,
				SchoolTypes.Elementary,
				city: "Bogota",
				country: "Colombia"
			);

			School.Courses = new List<Course>()
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
				},
				new Course()
				{
					Name = "401",
					Journey = JourneyTypes.Afternoon,
				},
				new Course()
				{
					Name = "501",
					Journey = JourneyTypes.Afternoon,
				},
			};
		}
	}
}