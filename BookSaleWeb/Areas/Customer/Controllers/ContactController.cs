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
        private readonly ILogger<ContactController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(ILogger<ContactController> logger,IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
          
            return View();
        }

        [HttpPost]
        public IActionResult Message([FromForm] Message message)
        {
            if (User.Identity.IsAuthenticated)
            {
                Message newMessage = new Message();

                newMessage.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                newMessage.Title = message.Title;
                newMessage.Description = message.Description;
                _unitOfWork.Message.Add(newMessage);

                _unitOfWork.Save();

            }

            else
            {
                return RedirectToAction("Login", "Account");
            }



            return Ok(new { Message = "Success your send message" });
        }

    }
}
