

using System.ComponentModel.DataAnnotations;

namespace TesteGa.Ui.Models
{
    public class AnimalDto
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage ="O campo {0} e obrigatorio.")]
        public string Tag { get; set; }
        public int FazendaId { get; set; }
        public virtual FazendaDto? FazendaDto { get; set; }
    }
}