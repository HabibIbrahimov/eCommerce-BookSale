using BookSale.DataAccess;
using BookSale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookSaleWeb.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public ProductsViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> products = _db.Products.Include(p => p.Category).Take(6).ToList();
            return View (await Task.FromResult(products));
        }
    }
}
