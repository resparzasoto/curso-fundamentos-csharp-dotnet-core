namespace CoreSchool.Entities
{
	public class Course : BaseEntity
	{
		public JourneyTypes Journey { get; set; } = JourneyTypes.Morning;

		public List<Signature> Signatures { get; set; } = new List<Signature>();

		public List<Student> Students { get; set; } = new List<Student>();

		public Course() : base()
		{
		}
	}
}