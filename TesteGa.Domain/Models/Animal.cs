namespace TesteGa.Domain.Models
{
    public class Animal : Base
    {
        public string Tag { get; set; }
        public int FazendaId { get; set; }
        public virtual Fazenda Fazenda { get; set; }
    }
}