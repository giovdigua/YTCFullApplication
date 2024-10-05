using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.Json.Serialization;
using YTCFullApplication.Json.Converters;

namespace YTCFullApplication.Json
{
    public static class ServiceCollectionExtension
    {
        public static JsonSerializerOptions AddJsonOptions(this IServiceCollection services) 
        {
            JsonSerializerOptions options = new(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            options.Converters.Add(new UtcDateTimeJsonCoverter());
            services.AddSingleton(options);
            return options;
        }
    }
}
