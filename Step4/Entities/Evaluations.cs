namespace CoreSchool.Entities;

public class Evaluations : BaseEntity
{
	public Student Student { get; set; }

	public Signature Signature { get; set; }

	public float Value { get; set; }

	public Evaluations() : base()
	{
	}
}
