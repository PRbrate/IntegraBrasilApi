using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Entities
{
    public class Banco
    {
        public string? ispb { get; set; }
        public string? name { get; set; }
        public int code { get; set; }
        public string? fullName { get; set; }
    }
}
