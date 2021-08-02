using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Customer
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        public string Name { get; set; }


        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
