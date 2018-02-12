using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicGallery.Data;
using MusicGallery.Models;

namespace MusicGallery.Controllers
{
  public class MusicController : Controller
  {
    private MusicRepository _musicRepository = null;

    public MusicController()
    {
      _musicRepository = new MusicRepository();
    }

    public ActionResult Detail(int? id)
    {
      if (id == null)
      {
        return HttpNotFound();
      }

      var music = _musicRepository.GetMusic((int)id);

      return View(music);
    }
  }
}