using ApiAgendaTelefonica.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ApiAgendaTelefonica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllers();
            builder.Services.AddScoped<IContatoRepository, ContatoRepository>();
            var app = builder.Build();
            app.MapControllers();
            app.Run();

        }
    }
}
