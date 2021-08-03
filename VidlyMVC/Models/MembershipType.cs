using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }

        [Display(Name = "Discount Rate")]
        public byte DiscountRate { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Membership Name")]
        public string Name { get; set; }
    }
}
