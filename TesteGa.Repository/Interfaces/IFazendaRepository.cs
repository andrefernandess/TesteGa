using TesteGa.Domain.Models;

namespace TesteGa.Repository.Interfaces
{
    public interface IFazendaRepository
    {
        void Add(Fazenda fazenda);
        void Update(Fazenda fazenda);
        void Delete(Fazenda fazenda);
        bool SaveChanges();
        Fazenda GetById(int Id);
        IEnumerable<Fazenda> GetAll();
    }
}