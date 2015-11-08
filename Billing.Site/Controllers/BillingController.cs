using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Billing.Site.BillingService;
using Billing.Site.Mapper;

namespace Billing.Site.Controllers
{
    public class BillingController : Controller
    {
        private readonly IBillingService _billingService;

        public BillingController(IBillingService billingService)
        {
            _billingService = billingService;
        }

        public new ActionResult View()
        {
            var model = _billingService.GetBill().ToViewModel();
            return View(model);
        }
    }
}
