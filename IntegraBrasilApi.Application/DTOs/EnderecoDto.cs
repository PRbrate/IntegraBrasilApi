using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class EnderecoDto
    {
        public EnderecoDto() { }
        public EnderecoDto(string ceep, string estado, string cidade, string regiao, string rua)
        {
            Cep = ceep;
            Estado = estado;
            Cidade = cidade;
            Regiao = regiao;
            Rua = rua;
        }

        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Regiao { get; set; }
        public string Rua { get; set; }
        [JsonIgnore]
        public string? service { get; set; }
    }
}
