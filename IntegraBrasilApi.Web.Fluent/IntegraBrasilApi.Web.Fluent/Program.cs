using IntegraBrasilApi.Web.Fluent.Components;
using IntegraBrasilApi.Web.Fluent.Services;
using IntegraBrasilApi.Web.Services;
using IntegraBrasilApi.Web.Services.Interfaces;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();
builder.Services.AddFluentUIComponents();

var baseUrl = "https://localhost:7066";

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseUrl)
});

builder.Services.AddScoped<IEnderecoServiceFWeb, EnderecoServiceFWeb>();
builder.Services.AddScoped<ICnpjService, CnpjServiceFWeb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode();

app.Run();
