using System.Data.Entity;

namespace AddressBook.Models
{
	public class AddressBookContext : DbContext
	{
		#region Properties

		public DbSet<Address> Addresses { get; set; }

		public DbSet<Country> Countries { get; set; }

		public DbSet<Person> People { get; set; }

		#endregion Properties

		#region Constructors

		public AddressBookContext()
			: base("AddressBook")
		{
		}

		#endregion Constructors
	}
}