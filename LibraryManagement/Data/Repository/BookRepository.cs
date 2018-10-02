using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement.Data.Intefaces;
using LibraryManagement.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Data.Repository
{
	public class BookRepository : Repository<Book>, IBookRepository
	{
		public BookRepository(LibraryDbContext context) : base(context)
		{

		}
		public IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate)
		{
			return _context.Books
				.Include(a => a.Author)
				.Where(predicate);
		}

		public IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate)
		{
			return _context.Books
				.Include(a => a.Author)
				.Include(a => a.Customer)
				.Where(predicate);
		}

		public IEnumerable<Book> GetAllWithAuthor()
		{
			return _context.Books
				.Include(a => a.Author);
		}
	}
}
