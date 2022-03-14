using AutoMapper;
using TesteGa.Domain.Models;
using TesteGa.Ui.Models;

namespace TesteGa.Ui.Helpers
{
    public class TesteGaProfile : Profile
    {
        public TesteGaProfile()
        {
            CreateMap<Animal, AnimalDto>()
                .ForMember(dest => dest.FazendaDto, opt => opt.MapFrom(Animal => Animal.Fazenda))
                .ReverseMap();
            CreateMap<Fazenda, FazendaDto>().ReverseMap();
            CreateMap<Fazenda, FazendaSelectDto>().ReverseMap();
        }
    }
}