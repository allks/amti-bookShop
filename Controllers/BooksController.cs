using amti_bookShop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Controllers {
    public class BooksController : Controller {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks, IBooksCategory iBooksCat) {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }

        public ViewResult List() {
            var books = _allBooks.Books;
            return View(books);
        }
    }
}
