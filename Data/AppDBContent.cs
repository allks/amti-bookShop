using amti_bookShop.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data {
  public class AppDBContent : DbContext {
    public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {

    }
    public DbSet<Book> Book { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<ShopCartItem> ShopCartItem { get; set; }
  }
}