using System.Collections.Generic;

namespace VidlyMVC.Models.ViewModels
{
    public class MovieViewModel
    {
        public IEnumerable<Genre> Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
