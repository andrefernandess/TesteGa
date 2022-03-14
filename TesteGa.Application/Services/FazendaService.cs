using TesteGa.Application.Interfaces;
using TesteGa.Domain.Models;
using TesteGa.Repository.Interfaces;

namespace TesteGa.Application.Services
{
    public class FazendaService : IFazendaService
    {
        private readonly IFazendaRepository repository;

        public FazendaService(IFazendaRepository repository)
        {
            this.repository = repository;
        }
        public Fazenda Add(Fazenda fazenda)
        {
            try
            {
                this.repository.Add(fazenda);

                var fazenda_retorno = repository.GetById(fazenda.Id);

                if(repository.SaveChanges())
                    return fazenda_retorno;

                return null;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public List<Fazenda> GetAll()
        {
            try
            {
                return repository.GetAll().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Fazenda GetById(int id)
        {
            try
            {
                return repository.GetById(id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}