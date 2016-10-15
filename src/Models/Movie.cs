using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesGallery.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Ratings { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set;}

        //Unique Text Identifying Movies which is displayed to the Viewers
        public string DisplayText {
            get
            {
                return Name + " - "+ReleaseDate.Year;
            }
        }

        //Cover Images Title for  Movies 
        public string CoverImageName
        {
            get
            {
                return Name.Replace(" ", "-").ToLower() + "-" + ReleaseDate.Year + ".jpg";
            }
        }

    }
}