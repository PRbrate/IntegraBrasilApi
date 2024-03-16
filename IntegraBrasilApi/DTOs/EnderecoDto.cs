using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class EnderecoDto
    {
        public string? Cep { get; set; }
        public string? Etado { get; set; }
        public string? Cidade { get; set; }
        public string? Regiao { get; set; }
        public string? Rua { get; set; }

        [JsonIgnore]
        public string? Servico { get; set; }
    }
}
