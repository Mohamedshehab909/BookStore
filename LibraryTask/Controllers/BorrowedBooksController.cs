using AutoMapper;
using BL;
using BL.Models;
using BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryTask.Controllers
{
    public class BorrowedBooksController : Controller
    {

        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public BorrowedBooksController(IUnitOfWork _unitOfWork, IMapper mapper)
        {
            this.unitOfWork = _unitOfWork;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var data = unitOfWork.Borrowers.GetAll().ToList();
            var AllBorrowers = mapper.Map<List<BorrowerVM>>(data);
            ViewBag.AllBorrowers = new SelectList(AllBorrowers, "Id", "Name");
            return View();
        }
        //الكتب التى تم استعارتها من قبل اليوزر
        public IActionResult bookbyborrower(int id)
        {
            var data = unitOfWork.BorrowedBooks.GetAll().Where(a => a.BorrowerId == id).Include(a=>a.Book).ToList();
            return PartialView(data);
        }
        //الكتب المتاحه للاستعاره
        public IActionResult Availablebooks(int id)
        {
            var data = new List<Book>();
            var data2 = unitOfWork.BorrowedBooks.GetAll().Where(a => a.BorrowerId == id).Include(a => a.Book).ToList();
            foreach (var item in data2)
            {
                data.Add(item.Book);
            };

            var data3 = unitOfWork.Books.GetAll().Where(a => a.Number > 0).ToList();

             IEnumerable<Book> differenceQuery = data3.Except(data);

            return PartialView(differenceQuery);
        }
        //ايعاده الكتاب الى المكتبه وزياده العدد واحد
        public IActionResult returnBook(int id)
        {
            var book = unitOfWork.BorrowedBooks.GetById(id);
            var bookid = book.BookId;
            unitOfWork.BorrowedBooks.Delete(book.Id);
            //
            var b = unitOfWork.Books.GetById(bookid);
            b.Number = b.Number + 1;
            unitOfWork.Books.Update(b);
            unitOfWork.Complete();
            //

            return Ok();
        }

        //استعاره الكتاب من المكتبه وانقاص العدد واحد
        public IActionResult borrowBook(int bookId , int borrowerid)
        {
            var book = new BorrowedBooksVM() { BookId = bookId, BorrowerId = borrowerid };
            var b = mapper.Map<BorrowedBooks>(book);
            unitOfWork.BorrowedBooks.Add(b);
            //
            var Book = unitOfWork.Books.GetById(bookId);
            Book.Number = Book.Number - 1;
            unitOfWork.Books.Update(Book);
            unitOfWork.Complete();
            //

            return Ok();
        }


    }
}
