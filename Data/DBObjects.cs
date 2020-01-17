using amti_bookShop.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace amti_bookShop.Data {
  public class DBObjects {
    public static void Initial(AppDBContent content) {
      if (!content.Category.Any())
        content.Category.AddRange(Categories.Select(c => c.Value));
      if (!content.Book.Any()) {
        content.AddRange(
					new Book {
						name = "Лабиринт Фавна",
						author = "Дель Т., Функе К.",
						descr = "В этой фантазии поистине эпического размаха читатель встретит мифических трикстеров и кровожадных чудовищ, жестоких солдат и отважных мятежников, и потерянную принцессу, не теряющую надежды отыскать дорогу домой...",
						img = "https://img-gorod.ru/27/763/2776336_detail.jpg",
						price = 1500,
						isFavorite = true,
						available = true,
						Category = Categories["Фантастика"]
					},
					new Book {
						name = "Ведьмак",
						author = "Сапковский А.",
						descr = "Одна из лучших фэнтези-саг за всю историю существования жанра.",
						img = "https://img-gorod.ru/23/126/2312670_detail.jpg",
						price = 2500,
						isFavorite = true,
						available = true,
						Category = Categories["Фантастика"]
					},
					new Book {
						name = "Очень странные миры",
						author = "Филенко Е.",
						descr = "Читателям приоткроют очень странные миры запутанных диалогов, становящихся все более увлекательными по мере их развития.",
						img = "https://img-gorod.ru/27/697/2769727_detail.jpg",
						price = 500,
						isFavorite = false,
						available = false,
						Category = Categories["Фантастика"]
					},
					new Book {
						name = "Биохимия человека",
						author = "Ершов Ю.",
						descr = "При подготовке настоящего учебника автор учитывал возросшие требования к теоретической подготовке студентов, а также предусмотрел соответствие и интеграцию с курсами общетеоретических и специальных дисциплин.",
						img = "https://img-gorod.ru/27/748/2774886_detail.jpg",
						price = 1200,
						isFavorite = false,
						available = true,
						Category = Categories["Научная литература"]
					},
					new Book {
						name = "Континуальная теория сейсмического микрорайонирования",
						author = "Алешин А.",
						descr = "Основными понятиями сейсмического микрорайонирования в России являются баллы и грунтовые категории, соответствующие дискретной структуре соотношения «сейсмическое воздействие - реакция грунта».",
						img = "https://img-gorod.ru/27/718/2771867_detail.jpg",
						price = 1950,
						isFavorite = true,
						available = true,
						Category = Categories["Научная литература"]
					},
					new Book {
						name = "Физическая химия",
						author = "Ярославцев А.",
						descr = "В книге рассматриваются первый и второй законы термодинамики, охарактеризованы связанные с ними основные понятия.",
						img = "https://img-gorod.ru/27/718/2771885_detail.jpg",
						price = 2300,
						isFavorite = false,
						available = false,
						Category = Categories["Научная литература"]
					}
				);
      }
			content.SaveChanges();
    }
    private static Dictionary<string, Category> category;
    public static Dictionary<string, Category> Categories {
      get {
        if(category == null) {
          var list = new Category[] {
            new Category { categoryName = "Фантастика", desc = "Лучшая фантастика всех времён" },
            new Category { categoryName = "Научная литература", desc = "Совокупность письменных трудов, которые созданы в результате исследований" }
          };
          category = new Dictionary<string, Category>();
          foreach (Category el in list)
            category.Add(el.categoryName, el);
        }
        return category;
      }
    }
  }
}
