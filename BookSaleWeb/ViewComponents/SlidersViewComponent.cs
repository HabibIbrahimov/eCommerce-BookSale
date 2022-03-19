using BookSale.DataAccess;
using BookSale.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.ViewComponents
{
   
        public class SlidersViewComponent : ViewComponent
        {
            private readonly ApplicationDbContext _db;

            public SlidersViewComponent(ApplicationDbContext db)
            {
                _db = db;
            }
            public async Task<IViewComponentResult> InvokeAsync()
            {
               List<Slider> sliders = _db.Sliders.Take(3).ToList();
               return View(await Task.FromResult(sliders));

            }
        }
}
