using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        //MusicStoreEntities storeDB = new MusicStoreEntities();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            //var genres = storeDB.Genres.ToList();

            //return View(genres);
            return View( );
        }

        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string genre)
        {
            // Retrieve Genre and its Associated Albums from database
            //var genreModel = storeDB.Genres.Include("Albums")
            //    .Single(g => g.Name == genre);

            //return View(genreModel);
            return View();
        }   

        public ActionResult Details(int id)
        {
            //var album = storeDB.Albums.Find(id);                                                                                                                          
            //dynamic album = new { Title = "shoot to thrill", AlbumArtUrl = "", Price = 23, AlbumId = 43, Genere = new { Name = "asdf" }, Artist = new { Name = "acdc" } };
            Album album = new Album { Title = "shoot to thrill", AlbumArtUrl = "", Price = 23, AlbumId = 43 };  
            return View(album);
        }  

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            //var genres = storeDB.Genres.ToList();

            //return PartialView(genres);
            return PartialView( );

        }    
    }

    public class Album
    {
        public string Title { get; set; }
        public string AlbumArtUrl { get; set; }
        public float Price { get; set; }
        public int AlbumId { get; set; }  
    }


}