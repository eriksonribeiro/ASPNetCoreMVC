using System.ComponentModel.DataAnnotations;
using System;

namespace VidlyMVC.Models
{
    public class Movie
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Date Added")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateAdded { get; set; }
        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Movie()
        {
        }
    }
}
