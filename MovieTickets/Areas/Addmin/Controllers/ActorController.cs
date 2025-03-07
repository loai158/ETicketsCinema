using Microsoft.AspNetCore.Mvc;
using MovieTickets.UnitOfWorks;

namespace MovieTickets.Areas.Addmin.Controllers
{
    [Area("Addmin")]

    public class ActorController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ActorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var actors = unitOfWork.Actors.Get(includes: [m => m.ActorsMovie]);
            return View(actors);
        }
    }
}
