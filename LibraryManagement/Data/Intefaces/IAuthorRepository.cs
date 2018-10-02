using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data.Model;

namespace LibraryManagement.Data.Intefaces
{
	public interface IAuthorRepository : IRepository<Author>
	{
		IEnumerable<Author> GetAllWithBooks();
		Author GetWithBooks(int id);
	}
}
