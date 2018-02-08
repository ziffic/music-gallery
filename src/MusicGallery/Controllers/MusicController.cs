using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicGallery.Controllers
{
  public class MusicController : Controller
  {
    public ActionResult Detail()
    {
      return Content("Hello from the music controller! Today, it is " + DateTime.Now);
    }
  }
}