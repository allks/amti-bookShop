using amti_bookShop.Data.Interfaces;
using amti_bookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data.Mocks {
    public class MockBooks : IAllBooks {
        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books {
            get {
                return new List<Book> {
                    new Book { 
                        name = "namebook", 
                        shortDesc = "", 
                        longDesc = "", 
                        img = "", 
                        price = 1500, 
                        isFavorite = true, 
                        available = true, 
                        Category =  _categoryBooks.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
