using TesteGa.Application.Interfaces;
using TesteGa.Domain.Models;
using TesteGa.Repository.Context;

namespace TesteGa.Application.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository repository;
        
        public AnimalService(IAnimalRepository repository)
        {
            this.repository = repository;
        }
        public Animal Add(Animal animal)
        {
            try
            {
                repository.Add(animal);

                var animal_retorno = repository.GetById(animal.Id);

                if(repository.SaveChanges())
                    return animal_retorno;

                return null;
            }
            catch (Exception e)
            {
                
                throw new Exception(e.Message);
            }

        }

        public List<Animal> GetAll()
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

        public Animal GetById(int id)
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

        public void Delete(Animal animal) 
        {
            try
            {
                repository.Delete(animal);
                repository.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
             
        }
    }
}