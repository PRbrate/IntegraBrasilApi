using AutoMapper;
using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Application.Mappings
{
    public class CnpjMapping : Profile
    {

        public CnpjMapping() 
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<CnpjDto, Cnpj>();
            CreateMap<Cnpj, CnpjDto>();
        }
    }
}
