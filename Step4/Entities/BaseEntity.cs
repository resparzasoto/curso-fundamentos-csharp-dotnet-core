namespace CoreSchool.Entities
{
	public class BaseEntity
	{
		public string UniqueId { get; private set; }

		public string Name { get; set; }

		public BaseEntity()
		{
			UniqueId = Guid.NewGuid().ToString();
		}
	}
}