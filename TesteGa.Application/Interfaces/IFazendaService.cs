using TesteGa.Domain.Models;

namespace TesteGa.Application.Interfaces
{
    public interface IFazendaService
    {
        Fazenda Add(Fazenda fazenda);
        List<Fazenda> GetAll();
        Fazenda GetById(int id);

    }
}