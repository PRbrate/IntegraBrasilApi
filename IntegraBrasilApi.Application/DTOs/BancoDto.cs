using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class BancoDto
    {
        public string? Ispb { get; set; }
        public string? NameAbreviado { get; set; }
        public int Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}
