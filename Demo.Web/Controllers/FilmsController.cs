﻿namespace Demo.Web.Controllers
{
    using Demo.Core.Models;
    using Demo.Core.Repositories;
    using Demo.Web.Models;
    using System;
    using System.Linq;
    using System.Web.Mvc;

    public partial class FilmsController : Controller
    {
        private readonly IFilmsRepository repo;

        public FilmsController(IFilmsRepository repo)
        {
            this.repo = repo;
        }

        public virtual ActionResult Info(string filmName)
        {
            var film = repo.GetAll().FirstOrDefault(f => f.Name == filmName);
            return View(film);
        }

        public virtual ActionResult Index()
        {
            var model = new FilmsListViewModel
                        {
                            Names = repo.GetAll().Select(f => f.Name)
                        };
            return View(model);
        }

        public virtual ActionResult Eng()
        {
            var filmPrices = repo.GetEnglishFilms().ToDictionary(film => film.Name, film => film.PriceInPence / 100);
            var model = new EnglishFilmsViewModel(filmPrices);

            return View(model);
        }

        [HttpGet]
        public virtual ActionResult Add()
        {
            return View(new Film());
        }

        [HttpPost]
        public virtual ActionResult Add(Film film)
        {
            try
            {
                film.TimeUpdated = DateTime.Now;
                repo.Add(film);
                repo.SaveContext();
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", "Add film failed with error message " + e.Message);
                return View(film);
            }

            return RedirectToAction(MVC.Films.Index());
        }
    }
}