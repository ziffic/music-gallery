using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicGallery.Models
{
  public class Music
  {
    public int Id { get; set; }
    public string BandName { get; set; }
    public string AlbumTitle { get; set; }
    public string ReleaseDate { get; set; }
    public string DescriptionHtml { get; set; }
    public Artist[] Artists { get; set; }

    public string DisplayText
    {
      get
      {
        return BandName + ": " + AlbumTitle;
      }
    }

    public string CoverImageFileName
    {
      get
      {
        return BandName.Replace(" ", "-").ToLower() + AlbumTitle.Replace(" ", "-") + ".jpg";
      }
    }
  }
}