using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.DTOs
{
    public class ResponseGeneric<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T? DataReturn { get; set; }
        public ExpandoObject? ErroRetorno { get; set; }
    }
}
