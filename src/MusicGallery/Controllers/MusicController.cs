using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicGallery.Models;

namespace MusicGallery.Controllers
{
  public class MusicController : Controller
  {
    public ActionResult Detail()
    {
      var music = 1;

      return View(music);
    }
  }
}