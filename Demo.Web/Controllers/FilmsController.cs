namespace Demo.Web.Controllers
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

        public virtual ActionResult Index()
        {
            var model = new FilmsListViewModel
                        {
                            Names = repo.GetAll().Select(f => f.Name)
                        };
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
