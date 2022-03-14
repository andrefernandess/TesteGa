namespace TesteGa.Domain.Models
{
    public class Fazenda : Base
    {
        public string Nome { get; set; }
        public List<Animal> Animais { get; set; }
    }
}