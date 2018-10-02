using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data.Model;

namespace LibraryManagement.ViewModels
{
	public class BookViewModel
	{
		public Book Book { get; set; }

		public IEnumerable<Author> Authors { get; set; }
		
	}
}
