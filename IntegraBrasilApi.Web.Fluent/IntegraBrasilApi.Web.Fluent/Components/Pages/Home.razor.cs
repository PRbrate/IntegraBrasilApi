using IntegraBrasilApi.Application.DTOs;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

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
        public IQueryable<CnpjDto>? CnpjList { get; set; }
        public CnpjDto? CnpjDto { get; set; }

        private async Task<bool> SubmitCnpj()
        {
            if (CnpjId != "" && CnpjId is not null)
            {
                var cnpj = await CnpjService.GetCnpj(CnpjId);
                Consultou = true;
                SubmeteuCnpj = true;

                if (cnpj.cnpj is not null)
                {

                    CnpjList = new[] { new CnpjDto(
                    cnpj.cnpj,
                    cnpj.razao_social,
                    cnpj.nome_fantasia,
                    cnpj.situacao_cadastral,
                    cnpj.cep,
                    cnpj.uf,
                    cnpj.municipio,
                    cnpj.ddd_telefone_1,
                    cnpj.qualificacao_do_responsavel,
                    cnpj.capital_social,
                    cnpj.descricao_porte
                    )}.AsQueryable();
                }
                else
                {
                    MessageError = "Falha ao consultar Cnpj, todos os Fornecedores retornam erro";
                }

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
        public string? Cep { get; set; }

        public IQueryable<EnderecoDto>? Endereco { get; set; }

        public EnderecoDto? EnderecoDto { get; set; }

        protected override void OnInitialized() => EnderecoDto ??= new();

        private async Task<bool> SubmitEndereco()
        {
            if (Cep != "" && Cep is not null)
            {
                var endereco = await EnderecoService.endereco(Cep);
                Consultou = true;
                SubmeteuEnd = true;

                if (endereco.Cep is not null)
                {

                    Endereco = new[] { new EnderecoDto(
                endereco.Cep,
                endereco.Estado,
                endereco.Cidade,
                endereco.Regiao,
                endereco.Rua) }.AsQueryable();
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
            return await Task.FromResult(true);

        }
        #endregion
    }
}
