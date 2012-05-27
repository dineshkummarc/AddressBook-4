using System.Data.Entity;
using System.Linq;

namespace AddressBook.Models
{
	public class AddressBookContextInitializer : DropCreateDatabaseIfModelChanges<AddressBookContext>
	{
		#region Non public

		protected override void Seed(AddressBookContext context)
		{
			base.Seed(context);

			SeedCountries(context);
			SeedPeople(context);
		}

		private void SeedCountries(AddressBookContext context)
		{
			context.Countries.Add(new Country { Name = "Afghanistan" });
			context.Countries.Add(new Country { Name = "Akrotiri" });
			context.Countries.Add(new Country { Name = "Albania" });
			context.Countries.Add(new Country { Name = "Algeria" });
			context.Countries.Add(new Country { Name = "American Samoa" });
			context.Countries.Add(new Country { Name = "Andorra" });
			context.Countries.Add(new Country { Name = "Angola" });
			context.Countries.Add(new Country { Name = "Anguilla" });
			context.Countries.Add(new Country { Name = "Antarctica" });
			context.Countries.Add(new Country { Name = "Antigua and Barbuda" });
			context.Countries.Add(new Country { Name = "Arctic Ocean" });
			context.Countries.Add(new Country { Name = "Argentina" });
			context.Countries.Add(new Country { Name = "Armenia" });
			context.Countries.Add(new Country { Name = "Aruba" });
			context.Countries.Add(new Country { Name = "Ashmore and Cartier Islands" });
			context.Countries.Add(new Country { Name = "Atlantic Ocean" });
			context.Countries.Add(new Country { Name = "Australia" });
			context.Countries.Add(new Country { Name = "Austria" });
			context.Countries.Add(new Country { Name = "Azerbaijan" });
			context.Countries.Add(new Country { Name = "Bahamas, The" });
			context.Countries.Add(new Country { Name = "Bahrain" });
			context.Countries.Add(new Country { Name = "Baker Island" });
			context.Countries.Add(new Country { Name = "Bangladesh" });
			context.Countries.Add(new Country { Name = "Barbados" });
			context.Countries.Add(new Country { Name = "Belarus" });
			context.Countries.Add(new Country { Name = "Belgium" });
			context.Countries.Add(new Country { Name = "Belize" });
			context.Countries.Add(new Country { Name = "Benin" });
			context.Countries.Add(new Country { Name = "Bermuda" });
			context.Countries.Add(new Country { Name = "Bhutan" });
			context.Countries.Add(new Country { Name = "Bolivia" });
			context.Countries.Add(new Country { Name = "Bosnia and Herzegovina" });
			context.Countries.Add(new Country { Name = "Botswana" });
			context.Countries.Add(new Country { Name = "Bouvet Island" });
			context.Countries.Add(new Country { Name = "Brazil" });
			context.Countries.Add(new Country { Name = "British Indian Ocean Territory" });
			context.Countries.Add(new Country { Name = "British Virgin Islands" });
			context.Countries.Add(new Country { Name = "Brunei" });
			context.Countries.Add(new Country { Name = "Bulgaria" });
			context.Countries.Add(new Country { Name = "Burkina Faso" });
			context.Countries.Add(new Country { Name = "Burma" });
			context.Countries.Add(new Country { Name = "Burundi" });
			context.Countries.Add(new Country { Name = "Cambodia" });
			context.Countries.Add(new Country { Name = "Cameroon" });
			context.Countries.Add(new Country { Name = "Canada" });
			context.Countries.Add(new Country { Name = "Cape Verde" });
			context.Countries.Add(new Country { Name = "Cayman Islands" });
			context.Countries.Add(new Country { Name = "Central African Republic" });
			context.Countries.Add(new Country { Name = "Chad" });
			context.Countries.Add(new Country { Name = "Chile" });
			context.Countries.Add(new Country { Name = "China" });
			context.Countries.Add(new Country { Name = "Christmas Island" });
			context.Countries.Add(new Country { Name = "Clipperton Island" });
			context.Countries.Add(new Country { Name = "Cocos (Keeling) Islands" });
			context.Countries.Add(new Country { Name = "Colombia" });
			context.Countries.Add(new Country { Name = "Comoros" });
			context.Countries.Add(new Country { Name = "Congo, Democratic Republic of the" });
			context.Countries.Add(new Country { Name = "Congo, Republic of the" });
			context.Countries.Add(new Country { Name = "Cook Islands" });
			context.Countries.Add(new Country { Name = "Coral Sea Islands" });
			context.Countries.Add(new Country { Name = "Costa Rica" });
			context.Countries.Add(new Country { Name = "Cote d'Ivoire" });
			context.Countries.Add(new Country { Name = "Croatia" });
			context.Countries.Add(new Country { Name = "Cuba" });
			context.Countries.Add(new Country { Name = "Curacao" });
			context.Countries.Add(new Country { Name = "Cyprus" });
			context.Countries.Add(new Country { Name = "Czech Republic" });
			context.Countries.Add(new Country { Name = "Denmark" });
			context.Countries.Add(new Country { Name = "Dhekelia" });
			context.Countries.Add(new Country { Name = "Djibouti" });
			context.Countries.Add(new Country { Name = "Dominica" });
			context.Countries.Add(new Country { Name = "Dominican Republic" });
			context.Countries.Add(new Country { Name = "Ecuador" });
			context.Countries.Add(new Country { Name = "Egypt" });
			context.Countries.Add(new Country { Name = "El Salvador" });
			context.Countries.Add(new Country { Name = "Equatorial Guinea" });
			context.Countries.Add(new Country { Name = "Eritrea" });
			context.Countries.Add(new Country { Name = "Estonia" });
			context.Countries.Add(new Country { Name = "Ethiopia" });
			context.Countries.Add(new Country { Name = "Falkland Islands (Islas Malvinas)" });
			context.Countries.Add(new Country { Name = "Faroe Islands" });
			context.Countries.Add(new Country { Name = "Fiji" });
			context.Countries.Add(new Country { Name = "Finland" });
			context.Countries.Add(new Country { Name = "France" });
			context.Countries.Add(new Country { Name = "French Polynesia" });
			context.Countries.Add(new Country { Name = "French Southern and Antarctic Lands" });
			context.Countries.Add(new Country { Name = "Gabon" });
			context.Countries.Add(new Country { Name = "Gambia, The" });
			context.Countries.Add(new Country { Name = "Gaza Strip" });
			context.Countries.Add(new Country { Name = "Georgia" });
			context.Countries.Add(new Country { Name = "Germany" });
			context.Countries.Add(new Country { Name = "Ghana" });
			context.Countries.Add(new Country { Name = "Gibraltar" });
			context.Countries.Add(new Country { Name = "Greece" });
			context.Countries.Add(new Country { Name = "Greenland" });
			context.Countries.Add(new Country { Name = "Grenada" });
			context.Countries.Add(new Country { Name = "Guam" });
			context.Countries.Add(new Country { Name = "Guatemala" });
			context.Countries.Add(new Country { Name = "Guernsey" });
			context.Countries.Add(new Country { Name = "Guinea" });
			context.Countries.Add(new Country { Name = "Guinea-Bissau" });
			context.Countries.Add(new Country { Name = "Guyana" });
			context.Countries.Add(new Country { Name = "Haiti" });
			context.Countries.Add(new Country { Name = "Heard Island and McDonald Islands" });
			context.Countries.Add(new Country { Name = "Holy See (Vatican City)" });
			context.Countries.Add(new Country { Name = "Honduras" });
			context.Countries.Add(new Country { Name = "Hong Kong" });
			context.Countries.Add(new Country { Name = "Howland Island" });
			context.Countries.Add(new Country { Name = "Hungary" });
			context.Countries.Add(new Country { Name = "Iceland" });
			context.Countries.Add(new Country { Name = "India" });
			context.Countries.Add(new Country { Name = "Indian Ocean" });
			context.Countries.Add(new Country { Name = "Indonesia" });
			context.Countries.Add(new Country { Name = "Iran" });
			context.Countries.Add(new Country { Name = "Iraq" });
			context.Countries.Add(new Country { Name = "Ireland" });
			context.Countries.Add(new Country { Name = "Isle of Man" });
			context.Countries.Add(new Country { Name = "Israel" });
			context.Countries.Add(new Country { Name = "Italy" });
			context.Countries.Add(new Country { Name = "Jamaica" });
			context.Countries.Add(new Country { Name = "Jan Mayen" });
			context.Countries.Add(new Country { Name = "Japan" });
			context.Countries.Add(new Country { Name = "Jarvis Island" });
			context.Countries.Add(new Country { Name = "Jersey" });
			context.Countries.Add(new Country { Name = "Johnston Atoll" });
			context.Countries.Add(new Country { Name = "Jordan" });
			context.Countries.Add(new Country { Name = "Kazakhstan" });
			context.Countries.Add(new Country { Name = "Kenya" });
			context.Countries.Add(new Country { Name = "Kingman Reef" });
			context.Countries.Add(new Country { Name = "Kiribati" });
			context.Countries.Add(new Country { Name = "Korea, North" });
			context.Countries.Add(new Country { Name = "Korea, South" });
			context.Countries.Add(new Country { Name = "Kosovo" });
			context.Countries.Add(new Country { Name = "Kuwait" });
			context.Countries.Add(new Country { Name = "Kyrgyzstan" });
			context.Countries.Add(new Country { Name = "Laos" });
			context.Countries.Add(new Country { Name = "Latvia" });
			context.Countries.Add(new Country { Name = "Lebanon" });
			context.Countries.Add(new Country { Name = "Lesotho" });
			context.Countries.Add(new Country { Name = "Liberia" });
			context.Countries.Add(new Country { Name = "Libya" });
			context.Countries.Add(new Country { Name = "Liechtenstein" });
			context.Countries.Add(new Country { Name = "Lithuania" });
			context.Countries.Add(new Country { Name = "Luxembourg" });
			context.Countries.Add(new Country { Name = "Macau" });
			context.Countries.Add(new Country { Name = "Macedonia" });
			context.Countries.Add(new Country { Name = "Madagascar" });
			context.Countries.Add(new Country { Name = "Malawi" });
			context.Countries.Add(new Country { Name = "Malaysia" });
			context.Countries.Add(new Country { Name = "Maldives" });
			context.Countries.Add(new Country { Name = "Mali" });
			context.Countries.Add(new Country { Name = "Malta" });
			context.Countries.Add(new Country { Name = "Marshall Islands" });
			context.Countries.Add(new Country { Name = "Mauritania" });
			context.Countries.Add(new Country { Name = "Mauritius" });
			context.Countries.Add(new Country { Name = "Mexico" });
			context.Countries.Add(new Country { Name = "Micronesia, Federated States of" });
			context.Countries.Add(new Country { Name = "Midway Islands" });
			context.Countries.Add(new Country { Name = "Moldova" });
			context.Countries.Add(new Country { Name = "Monaco" });
			context.Countries.Add(new Country { Name = "Mongolia" });
			context.Countries.Add(new Country { Name = "Montenegro" });
			context.Countries.Add(new Country { Name = "Montserrat" });
			context.Countries.Add(new Country { Name = "Morocco" });
			context.Countries.Add(new Country { Name = "Mozambique" });
			context.Countries.Add(new Country { Name = "Namibia" });
			context.Countries.Add(new Country { Name = "Nauru" });
			context.Countries.Add(new Country { Name = "Navassa Island" });
			context.Countries.Add(new Country { Name = "Nepal" });
			context.Countries.Add(new Country { Name = "Netherlands" });
			context.Countries.Add(new Country { Name = "New Caledonia" });
			context.Countries.Add(new Country { Name = "New Zealand" });
			context.Countries.Add(new Country { Name = "Nicaragua" });
			context.Countries.Add(new Country { Name = "Niger" });
			context.Countries.Add(new Country { Name = "Nigeria" });
			context.Countries.Add(new Country { Name = "Niue" });
			context.Countries.Add(new Country { Name = "Norfolk Island" });
			context.Countries.Add(new Country { Name = "Northern Mariana Islands" });
			context.Countries.Add(new Country { Name = "Norway" });
			context.Countries.Add(new Country { Name = "Oman" });
			context.Countries.Add(new Country { Name = "Pacific Ocean" });
			context.Countries.Add(new Country { Name = "Pakistan" });
			context.Countries.Add(new Country { Name = "Palau" });
			context.Countries.Add(new Country { Name = "Palmyra Atoll" });
			context.Countries.Add(new Country { Name = "Panama" });
			context.Countries.Add(new Country { Name = "Papua New Guinea" });
			context.Countries.Add(new Country { Name = "Paracel Islands" });
			context.Countries.Add(new Country { Name = "Paraguay" });
			context.Countries.Add(new Country { Name = "Peru" });
			context.Countries.Add(new Country { Name = "Philippines" });
			context.Countries.Add(new Country { Name = "Pitcairn Islands" });
			context.Countries.Add(new Country { Name = "Poland" });
			context.Countries.Add(new Country { Name = "Portugal" });
			context.Countries.Add(new Country { Name = "Puerto Rico" });
			context.Countries.Add(new Country { Name = "Qatar" });
			context.Countries.Add(new Country { Name = "Romania" });
			context.Countries.Add(new Country { Name = "Russia" });
			context.Countries.Add(new Country { Name = "Rwanda" });
			context.Countries.Add(new Country { Name = "Saint Barthelemy" });
			context.Countries.Add(new Country { Name = "Saint Helena, Ascension, and Tristan da Cunha" });
			context.Countries.Add(new Country { Name = "Saint Kitts and Nevis" });
			context.Countries.Add(new Country { Name = "Saint Lucia" });
			context.Countries.Add(new Country { Name = "Saint Martin" });
			context.Countries.Add(new Country { Name = "Saint Pierre and Miquelon" });
			context.Countries.Add(new Country { Name = "Saint Vincent and the Grenadines" });
			context.Countries.Add(new Country { Name = "Samoa" });
			context.Countries.Add(new Country { Name = "San Marino" });
			context.Countries.Add(new Country { Name = "Sao Tome and Principe" });
			context.Countries.Add(new Country { Name = "Saudi Arabia" });
			context.Countries.Add(new Country { Name = "Senegal" });
			context.Countries.Add(new Country { Name = "Serbia" });
			context.Countries.Add(new Country { Name = "Seychelles" });
			context.Countries.Add(new Country { Name = "Sierra Leone" });
			context.Countries.Add(new Country { Name = "Singapore" });
			context.Countries.Add(new Country { Name = "Sint Maarten" });
			context.Countries.Add(new Country { Name = "Slovakia" });
			context.Countries.Add(new Country { Name = "Slovenia" });
			context.Countries.Add(new Country { Name = "Solomon Islands" });
			context.Countries.Add(new Country { Name = "Somalia" });
			context.Countries.Add(new Country { Name = "South Africa" });
			context.Countries.Add(new Country { Name = "South Georgia and South Sandwich Islands" });
			context.Countries.Add(new Country { Name = "Southern Ocean" });
			context.Countries.Add(new Country { Name = "South Sudan" });
			context.Countries.Add(new Country { Name = "Spain" });
			context.Countries.Add(new Country { Name = "Spratly Islands" });
			context.Countries.Add(new Country { Name = "Sri Lanka" });
			context.Countries.Add(new Country { Name = "Sudan" });
			context.Countries.Add(new Country { Name = "Suriname" });
			context.Countries.Add(new Country { Name = "Svalbard" });
			context.Countries.Add(new Country { Name = "Swaziland" });
			context.Countries.Add(new Country { Name = "Sweden" });
			context.Countries.Add(new Country { Name = "Switzerland" });
			context.Countries.Add(new Country { Name = "Syria" });
			context.Countries.Add(new Country { Name = "Taiwan" });
			context.Countries.Add(new Country { Name = "Tajikistan" });
			context.Countries.Add(new Country { Name = "Tanzania" });
			context.Countries.Add(new Country { Name = "Thailand" });
			context.Countries.Add(new Country { Name = "Timor-Leste" });
			context.Countries.Add(new Country { Name = "Togo" });
			context.Countries.Add(new Country { Name = "Tokelau" });
			context.Countries.Add(new Country { Name = "Tonga" });
			context.Countries.Add(new Country { Name = "Trinidad and Tobago" });
			context.Countries.Add(new Country { Name = "Tunisia" });
			context.Countries.Add(new Country { Name = "Turkey" });
			context.Countries.Add(new Country { Name = "Turkmenistan" });
			context.Countries.Add(new Country { Name = "Turks and Caicos Islands" });
			context.Countries.Add(new Country { Name = "Tuvalu" });
			context.Countries.Add(new Country { Name = "Uganda" });
			context.Countries.Add(new Country { Name = "Ukraine" });
			context.Countries.Add(new Country { Name = "United Arab Emirates" });
			context.Countries.Add(new Country { Name = "United Kingdom" });
			context.Countries.Add(new Country { Name = "United States" });
			context.Countries.Add(new Country { Name = "United States Pacific Island Wildlife Refuges" });
			context.Countries.Add(new Country { Name = "Uruguay" });
			context.Countries.Add(new Country { Name = "Uzbekistan" });
			context.Countries.Add(new Country { Name = "Vanuatu" });
			context.Countries.Add(new Country { Name = "Vatican City" });
			context.Countries.Add(new Country { Name = "Venezuela" });
			context.Countries.Add(new Country { Name = "Vietnam" });
			context.Countries.Add(new Country { Name = "Virgin Islands" });
			context.Countries.Add(new Country { Name = "Wake Island" });
			context.Countries.Add(new Country { Name = "Wallis and Futuna" });
			context.Countries.Add(new Country { Name = "West Bank" });
			context.Countries.Add(new Country { Name = "Western Sahara" });
			context.Countries.Add(new Country { Name = "Yemen" });
			context.Countries.Add(new Country { Name = "Zambia" });
			context.Countries.Add(new Country { Name = "Zimbabwe" });

			context.SaveChanges();
		}

