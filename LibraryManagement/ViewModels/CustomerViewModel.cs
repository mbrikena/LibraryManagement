using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data.Model;

namespace LibraryManagement.ViewModels
{
	public class CustomerViewModel
	{
		public Customer Customer { get; set; }
		public int BookCount { get; set; }
	}
}
