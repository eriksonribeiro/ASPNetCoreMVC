using System.ComponentModel.DataAnnotations;
using System;

namespace VidlyMVC.Models
{
    public class Movie
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display (Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Data da Inclusão")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Quantidade em Estoque")]
        public int Stock { get; set; }

        [Display(Name = "Gênero")]
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Movie()
        {
        }
    }
}
