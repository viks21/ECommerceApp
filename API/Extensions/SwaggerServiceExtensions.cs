using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace API.Extensions
{
    public static class SwaggerServiceExtensions
    {
        public static IServiceCollection AddSwggerDocumentatin(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",new OpenApiInfo { Title = "SkinetApi" , Version = "V"});
            });

            return services; 
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {

            app.UseSwagger();

            app.UseSwaggerUI(c => 
            {c.SwaggerEndpoint("/swagger/v1/swagger.json" , "Skinet pi v1") ; });

            return app;
        } 
    }
}