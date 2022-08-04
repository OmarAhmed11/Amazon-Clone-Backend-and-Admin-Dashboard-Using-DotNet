﻿using Admin.Data;
using Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.AuthenticationClasses;
using Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Admin.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductController : Controller
    {

        IUnitofWork unitofWork;
        IModelRepo<Product> ModelRepository;
        IModelRepo<Category> categoryRepository;
        IModelRepo<Seller> sellerRepository;
        public ProductController(IUnitofWork _unitofWork)
        {
            unitofWork = _unitofWork;
            ModelRepository = unitofWork.GetProductRepo();
            categoryRepository = unitofWork.GetCategoryRepo();
            sellerRepository = unitofWork.GetSellerRepo();
        }

        public ActionResult Index()
        {
            var products = ModelRepository.Read().ToList();
            return View(products);
        }

        // GET: ProductController1/Details/5
        public ActionResult GetByID(int id)
        {
            Product p = ModelRepository.GetByID(id);
            return View("ProductDetails", p);
        }

        // GET: ProductController1/Create
        public ActionResult Create(ProductVM PVM)
        {
            var cat = categoryRepository.Read();
            var sellers = sellerRepository.Read();
            PVM.categories = cat;
            PVM.sellers = sellers;
            return View(PVM);
        }

        // POST: ProductController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductVM PVM, int id)
        {
            try
            {
                ModelRepository.Create(PVM.ToModel());
                unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController1/Edit/5
        public ActionResult Edit(ProductVM p)
        {
            var cat = categoryRepository.Read();
            var sellers = sellerRepository.Read();
            p.categories = cat;
            p.sellers = sellers;
            return View(p);
        }

        // POST: ProductController1/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(ProductVM p, int id)
        {
            try
            {
                ModelRepository.Update(p.ToModel());
                unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController1/Delete/5
        public ActionResult Delete(int id)
        {
            ModelRepository.Delete(id);
            unitofWork.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int Id)
        {
            return View(ModelRepository.GetByID(Id));
        }
    }
}