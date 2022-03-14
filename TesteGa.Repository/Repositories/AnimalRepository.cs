using Microsoft.EntityFrameworkCore;
using TesteGa.Domain.Models;
using TesteGa.Repository.Context;

public class AnimalRepository : IAnimalRepository
{
    private readonly DataContext context;
    public AnimalRepository(DataContext context)
    {
        this.context = context;
    }
    public void Add(Animal animal)
    {
        context.Add(animal);
    }

    public void Delete(Animal animal)
    {
        context.Remove(animal);
    }

    public IEnumerable<Animal> GetAll()
    {
        return context.Animais.OrderBy(a => a.Id).Include(a => a.Fazenda);
    }

    public Animal GetById(int Id)
    {
        var animal = context.Animais.Include(a => a.Fazenda).FirstOrDefault(a => a.Id == Id);

        return animal;
    }

    public bool SaveChanges()
    {
        return context.SaveChanges() > 0;
    }

    public void Update(Animal animal)
    {
        context.Update(animal);
    }
}