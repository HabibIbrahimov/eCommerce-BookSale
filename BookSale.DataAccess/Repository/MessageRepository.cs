using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        private ApplicationDbContext _db;

        public MessageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Message obj)
        {
            _db.Messages.Update(obj);
        }
    }
}
