using System.ComponentModel.DataAnnotations;
using System;

namespace VidlyMVC.Models
{
    public class Customer
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Nome")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Inscrito para NewsLetters?")]
        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Tipo de Fidelidade")]
        public MembershipType MembershipType { get; set; }

        public byte MembershipTypeId { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name="Data de Nascimento")]
        public DateTime? Birthdate { get; set; }

        public Customer()
        {
        }
    }
}
