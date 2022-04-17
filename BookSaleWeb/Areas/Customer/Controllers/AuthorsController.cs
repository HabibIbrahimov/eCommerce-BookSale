using BookSale.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AuthorsController : Controller
    {
        private readonly ILogger<AuthorsController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorsController(ILogger<AuthorsController> logger, IUnitOfWork unitOfWork)
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
