using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;


namespace IntegraBrasilApi.Mappings
{
    public static class EnderecoMapping
    {

        public static EnderecoDto ConverterEnderecoParaDto(this Endereco endereco) 
        {
            return new EnderecoDto
            {
                Cep = endereco.cep,
                Estado = endereco.state,
                Cidade = endereco.city,
                Regiao = endereco.neighborhood,
                Rua = endereco.street
            };
        }

        //public EnderecoMapping()
        //{
        //    CreateMap(typeof(ResponseGeneric<>), typeof(ResponseGeneric<>));
        //    CreateMap<EnderecoDto, Endereco>();
        //    CreateMap<Endereco, EnderecoDto>();
        //}
    }
}
