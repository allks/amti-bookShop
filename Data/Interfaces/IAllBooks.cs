using amti_bookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data.Interfaces {
    interface IAllBooks {
        IEnumerable<Book> Books { get; set; }
        IEnumerable<Book> getFavBooks { get; set; }
        Book getObjectBook(int bookId);
    }
}
