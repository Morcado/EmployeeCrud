using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;

namespace EmployeeCrud.API.AutomapperProfiles
{
    public class DireccionProfile : Profile
    {
        public DireccionProfile()
        {
            CreateMap<DireccionCreateDto, Direccion>()
                .ForMember(src => src.Calle, p => p.MapFrom(a => a.Calle))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.CP, p => p.MapFrom(a => a.CP))
                .ForMember(src => src.IdEstado, p => p.MapFrom(a => a.IdEstado))
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado));

            CreateMap<Direccion, DireccionDto>()
               .ForMember(src => src.Calle, p => p.MapFrom(a => a.Calle))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.CP, p => p.MapFrom(a => a.CP))
                .ForMember(src => src.IdEstado, p => p.MapFrom(a => a.IdEstado))
                .ForMember(src => src.Estado, p => p.MapFrom(a => a.Estado))
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado));

            CreateMap<DireccionUpdateDto, Direccion>()
                .ForMember(src => src.Calle, p => p.MapFrom(a => a.Calle))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.CP, p => p.MapFrom(a => a.CP))
                .ForMember(src => src.IdEstado, p => p.MapFrom(a => a.IdEstado))
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado));
        }
    }
}
