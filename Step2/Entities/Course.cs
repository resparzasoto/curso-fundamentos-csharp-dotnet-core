namespace CoreSchool.Entities
{
    public class Course
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public JourneyTypes Journey { get; set; }

        public Course()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}