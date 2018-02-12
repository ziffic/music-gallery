using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicGallery.Models;

namespace MusicGallery.Data
{
  public class MusicRepository
  {
    private static Music[] _music = new Music[]
    {
      new Music()
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
      },

      new Music()
      {
        BandName = "Tool",
        AlbumTitle = "10000 Days",
        ReleaseDate = "April 28, 2006",
        DescriptionHtml = "<p>0,000 Days is the fourth studio album by American rock band Tool. The album was released by Tool Disectional and Volcano Entertainment.</p>",
        Artists = new Artist[]
        {
          new Artist() { Name = "Maynard James Keenan", Role = "Vocals" },
          new Artist() { Name = "Adam Jones", Role = "Guitar" },
          new Artist() { Name = "Justin Chancellor", Role = "Bass" },
          new Artist() { Name = "Danny Carey", Role = "Drums" }
        }
      }
  };

    public Music GetMusic(int id)
    {
      Music musicToReturn = null;

      foreach (var music in _music)
      {
        if (music.Id == id)
        {
          musicToReturn = music;
          break;
        }
      }

      return musicToReturn;
    }
  }
}