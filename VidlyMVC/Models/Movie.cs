using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Movie
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        public string Name { get; set; }

        public Movie(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
