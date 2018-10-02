﻿using LibraryManagement.Data.Intefaces;
using LibraryManagement.Data.Model;

namespace LibraryManagement.Data.Repository
{
	public class CustomerRepository : Repository<Customer>, ICustomerRepository
	{
		public CustomerRepository(LibraryDbContext context) : base(context)
		{

		}
	}
}
