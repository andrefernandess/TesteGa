using TesteGa.Domain.Models;
using TesteGa.Repository.Context;
using TesteGa.Repository.Interfaces;

namespace TesteGa.Repository.Repositories
{
    public class FazendaRepository : IFazendaRepository
    {
        private readonly DataContext context;
        public FazendaRepository(DataContext context)
        {
            this.context = context;
        }
        public void Add(Fazenda fazenda)
        {
            context.Add(fazenda);
        }

        public void Delete(Fazenda fazenda)
        {
            context.Remove(fazenda);
        }

        public IEnumerable<Fazenda> GetAll()
        {
            return context.Fazendas.OrderBy(f => f.Id);
        }

        public Fazenda GetById(int Id)
        {
            var fazenda =  context.Fazendas.FirstOrDefault(f => f.Id == Id);

            return fazenda;
        }

        public bool SaveChanges()
        {
            return context.SaveChanges() > 0;
        }

        public void Update(Fazenda fazenda)
        {
            context.Update(fazenda);
        }
    }
}