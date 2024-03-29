﻿using BookSale.DataAccess.Repository.IRepository;
using BookSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSale.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product=new ProductRepository(_db); 
            Company=new CompanyRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
            Slider = new SliderRepository(_db);
            Contact = new ContactRepository(_db);
            Message=new MessageRepository(_db);
            MessageDetail = new MessageDetailRepository(_db);
            Author = new AuthorRepository(_db);
        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ICompanyRepository Company { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }
        public IOrderDetailRepository OrderDetail { get; private set; }
        public ISliderRepository Slider { get; private set; }
        public IContactRepository Contact { get; private set; }
        public IMessageRepository Message { get; private set; } 
        public IMessageDetailRepository MessageDetail { get; private set; }
        public IAuthorRepository Author { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
