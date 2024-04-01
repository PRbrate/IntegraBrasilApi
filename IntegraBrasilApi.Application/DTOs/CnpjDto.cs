using IntegraBrasilApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Application.DTOs
{
    public class CnpjDto
    {
        public CnpjDto() { }
        public CnpjDto(string? cnpjId, string? razaoSocial, string? nomeFantasia, int situacaoCadastral, int cep, string? uf, string? municipio, string? dddTelefone1, int qualificacaoDoResponsavel, int capitalSocial, string? descricaoPorte)
        {
            cnpj = cnpjId;
            razao_social = razaoSocial;
            nome_fantasia = nomeFantasia;
            situacao_cadastral = situacaoCadastral;
            cep = cep;
            uf = uf;
            municipio = municipio;
            ddd_telefone_1 = dddTelefone1;
            qualificacao_do_responsavel = qualificacaoDoResponsavel;
            capital_social = capitalSocial;
            descricao_porte = descricaoPorte;;
        }


        public string cnpj { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public int situacao_cadastral { get; set; }
        public int cep { get; set; }
        public string uf { get; set; }
        public string municipio { get; set; }
        public string ddd_telefone_1 { get; set; }
        public int qualificacao_do_responsavel { get; set; }
        public int capital_social { get; set; }
        public string descricao_porte { get; set; }
    }
}
