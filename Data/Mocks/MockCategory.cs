using amti_bookShop.Data.Interfaces;
using amti_bookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data.Mocks {
    public class MockCategory : IBooksCategory {
        public IEnumerable<Category> AllCategories {
            get  {
                return new List<Category> {
                    new Category { categoryName = "Фантастика", desc = "Лучшая фантастика всех времён" },
                    new Category { categoryName = "Научная литература", desc = "Совокупность письменных трудов, которые созданы в результате исследований" }
                };
            }
        }
    }
}
