namespace Domain;

public class User : SeedWork.Entity
{
	#region Constructor
	//public User() : base()
	//{
	//}

	public User(string username, string password) : base()
	{
		Username = username;
		Password = password;
	}
	#endregion /Constructor

	#region Properties

	#region public bool IsAdmin { get; set; }
	/// <summary>
	/// ادمین است
	/// </summary>
	[System.ComponentModel.DisplayName
		(displayName: "Admin")]
	public bool IsAdmin { get; set; }
	#endregion /public bool IsAdmin { get; set; }

	#region public bool IsActive { get; set; }
	/// <summary>
	/// فعال است
	/// </summary>
	[System.ComponentModel.DisplayName
		(displayName: "Active")]
	public bool IsActive { get; set; }
	#endregion /public bool IsActive { get; set; }

	#region public string Username { get; set; }
	//[System.ComponentModel.DataAnnotations.MaxLength
	//	(length: 20)]

	//[System.ComponentModel.DataAnnotations.StringLength
	//	(maximumLength: 20)]

	//[System.ComponentModel.DataAnnotations.MinLength
	//	(length: 6)]

	[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 20, MinimumLength = 6)]

	//[System.ComponentModel.DataAnnotations.Required]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
	public string Username { get; set; }
	#endregion /public string Username { get; set; }

	#region public string Password { get; set; }
	/// <summary>
	/// گذرواژه
	/// </summary>
	[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 20, MinimumLength = 8)]

	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

	[System.ComponentModel.Browsable (false)]
	public string Password { get; set; }
	#endregion /public string Password { get; set; }

	#region public string? FullName { get; set; }
	[System.ComponentModel.DisplayName
		(displayName: "Full Name")]

	[System.ComponentModel.DataAnnotations.Display
		(Name = "Full Name")]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 50)]
	public string? FullName { get; set; }
	#endregion /public string? FullName { get; set; }

	#region public string? Description { get; set; }
	/// <summary>
	/// توضیحات
	/// </summary>
	[System.ComponentModel.Browsable(browsable: false)]
	public string? Description { get; set; }
	#endregion /public string? Description { get; set; }

	#endregion /Properties
}
