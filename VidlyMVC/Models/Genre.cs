using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Display(Name = "Gênero")]
        public string Name { get; set; }
        public Genre()
        {
        }
    }
}
