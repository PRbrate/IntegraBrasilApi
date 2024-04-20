using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Fluent.Services.Interface;
using IntegraBrasilApi.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;

namespace IntegraBrasilApi.Web.Fluent.Components.Pages
{
    public partial class Home
    {
        private bool Consultou = false;
        public string? MessageError { get; set; }


        #region Cnpj
        [Inject]
        public ICnpjService? CnpjService { get; set; }

        private bool SubmeteuCnpj = false;

        [SupplyParameterFromForm]
        public string? CnpjId { get; set; }
        public CnpjDto? CnpjDto { get; set; } = new();

        private async Task<bool> SubmitCnpj()
        {
            if (!string.IsNullOrEmpty(CnpjId))
            {
                CnpjDto = await CnpjService.GetCnpj(CnpjId);
                Consultou = true;
                SubmeteuCnpj = true;
            }
            else
            {
                MessageError = "Deve ser passado um Cnpj para fazer a pesquisa";
            }
            return await Task.FromResult(true);

        }


        #endregion

        #region endereco
        [Inject]
        public IEnderecoServiceFWeb? EnderecoService { get; set; }

        private bool SubmeteuEnd = false;

        [SupplyParameterFromForm]
        public string Cep { get; set; }

        public IQueryable<EnderecoDto> Endereco { get; set; }

        public EnderecoDto EnderecoDto { get; set; }

        protected override void OnInitialized() => EnderecoDto ??= new();

        private async Task<bool> SubmitEndereco()
        {
            if (!string.IsNullOrEmpty(Cep))
            {
                EnderecoDto = await EnderecoService.endereco(Cep);

                if (EnderecoDto.Cidade is not null)
                {

                    Endereco = new[] { new EnderecoDto(
                    EnderecoDto.Cep,
                    EnderecoDto.Estado,
                    EnderecoDto.Cidade,
                    EnderecoDto.Regiao,
                    EnderecoDto.Rua) }.AsQueryable();
                }
                else
                {
                    MessageError = "Falha ao consultar Endereço, todos os Fornecedores retornam erro";
                }

            }
            else
            {
                MessageError = "Deve ser passado um cep para fazer a pesquisa";
            }
            Consultou = true;
            SubmeteuEnd = true;
            return await Task.FromResult(true);
        }
        #endregion

        #region banco
        [Inject]
        public IBancoService? BancoService { get; set; }

        private bool SubmeteuBanco = false;

        [SupplyParameterFromForm]
        public string Banco { get; set; }

        public IQueryable<BancoDto> BancoDtos { get; set; }

        public BancoDto BancoDto { get; set; }

        private async Task<bool> SubmitBanco()
        {
            if (!string.IsNullOrEmpty(Banco))
            {
                BancoDto = await BancoService.banco(Banco);

                if (BancoDto.Ispb is not null)
                {

                    BancoDtos = new[] { new BancoDto(
                    BancoDto.Ispb,
                    BancoDto.NomeAbreviado,
                    BancoDto.Codigo,
                    BancoDto.NomeCompleto) }.AsQueryable();
                }
                else
                {
                    MessageError = "Falha ao consultar Banco, todos os Fornecedores retornam erro";
                }

            }
            else
            {
                MessageError = "Deve ser passado um Código Banco para fazer a pesquisa";
            }
            Consultou = true;
            SubmeteuBanco = true;
            return await Task.FromResult(true);

            #endregion
        }
    }
}
