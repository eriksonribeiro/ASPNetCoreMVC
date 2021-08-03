using System.ComponentModel.DataAnnotations;
using System;

namespace VidlyMVC.Models
{
    public class Customer
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Birthdate { get; set; }

        public Customer()
        {
        }
    }
}
