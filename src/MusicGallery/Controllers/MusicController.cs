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
      ViewBag.BandName = "Tool";
      ViewBag.AlbumTitle = "Lateralus";
      ViewBag.ReleaseDate = "May 15, 2001";
      ViewBag.Description = "<p>Lateralus is the third studio album by American rock band Tool. It was released through <strong>Volcano Entertainment</strong>.</p>";
      ViewBag.Artists = new string[]
      {
        "Vocals: Maynard James Keenan",
        "Guitar: Adam Jones",
        "Bass: Justin Chancellor",
        "Drums: Danny Carey"
      };

      return View();
    }
  }
}