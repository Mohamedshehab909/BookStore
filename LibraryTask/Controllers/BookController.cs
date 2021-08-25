using AutoMapper;
using BL;
using BL.Models;
using BL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryTask.Controllers
{
    public class BookController : Controller
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;

        public BookController(IUnitOfWork _unitOfWork , IMapper mapper , IToastNotification toastNotification)
        {
            this.unitOfWork = _unitOfWork;
            this.mapper = mapper;
            this.toastNotification = toastNotification;
        }

        public IActionResult GetAll()
        {
            var data = unitOfWork.Books.GetAll().ToList();
            var result = mapper.Map<List<BookVM>>(data);
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BookVM _book)
        {
            if (ModelState.IsValid)
            {
                var book = mapper.Map<Book>(_book);
                unitOfWork.Books.Add(book);
                unitOfWork.Complete();
                toastNotification.AddSuccessToastMessage("Book Created Successfully");
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(_book);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = unitOfWork.Books.GetById(id);
            var Book = mapper.Map<BookVM>(book);

            return View(Book);
        }

        [HttpPost]
        public IActionResult Edit(BookVM model)
        {
            if(ModelState.IsValid)
            {
                var book = mapper.Map<Book>(model);
                unitOfWork.Books.Update(book);
                unitOfWork.Complete();
                toastNotification.AddSuccessToastMessage("Book Updated Successfully");
                return RedirectToAction("GetAll");
            }

            return View(model);
        }

    }
}
