using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteGa.Domain.Models;

public class FazendaMapping : IEntityTypeConfiguration<Fazenda>
{
        public void Configure(EntityTypeBuilder<Fazenda> builder)
        {
            builder.ToTable("Fazendas");
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Nome).HasColumnType("VARCHAR(100)").IsRequired();
        }
}