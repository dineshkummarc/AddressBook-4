namespace AddressBook.Models
{
	public class Address
	{
		#region Properties

		public virtual int Id { get; set; }

		public virtual string AddressLine1 { get; set; }

		public virtual string AddressLine2 { get; set; }

		public virtual string AddressLine3 { get; set; }

		public virtual string City { get; set; }

		public virtual string PostCode { get; set; }

		public virtual string State { get; set; }

		public virtual Country Country { get; set; }

		#endregion Properties

		#region Constructors

		public Address()
		{
		}

		#endregion Constructors
	}
}