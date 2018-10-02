using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data.Model;

namespace LibraryManagement.ViewModels
{
	public class LendviewModel
	{
		public Book Book { get; set; }

		public IEnumerable<Customer> Customers { get; set; }
	}
}
