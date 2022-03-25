using BookSale.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BookSaleWeb.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class TestimonialsController : Controller
    {
        private readonly ILogger<TestimonialsController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public TestimonialsController(ILogger<TestimonialsController> logger, IUnitOfWork unitOfWork)
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
