using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Persistence;
using Service.DateTime;

namespace API;

public static class ProgramExtentionMethods
{
    public static void AddDataContext(this IServiceCollection service)
    {
        service.AddDbContext<DataContext>();
    }

    public static void AddDependencyInjections(this IServiceCollection service)
    {
        service.AddScoped<IDataContext, DataContext>();
        service.AddScoped<IDateTimeService, DateTimeService>();
    }

    public static void AddAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAdB2C"));
    }
    
    public static void SetupSwagger(this WebApplication application)
    {
        application.UseSwagger();
        application.UseSwaggerUI(setupSwagger());
    }

    private static Action<Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIOptions> setupSwagger()
    {
        return setup =>
        {
            setup.DefaultModelsExpandDepth(-1); // Disable the "Schemas" collapsable list at the bottom of the page.
            setup.SwaggerEndpoint("/swagger/v1/swagger.json", "TaskList API");
            setup.RoutePrefix = "tlapi/v1";
        };
    }
}