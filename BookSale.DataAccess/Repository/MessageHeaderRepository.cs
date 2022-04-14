using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository
{
    public class MessageHeaderRepository : Repository<MessageHeader>, IMessageHeaderRepository
    {
        private ApplicationDbContext _db;

        public MessageHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(MessageHeader obj)
        {
            _db.MessageHeaders.Update(obj);
        }
    }
}
