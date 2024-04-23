using Microsoft.AspNetCore.Mvc.Formatters;

namespace _20240422
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers( opciones => 
                opciones.OutputFormatters.OfType<StringOutputFormatter>().Single().
                SupportedMediaTypes.Add("text/html")
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
