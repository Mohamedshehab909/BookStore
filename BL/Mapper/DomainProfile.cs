using AutoMapper;
using BL.Models;
using BL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            CreateMap<Book, BookVM>();
            CreateMap<BookVM, Book>();

            CreateMap<Borrower, BorrowerVM>();
            CreateMap<BorrowerVM, Borrower>();

            CreateMap<BorrowedBooks, BorrowedBooksVM>();
            CreateMap<BorrowedBooksVM, BorrowedBooks>();
        }
    }
}
