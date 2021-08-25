using BL;
using BL.interfaces;
using BL.Models;
using DBL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBaseRepository<Book> Books { get; private set; }
        public IBaseRepository<BorrowedBooks> BorrowedBooks { get; private set; }

        public IBaseRepository<Borrower> Borrowers { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;

            Books = new BaseRepository<Book>(_context);
            Borrowers = new BaseRepository<Borrower>(_context);
            BorrowedBooks = new BaseRepository<BorrowedBooks>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
