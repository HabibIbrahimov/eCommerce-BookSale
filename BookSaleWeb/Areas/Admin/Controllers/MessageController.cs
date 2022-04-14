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

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var messageFromDbFirst = _unitOfWork.Message.GetFirstOrDefault(u => u.Id == id);

            if (messageFromDbFirst == null)
            {
                return NotFound();
            }

            return View(messageFromDbFirst);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _unitOfWork.Message.GetFirstOrDefault(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Message.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Message deleted successfully";
            return RedirectToAction("Index");

        }


    }
}
