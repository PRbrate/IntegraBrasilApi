using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Entities
{

    public class Cnpj
    {
        //[JsonPropertyName("cnpj")]
        //public string? CnpjId { get; set; }

        //[JsonPropertyName("razao_social")]
        //public string? RazaoSocial { get; set; }

        //[JsonPropertyName("nome_fantasia")]
        //public string? NomeFantasia { get; set; }

        //[JsonPropertyName("situacao_cadastral")]
        //public int SituacaoCadastral { get; set; }

        //[JsonPropertyName("cep")]
        //public int Cep { get; set; }

        //[JsonPropertyName("uf")]
        //public string? Uf { get; set; }

        //[JsonPropertyName("municipio")]
        //public string? Municipio { get; set; }

        //[JsonPropertyName("ddd_telefone_1")]
        //public string? DddTelefone1 { get; set; }

        //[JsonPropertyName("qualificacao_do_responsavel")]
        //public int QualificacaoDoResponsavel { get; set; }

        //[JsonPropertyName("capital_social")]
        //public int CapitalSocial { get; set; }

        //[JsonPropertyName("descricao_porte")]
        //public string? DescricaoPorte { get; set; }

        //[JsonPropertyName("opcao_pelo_mei")]
        //public bool OpcaoPeloMei { get; set; }

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
