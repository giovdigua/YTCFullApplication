using YTCFullApplication.Json;

namespace YTCFullApplication.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.



            var jsonOptions = builder.Services.AddJsonOptions();
            builder.Services.AddControllers().AddJsonOptions(config =>
            {
                config.JsonSerializerOptions.PropertyNameCaseInsensitive = jsonOptions.PropertyNameCaseInsensitive;
                config.JsonSerializerOptions.DefaultIgnoreCondition = jsonOptions.DefaultIgnoreCondition;
                config.JsonSerializerOptions.PropertyNamingPolicy = jsonOptions.PropertyNamingPolicy;

                config.JsonSerializerOptions.Converters.Clear();

                foreach (var converter in jsonOptions.Converters)
                {
                    config.JsonSerializerOptions.Converters.Add(converter);
                }
            });
            builder.Services.AddProblemDetails();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
