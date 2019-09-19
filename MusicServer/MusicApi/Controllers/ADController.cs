using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApi.Controllers
{
    public class ADController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            var data = new DataContext().Advertisements.ToList();
            return Content(new AjaxResult { state = ResultType.success.ToString(), message = "true", data = data }.ToJson());
        }
    }
}