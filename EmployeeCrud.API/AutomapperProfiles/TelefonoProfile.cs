using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;

namespace EmployeeCrud.API.AutomapperProfiles
{
    public class TelefonoProfile : Profile
    {
        public TelefonoProfile()
        {
            CreateMap<TelefonoCreateDto, Telefono>()
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.Extension, p => p.MapFrom(a => a.Extension))
                .ForMember(src => src.Tipo, p => p.MapFrom(a => a.Tipo));

            CreateMap<Telefono, TelefonoDto>()
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.Extension, p => p.MapFrom(a => a.Extension))
                .ForMember(src => src.Tipo, p => p.MapFrom(a => a.Tipo));

            CreateMap<TelefonoUpdateDto, Telefono>()
                .ForMember(src => src.IdEmpleado, p => p.MapFrom(a => a.IdEmpleado))
                .ForMember(src => src.Numero, p => p.MapFrom(a => a.Numero))
                .ForMember(src => src.Extension, p => p.MapFrom(a => a.Extension))
                .ForMember(src => src.Tipo, p => p.MapFrom(a => a.Tipo));
        }
    }
}
