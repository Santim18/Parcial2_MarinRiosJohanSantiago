using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Parcial2_MarinRiosJohanSantiago.DAL.Entities
{
    public class Ticket
    {

        [Key]
        [Required]
        [Display(Name = "Id Ticket")]
        public Guid Id { get; set; }

        [Display(Name = "Fecha de ingreso")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Uso Ticket")]
        [DefaultValue(false)]
        public bool IsUsed { get; set; }

        [Display(Name = "Porteria de Ingreso")]
        public string? EntranceGate { get; set; }



    }
}
