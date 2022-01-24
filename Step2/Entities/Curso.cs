namespace CoreSchool.Entities
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public JourneyTypes Journey { get; set; }

        public Curso()
        {
            UniqueId = Guid.NewGuid().ToString();
        }
    }
}