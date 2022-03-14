using TesteGa.Domain.Models;

public interface IAnimalRepository
{
    void Add(Animal animal);
    void Update(Animal animal);
    void Delete(Animal animal);
    bool SaveChanges();
    Animal GetById(int Id);
    IEnumerable<Animal> GetAll();
}