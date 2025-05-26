using System.Text.Json.Serialization;
using ApiClientes.Database.Models;
using ApiClientes.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper; // Adicione esta linha

namespace ApiClientes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler =
                    ReferenceHandler.Preserve;
                    options.JsonSerializerOptions.WriteIndented = true;
                });

            // Adiciona serviços ao contêiner
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddSingleton<ClientesContext>();
            builder.Services.AddScoped<ClientesService>();

            builder.Services.AddScoped<EnderecoService>(); 

            // Adiciona o AutoMapper ao contêiner
            builder.Services.AddAutoMapper(typeof(Program)); // Adicione esta linha

            var app = builder.Build();

            // Configura o pipeline de requisições HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();
            app.MapControllers();
            app.Run();
        }
    }
}
