using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraBrasilApi.Application.Service.Intefaces
{
    public interface ICnpjService
    {
        Task<ResponseGeneric<CnpjDto>> GetCnpj(string cnpj);
    }
}
