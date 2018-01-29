using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicBookGallery.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Hello from the desc!!!</p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slott", Role = "Script"},
                    new Artist() {Name = "Edgar Delgato", Role = "Colors"}
                }
            };

            return View(comicBook);
        }
    }
}
