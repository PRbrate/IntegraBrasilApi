using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class EnderecoDto
    {
        public EnderecoDto() { }
        public EnderecoDto(string? ceep, string? estado, string? cidade, string? regiao, string? rua)
        {
            cep = ceep;
            state = estado;
            city = cidade;
            neighborhood = regiao;
            street = rua;
        }

        public string cep { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        [JsonIgnore]
        public string? service { get; set; }
    }
}
