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
    public class BorrowerController : Controller
    {

        private IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IToastNotification toastNotification;

        public BorrowerController(IUnitOfWork _unitOfWork, IMapper mapper , IToastNotification toastNotification)
        {
            this.unitOfWork = _unitOfWork;
            this.mapper = mapper;
            this.toastNotification = toastNotification;
        }

        public IActionResult GetAll()
        {
            var data = unitOfWork.Borrowers.GetAll().ToList();
            var result = mapper.Map<List<BorrowerVM>>(data);
            return View(result);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(BorrowerVM _Borrower)
        {
            if (ModelState.IsValid)
            {
                var b = mapper.Map<Borrower>(_Borrower);
                unitOfWork.Borrowers.Add(b);
                unitOfWork.Complete();
                toastNotification.AddSuccessToastMessage("Borrower Created Successfully");
                return RedirectToAction("GetAll");
            }
            else
            {
                return View(_Borrower);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var borrower = unitOfWork.Borrowers.GetById(id);
            var data = mapper.Map<BorrowerVM>(borrower);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(BorrowerVM model)
        {
            if (ModelState.IsValid)
            {
                var borrower = mapper.Map<Borrower>(model);
                unitOfWork.Borrowers.Update(borrower);
                unitOfWork.Complete();
                toastNotification.AddSuccessToastMessage("Borrower Updated Successfully");
                return RedirectToAction("GetAll");
            }

            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
