using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpFree { get; set; }

        [Display(Name="Duração em Meses")]
        public byte DurationInMonths { get; set; }

        [Display(Name = "Desconto(%)")]
        public byte DiscountRate { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Programa de Fidelidade")]
        public string Name { get; set; }
    }
}
