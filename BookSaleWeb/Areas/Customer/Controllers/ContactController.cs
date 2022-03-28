using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(ILogger<ContactController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
