namespace Domain.SeedWork;

public abstract class Entity : object
{
	public Entity() : base()
	{
		// دستور ذیل غلط می‌باشد
		//Id = new System.Guid();

		Id = System.Guid.NewGuid();
	}

	// **********
	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//public int Id { get; private set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//public long Id { get; private set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
	//public System.Guid Id { get; private set; }
	// **********

	// **********
	//[System.ComponentModel.DataAnnotations.Key]

	//[System.ComponentModel.Browsable(browsable: false)]

	//[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
	//	(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	//public System.Guid Id { get; private set; }
	// **********

	// **********
	[System.ComponentModel.DataAnnotations.Key]

	[System.ComponentModel.Browsable(browsable: false)]

	[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
		(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
	public System.Guid Id { get; private init; }
	// **********
}
