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
        public CnpjDto(string? cnpjId, string? razaoSocial, string? nomeFantasia, string situacaoCadastral, int ncep, string? nuf, string? nmunicipio, string? dddTelefone1, int capitalSocial, string? descricaoPorte)
        {
            cnpj = cnpjId;
            razao_social = razaoSocial;
            nome_fantasia = nomeFantasia;
            descricao_situacao_cadastral = situacaoCadastral;
            cep = ncep;
            uf = nuf;
            municipio = nmunicipio;
            ddd_telefone_1 = dddTelefone1;
            capital_social = capitalSocial;
            descricao_porte = descricaoPorte;
        }


        public string cnpj { get; set; }
        public string razao_social { get; set; }
        public string nome_fantasia { get; set; }
        public string descricao_situacao_cadastral { get; set; }
        public int cep { get; set; }
        public string uf { get; set; }
        public string municipio { get; set; }
        public string ddd_telefone_1 { get; set; }
        public int capital_social { get; set; }
        public string descricao_porte { get; set; }
    }
}
