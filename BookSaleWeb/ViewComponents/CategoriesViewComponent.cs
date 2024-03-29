﻿using BookSale.DataAccess;
using BookSale.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookSaleWeb.ViewComponents
{

    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public CategoriesViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = _db.Categories.Take(7).ToList();
            return View(await Task.FromResult(categories));
        }
    }
}
