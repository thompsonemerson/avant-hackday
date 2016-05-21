using Avant.Model;
using Avant.Repository;
using Avant.Repository.Contracts;
using Avant.Repository.Helpers;
using Avant.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Avant.Web.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        public ProductController()
        {
            Uow = new AvantUow(new RepositoryProvider(new RepositoryFactories()));
        }

        public ActionResult Index()
        {
            List<Product> products = Uow.Products.GetAll().ToList();
            return View(products);
        }

        //
        // GET: /Admin/Pais/Details/5
        public ActionResult Details(int id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}

            //Product product = Uow.Products.GetDetails(id);
            //if (product == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(product);
            return null;
        }

        //
        // GET: /Admin/Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/Pais/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                Uow.Products.Add(product);
                Uow.Commit();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Admin/Pais/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = Uow.Products.GetById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Admin/Pais/Edit/5

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                Uow.Products.Update(product);
                Uow.Commit();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Admin/Pais/Delete/5

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = Uow.Products.GetById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Admin/Pais/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Uow.Products.Delete(id);
                Uow.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
