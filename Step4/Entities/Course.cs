namespace CoreSchool.Entities
{
	public class Course : BaseEntity
	{
		public JourneyTypes Journey { get; set; } = JourneyTypes.Morning;

		public List<Signature> Signatures { get; set; }

		public List<Student> Students { get; set; }

		public Course() : base()
		{
		}
	}
}