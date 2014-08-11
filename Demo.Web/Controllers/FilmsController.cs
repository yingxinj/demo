namespace Demo.Web.Controllers
{
    using Demo.Core.Repositories;
    using Demo.Web.Models;
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
    }
}
