using AutoMapper;
using EmployeeCRUD.Data.Entities;
using EmployeeCRUD.Data.Models;

namespace EmployeeCrud.API.AutomapperProfiles
{
    public class EmpleadoProfile : Profile
    {
        public EmpleadoProfile()
        {
            CreateMap<EmpleadoCreateDto, Empleado>()
                .ForMember(src => src.Nombre, p => p.MapFrom(a => a.Nombre))
                .ForMember(src => src.ApellidoPaterno, p => p.MapFrom(a => a.ApellidoPaterno))
                .ForMember(src => src.ApellidoMaterno, p => p.MapFrom(a => a.ApellidoMaterno))
                .ForMember(src => src.Edad, p => p.MapFrom(a => a.Edad))
                .ForMember(src => src.Genero, p => p.MapFrom(a => a.Genero))
                .ForMember(src => src.IdDireccion, p => p.MapFrom(a => a.IdDireccion))
                .ForMember(src => src.IdGradoEstudio, p => p.MapFrom(a => a.IdGradoEstudio))
                .ForMember(src => src.IdTipoEmpleado, p => p.MapFrom(a => a.IdTipoEmpleado));

            CreateMap<Empleado, EmpleadoDto>()
                .ForMember(src => src.Nombre, p => p.MapFrom(a => a.Nombre))
                .ForMember(src => src.ApellidoPaterno, p => p.MapFrom(a => a.ApellidoPaterno))
                .ForMember(src => src.ApellidoMaterno, p => p.MapFrom(a => a.ApellidoMaterno))
                .ForMember(src => src.Edad, p => p.MapFrom(a => a.Edad))
                .ForMember(src => src.Genero, p => p.MapFrom(a => a.Genero))
                .ForMember(src => src.IdDireccion, p => p.MapFrom(a => a.IdDireccion))
                .ForMember(src => src.IdGradoEstudio, p => p.MapFrom(a => a.IdGradoEstudio))
                .ForMember(src => src.IdTipoEmpleado, p => p.MapFrom(a => a.IdTipoEmpleado));

            CreateMap<EmpleadoUpdateDto, Empleado>()
                .ForMember(src => src.Nombre, p => p.MapFrom(a => a.Nombre))
                .ForMember(src => src.ApellidoPaterno, p => p.MapFrom(a => a.ApellidoPaterno))
                .ForMember(src => src.ApellidoMaterno, p => p.MapFrom(a => a.ApellidoMaterno))
                .ForMember(src => src.Edad, p => p.MapFrom(a => a.Edad))
                .ForMember(src => src.Genero, p => p.MapFrom(a => a.Genero))
                .ForMember(src => src.IdDireccion, p => p.MapFrom(a => a.IdDireccion))
                .ForMember(src => src.IdGradoEstudio, p => p.MapFrom(a => a.IdGradoEstudio))
                .ForMember(src => src.IdTipoEmpleado, p => p.MapFrom(a => a.IdTipoEmpleado));
        }
    }
}
