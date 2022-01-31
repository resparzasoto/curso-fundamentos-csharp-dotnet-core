namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public JourneyTypes Journey { get; set; } = JourneyTypes.Morning;

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}