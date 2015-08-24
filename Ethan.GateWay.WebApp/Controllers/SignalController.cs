using Ethan.GateWay.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ethan.GateWay.WebApp.Controllers
{
  public class SignalController : Controller
  {
    // GET: Signal
    public ActionResult Index()
    {
      ISignalBusiness oIsignalBusiness = Factory.BusinessFactory.CreateISignalBusiness();
      this.ViewData["Signal"] = oIsignalBusiness.GetSingle(null);
      return View(ViewData["Signal"]);
    }

    public ActionResult QueryList()
    {
      ISignalBusiness oIsignalBusiness = Factory.BusinessFactory.CreateISignalBusiness();
      this.ViewData["Signal"] = oIsignalBusiness.GetAll(null);
      return View(ViewData["Signal"]);
    }
  }
}