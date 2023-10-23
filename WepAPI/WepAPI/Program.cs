using WepAPI.Models;

namespace WepAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //-- Servizio per gestione JSON
            //builder.Services.AddControllersWithViews().AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

            builder.Services.AddControllers().AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();

            builder.Services.AddSingleton<IRepository, Repository>();
            
            // Add services to the container.
            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            //builder.Services.AddEndpointsApiExplorer();
            

            var app = builder.Build();

            

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}