using System.ComponentModel.DataAnnotations;

namespace TesteGa.Ui.Models
{
    public class FazendaDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo {0} e obrigatorio.")]
        public string Nome { get; set; }
        public List<AnimalDto> Animais { get; set; }
    }
}