using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Mappings
{
    public class BancoMapping : Profile
    {

        public BancoMapping()
        {
            CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
            CreateMap<BancoDto, Banco>();
            CreateMap<Banco, BancoDto>();
        }
    }
}
