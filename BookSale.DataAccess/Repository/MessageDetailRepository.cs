using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository
{
    public class MessageDetailRepository : Repository<MessageDetail>, IMessageDetailRepository
    {
        private ApplicationDbContext _db;

        public MessageDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(MessageDetail obj)
        {
            _db.MessageDetails.Update(obj);
        }
    }
}
