using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteGa.Domain.Models;

public class AnimalMapping : IEntityTypeConfiguration<Animal>
{
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("Animais");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Tag).HasColumnType("VARCHAR(15)").IsRequired();

            builder.HasIndex(b => b.Tag).IsUnique();

            builder.HasOne<Fazenda>(b => b.Fazenda)
            .WithMany(f => f.Animais)
            .HasForeignKey(b => b.FazendaId);
        }
}