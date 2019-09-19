using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApi.Controllers
{
    public class MusicController : Controller
    {
        [HttpGet]
        public ActionResult GetAll()
        {
            var data = new DataContext().Albums.ToList();
            return Content(new AjaxResult { state = ResultType.success.ToString(), message = "true", data = data }.ToJson());
        }
    }
}