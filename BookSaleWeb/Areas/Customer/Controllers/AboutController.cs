using BookSale.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class AboutController : Controller
    {
        private readonly ILogger<AboutController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public AboutController(ILogger<AboutController> logger, IUnitOfWork unitOfWork)
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
