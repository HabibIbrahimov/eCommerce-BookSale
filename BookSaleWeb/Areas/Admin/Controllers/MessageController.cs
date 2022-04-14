using BookSale.DataAccess;
using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using BookSale.Models.ViewModels;
using BookSale.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookSaleWeb.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class MessageController : Controller
    {
        private readonly ILogger<MessageController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public MessageController(ILogger<MessageController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {
            IEnumerable<Message> messages = _unitOfWork.Message.GetAll(includeProperties: "User");

            return View(messages);
        }

       

    }
}
