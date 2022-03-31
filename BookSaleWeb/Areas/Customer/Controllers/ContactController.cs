using BookSale.DataAccess;
using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using BookSale.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            
            ContactVM contactVM = new ContactVM();
            if (User.Identity.IsAuthenticated)
            {
                contactVM.User = await _userManager.FindByIdAsync(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            }
            return View(contactVM);
        }

       
    }
}