		private void SeedPeople(AddressBookContext context)
		{
			var person = new Person
			{
				FirstName = "Patrick",
				LastName = "Durand",
				Title = (int)Title.Mr,
				Email = "p.durand@yahoo.fr"
			};

			var address = new Address
			{
				AddressLine1 = "12 rue du Général de Gaulle",
				City = "Paris",
				PostCode = "75 001",
				Country = context.Countries.Single(c => c.Name == "France")
			};

			person.Addresses.Add(address);

			address = new Address
			{
				AddressLine1 = "Rua Conde de Redondo 79",
				City = "LISBOA CODEX",
				PostCode = "1167-921",
				Country = context.Countries.Single(c => c.Name == "Portugal")
			};

			person.Addresses.Add(address);
			context.People.Add(person);

			person = new Person
			{
				FirstName = "Jose",
				LastName = "Bloggs",
				Title = (int)Title.Mr,
				Email = "jose87@gmail.com"
			};

			address = new Address
			{
				AddressLine1 = "AVENIDA DA LIBERDADE 100",
				City = "LISBOA",
				PostCode = "1269-121",
				Country = context.Countries.Single(c => c.Name == "Portugal")
			};

			person.Addresses.Add(address);
			context.People.Add(person);

			person = new Person
			{
				FirstName = "Eberhard",
				LastName = "Wellhausen",
				Title = (int)Title.Mr,
				Email = "eberhard.w@gmail.com"
			};

			address = new Address
			{
				AddressLine1 = "Wittekindshof",
				AddressLine2 = "Schulstrasse 4",
				City = "Bad Oyenhausen",
				PostCode = "32547",
				Country = context.Countries.Single(c => c.Name == "Germany")
			};

			person.Addresses.Add(address);
			context.People.Add(person);

			person = new Person
			{
				FirstName = "Ivanov",
				SecondName = "Alexander",
				LastName = "Ivanovitch",
				Title = (int)Title.Mr,
				Email = "i.ivanovitch@russiatoday.ru"
			};

			address = new Address
			{
				AddressLine1 = "ul. Lesnaya d. 5, kv. 176",
				City = "g. MOSKVA",
				PostCode = "123456",
				Country = context.Countries.Single(c => c.Name == "Russia")
			};

			person.Addresses.Add(address);
			context.People.Add(person);

			person = new Person
			{
				FirstName = "Petrov",
				SecondName = "Ivan",
				LastName = "Sergeevich",
				Title = (int)Title.Mr,
				Email = "p.sergeevich@russiatoday.ru"
			};

			address = new Address
			{
				AddressLine1 = "ul. Lesnaya d. 5",
				AddressLine2 = "pos. Lesnoe",
				AddressLine3 = "ALEKSCEVSKTY r-n",
				PostCode = "247112",
				State = "VORONEJSKAYA obl",
				Country = context.Countries.Single(c => c.Name == "Russia")
			};

			person.Addresses.Add(address);
			context.People.Add(person);

			context.SaveChanges();
		}

		#endregion Non public
	}
}