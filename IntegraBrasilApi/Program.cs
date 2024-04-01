using IntegraBrasilApi.Application.Mappings;
using IntegraBrasilApi.Application.Service;
using IntegraBrasilApi.Application.Service.Intefaces;
using IntegraBrasilApi.Mappings;
using IntegraBrasilApi.Service;
using IntegraBrasilApi.Service.Intefaces;
using Microsoft.Net.Http.Headers;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEnderecoService, EnderecoService>();
builder.Services.AddScoped<IBrasilApi, BrasilApiService>();
builder.Services.AddScoped<IBancoService, BancoService>();
builder.Services.AddScoped<ICnpjService, CnpjService>();

builder.Services.AddAutoMapper(typeof(EnderecoMapping));
builder.Services.AddAutoMapper(typeof(BancoMapping));
builder.Services.AddAutoMapper(typeof(CnpjMapping));

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors( policy =>
        policy.WithOrigins("https://localhost:7151")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithHeaders(HeaderNames.ContentType)
    );

app.UseCors(policy =>
        policy.WithOrigins("https://localhost:7245")
        .AllowAnyMethod()
        .AllowAnyHeader()
        .WithHeaders(HeaderNames.ContentType)
    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
