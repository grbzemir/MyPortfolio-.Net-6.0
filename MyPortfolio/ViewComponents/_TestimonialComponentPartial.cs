﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Dal.Context;

namespace MyPortfolio.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Testimonials.ToList();
            return View(values);
        }
    }
}
