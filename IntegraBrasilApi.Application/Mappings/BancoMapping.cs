using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;

namespace IntegraBrasilApi.Mappings
{
    public static class BancoMapping
    {

        public static BancoDto ConverterBancoParaDto(this Banco banco)
        {
            return new BancoDto
            {
                Ispb = banco.ispb,
                NomeAbreviado = banco.name,
                Codigo = banco.code,
                NomeCompleto = banco.fullName
            };
        }
        //public BancoMapping()
        //{
        //    CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
        //    CreateMap<BancoDto, Banco>();
        //    CreateMap<Banco, BancoDto>();
        //}
    }
}
