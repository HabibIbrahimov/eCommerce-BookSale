using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AuthorController : Controller
    {
        private readonly ILogger<AuthorController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorController(ILogger<AuthorController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            IEnumerable<Author> authors = _unitOfWork.Author.GetAll();
            return View(authors);
        }
    }
}
