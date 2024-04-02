using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Entities
{
    public class Endereco
    {
        public string cep { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public string service { get; set; }
    }
}
