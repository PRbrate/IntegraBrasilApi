using System.Text.Json.Serialization;

namespace IntegraBrasilApi.DTOs
{
    public class BancoDto
    {

        public BancoDto() { }

        public BancoDto(string ispb, string nameAbreviado, int codigo, string nomeCompleto)
        {
            Ispb = ispb;
            NomeAbreviado = nameAbreviado;
            Codigo = codigo;
            NomeCompleto = nomeCompleto;
        }

        public string? Ispb { get; set; }
        public string? NomeAbreviado { get; set; }
        public int Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}
