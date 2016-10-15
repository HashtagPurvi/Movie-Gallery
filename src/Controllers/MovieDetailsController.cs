using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesGallery.Models;

namespace MoviesGallery.Controllers
{
    public class MovieDetailsController : Controller
    {
        public ActionResult Details()
        {
            Movie movie = new Movie()
            {
                Name = "Yeh Jawaani hai Deewani",
                ReleaseDate = new DateTime(2013, 05, 31),
                Ratings = 5,
                Description = "<p>Yeh Jawaani Hai Deewani is the story of the relationship between two characters" +
                ",Bunny (Ranbir Kapoor) & Naina (Deepika Padukone), at two separate but defining times in their lives..." +
                "first, when they are just out of college and standing on the crossroads of multiple decisions" +
                "that will shape who and what they become... and then later on, in their late-twenties" +
                "when they meet again, holding on to certain fulfilled and certain unfulfilled dreams, " +
                "at a crossroads of another nature this time... how these two characters affect, change," +
                "befriend and eventually fall in love with each "+
                "other is the journey the film aspires to take us on..</p>",

                Artists = new Artist[] { 

                    new Artist { Name = "Director" , Role ="Ayaan Mukherji"},
                    new Artist { Name = "Producer" , Role ="Karan Johar"},
                    new Artist { Name = "Lead Actor" , Role ="Ranbir Kapoor"},
                    new Artist { Name = "Lead Actress" , Role ="Deepika Padukon"},
                    new Artist { Name = "Supporting Actor" , Role ="Aditya Roy Kapoor"},
                    new Artist { Name = "Supporting Actress" , Role ="Kalki Koechlin"}
                }
                
            };

            return View(movie);
        }
    }
}