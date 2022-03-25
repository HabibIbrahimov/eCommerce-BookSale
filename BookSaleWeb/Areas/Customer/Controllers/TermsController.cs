using BookSale.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TermsController : Controller
    {
        private readonly ILogger<TermsController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public TermsController(ILogger<TermsController> logger, IUnitOfWork unitOfWork)
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
