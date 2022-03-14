using Microsoft.EntityFrameworkCore;
using TesteGa.Domain.Models;

namespace TesteGa.Repository.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Fazenda> Fazendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            MapearPropriedadesEsquecidas(modelBuilder);
        }

        private void MapearPropriedadesEsquecidas(ModelBuilder modelBuilder)
        {
            foreach(var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p=>p.ClrType == typeof(string));

                foreach(var property in properties)
                {
                    if(string.IsNullOrEmpty(property.GetColumnType())
                        && !property.GetMaxLength().HasValue)
                        {
                            property.SetColumnType("VARCHAR(100)");
                        }
                }
            }
        }
    }
}