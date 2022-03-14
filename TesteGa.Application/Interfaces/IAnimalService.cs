using TesteGa.Domain.Models;

namespace TesteGa.Application.Interfaces
{
    public interface IAnimalService
    {
         Animal Add(Animal animal);
         List<Animal> GetAll();
         Animal GetById(int id);
         void Delete(Animal animal);
    }
}