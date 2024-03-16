using FrontApi.Components;
using FrontApi.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.FluentUI.AspNetCore.Components;

using IHost host = Host.CreateApplicationBuilder(args).Build();

IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();


builder.Services.AddFluentUIComponents();

var baseApi = "https://localhost:7066";

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(baseApi)
});


builder.Services.AddScoped<IEnderecosService, EnderecoService>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer();


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
