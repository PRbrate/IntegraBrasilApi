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


        //public static CnpjDto ParaCnpjDto(this Cnpj cnpj) => new(
        //    cnpj.Cnpjj,
        //    cnpj.IdentificadorMatrizFilial,
        //    cnpj.DescricaoMatrizFilial,
        //    cnpj.RazaoSocial,
        //    cnpj.NomeFantasia,
        //    cnpj.SituacaoCadastral,
        //    cnpj.DescricaoSituacaoCadastral,
        //    cnpj.DataSituacaoCadastral,
        //    cnpj.MotivoSituacaoCadastral,
        //    cnpj.NomeCidadeExterior,
        //    cnpj.CodigoNaturezaJuridica,
        //    cnpj.DataInicioAtividade,
        //    cnpj.CnaeFiscal,
        //    cnpj.CnaeFiscalDescricao,
        //    cnpj.DescricaoTipoDeLogradouro,
        //    cnpj.Logradouro,
        //    cnpj.Numero,
        //    cnpj.Complemento,
        //    cnpj.Bairro,
        //    cnpj.Cep,
        //    cnpj.Uf,
        //    cnpj.CodigoMunicipio,
        //    cnpj.Municipio,
        //    cnpj.DddTelefone1,
        //    cnpj.DddTelefone2,
        //    cnpj.DddFax,
        //    cnpj.QualificacaoDoResponsavel,
        //    cnpj.CapitalSocial,
        //    cnpj.Porte,
        //    cnpj.DescricaoPorte,
        //    cnpj.OpcaoPeloSimples,
        //    cnpj.DataOpcaoPeloSimples,
        //    cnpj.DataExclusaoDoSimples,
        //    cnpj.OpcaoPeloMei,
        //    cnpj.SituacaoEspecial,
        //    cnpj.DataSituacaoEspecial,
        //    cnpj.CnaesSecundarios,
        //    cnpj.Qsa
        //    );
    }
}
