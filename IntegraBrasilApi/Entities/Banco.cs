using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Entities
{
    public class Banco
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }

        [JsonPropertyName("name")]
        public string? NameAbreviado { get; set; }

        [JsonPropertyName("code")]
        public int Codigo { get; set; }

        [JsonPropertyName("fullName")]
        public string? NomeCompleto { get; set; }
    }
}
