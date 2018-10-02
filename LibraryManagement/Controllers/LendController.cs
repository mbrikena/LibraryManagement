using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Data.Intefaces;
using LibraryManagement.Data.Repository;
using LibraryManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
	public class LendController : Controller
	{
		private readonly IBookRepository _bookRepository;
		private readonly ICustomerRepository _customerRepository;

		public LendController(IBookRepository bookRepository, ICustomerRepository customerRepository)
		{
			_bookRepository = bookRepository;
			_customerRepository = customerRepository;
		}

		[Route("Lend")]
		public IActionResult List()
		{
			var availableBooks = _bookRepository.FindWithAuthor(x => x.BorrowerId == 0);

			if (availableBooks.Count() == 0)
			{
				return View("Empty");
			}
			else
			{
				return View(availableBooks);
			}
		}

		public IActionResult LendBook(int bookId)
		{
			//load current book and all customers
			var lendVM = new LendviewModel()
			{
				Book = _bookRepository.GetById(bookId),
				Customers = _customerRepository.GetAll()
			};

			//send data to th elend view
			return View(lendVM);
		}

		[HttpPost]
		public IActionResult LendBook(LendviewModel lendviewModel)
		{
			var book = _bookRepository.GetById(lendviewModel.Book.BookId);

			var customer = _customerRepository.GetById(lendviewModel.Book.BorrowerId);

			book.Customer = customer;

			//redirect to the list view
			return RedirectToAction("List");
		}
	}
}
