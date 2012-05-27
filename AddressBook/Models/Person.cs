using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
	public class Person
	{
		#region Properties

		public virtual int Id { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string SecondName { get; set; }

		public virtual string LastName { get; set; }

		public virtual int Title { get; set; }

		public virtual string Email { get; set; }

		public ICollection<Address> Addresses { get; set; }

		#endregion Properties

		#region Constructors

		public Person()
		{
			Addresses = new List<Address>();
		}

		#endregion Constructors
	}
}