using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        private ApplicationDbContext _db;

        public ContactRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Contact obj)
        {
            _db.Contacts.Update(obj);
        }
    }
}
