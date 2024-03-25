using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Entities
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string? Cep { get; set; }

        [JsonPropertyName("state")]
        public string? Etado { get; set; }

        [JsonPropertyName("city")]
        public string? Cidade { get; set; }

        [JsonPropertyName("neighborhood")]
        public string? Regiao { get; set; }

        [JsonPropertyName("street")]
        public string? Rua { get; set; }

        [JsonPropertyName("service")]
        public string? Servico { get; set; }
    }
}
