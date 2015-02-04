using CustomerModel;
using System;

namespace TestConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Customer customer = new Customer
			{
				CustomerId = 1,
				FirstName = "Jalpesh",
				LastName = "Vadgama"
			};

			Console.WriteLine("Firstname : {0}",customer.FirstName);
			Console.WriteLine("Lastname : {0}", customer.LastName);

		}
	}
}
