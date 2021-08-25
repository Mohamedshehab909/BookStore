using BL.interfaces;
using BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Book> Books { get; }
        IBaseRepository<Borrower> Borrowers { get; }
        IBaseRepository<BorrowedBooks> BorrowedBooks { get; }

        int Complete();

    }
}
