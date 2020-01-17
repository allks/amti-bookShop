using amti_bookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data.Interfaces {
	public interface IAllBooks {
		IEnumerable<Book> Books { get; }
		IEnumerable<Book> getFavBooks { get; }
		Book getObjectBook(int bookId);
	}
}
