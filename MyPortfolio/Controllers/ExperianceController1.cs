using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperianceController1 : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperianceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperiance()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperiance(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

        public IActionResult DeleteExperience(int id)

        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View("UpdateExperience", value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperianceList");
        }

    }
}
