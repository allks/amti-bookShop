using amti_bookShop.Data.Interfaces;
using amti_bookShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data.Repository {
  public class CategoryRepository : IBooksCategory {
    private readonly AppDBContent appDBContent;
    public CategoryRepository(AppDBContent appDBContent) {
      this.appDBContent = appDBContent;
    }
    public IEnumerable<Category> AllCategories => appDBContent.Category;
  }
}
