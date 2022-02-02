namespace CoreSchool.Entities;

public class Evaluations : BaseEntity
{
	public Student Student { get; set; } = new Student();

	public Signature Signature { get; set; } = new Signature();

	public float Value { get; set; }

	public Evaluations() : base()
	{
	}
}
