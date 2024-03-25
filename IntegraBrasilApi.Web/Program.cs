using IntegraBrasilApi.Web;
using IntegraBrasilApi.Web.Services;
using IntegraBrasilApi.Web.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IEnderecoServiceWeb, EnderecoServiceWeb>();

var baseUUrl = "https://localhost:7066";

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseUUrl)
});

await builder.Build().RunAsync();
