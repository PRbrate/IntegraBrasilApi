using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;
using IntegraBrasilApi.Service.Intefaces;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace IntegraBrasilApi.Service
{
    public class BrasilApiService : IBrasilApi
    {
        public async Task<ResponseGeneric<Endereco>> GetEndereco(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response  = new ResponseGeneric<Endereco>();

            using(var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<Endereco>(contentResp);

                if(responseBrasilApi.IsSuccessStatusCode) 
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGeneric<List<Banco>>> GetBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGeneric<List<Banco>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<List<Banco>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
                
        public async Task<ResponseGeneric<Banco>> GetBancoId(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseGeneric<Banco>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<Banco>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;
        }

        public async Task<ResponseGeneric<Cnpj>> GetCnpj(string cnpj)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cnpj/v1/{cnpj}");

            var response = new ResponseGeneric<Cnpj>();

            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonConvert.DeserializeObject<Cnpj>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.DataReturn = objResponse;
                }
                else
                {
                    response.StatusCode = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonConvert.DeserializeObject<ExpandoObject>(contentResp);
                }
            }

            return response;
        }
    }
}
