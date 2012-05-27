namespace AddressBook.Models
{
	public class Country
	{
		#region Properties

		public virtual int Id { get; set; }

		public virtual string Name { get; set; }

		#endregion Properties

		#region Constructors

		public Country()
		{
		}

		#endregion Constructors
	}
}