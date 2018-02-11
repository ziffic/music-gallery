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
      var music = new Music()
      {
        BandName = "Tool",
        AlbumTitle = "Lateralus",
        ReleaseDate = "May 15, 2001",
        DescriptionHtml = "<p>Lateralus is the third studio album by American rock band Tool. It was released through <strong>Volcano Entertainment</strong>.</p>",
        Artists = new Artist[]
        {
          new Artist() { Name = "Maynard James Keenan", Role = "Vocals" },
          new Artist() { Name = "Adam Jones", Role = "Guitar" },
          new Artist() { Name = "Justin Chancellor", Role = "Bass" },
          new Artist() { Name = "Danny Carey", Role = "Drums" }
        }
      };

      return View(music);
    }
  }
}