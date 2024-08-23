using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.Controllers
{
	public class MessageController : Controller
	{

		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult Inbox()
		{
			var value = context.Messages.ToList();
			return View(value);
			
		}

		public IActionResult ChangeIsReadToTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult ChangeIsReadToFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Inbox");
		}

		public IActionResult MessageDetail(int id)
		{
			var value = context.Messages.Find(id);
			return View("MessageDetail", value);
		}
	}
}
