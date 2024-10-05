using System.Text.Json;
using System.Text.Json.Serialization;

namespace YTCFullApplication.Json.Converters
{
    public class UtcDateTimeJsonCoverter : JsonConverter<DateTime>
    {
        private readonly string serializationFormat;

        public UtcDateTimeJsonCoverter() : this(null)
        {
        }

        public UtcDateTimeJsonCoverter(string? serializationFormat)
        {
            this.serializationFormat = serializationFormat ?? "yyyy-MM-ddTHH:mm:ss.fffffffZ";
        }

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetDateTime().ToLocalTime();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            string stringValue = (value.Kind != DateTimeKind.Utc ? value.ToUniversalTime() : value).ToString(serializationFormat);
            writer.WriteStringValue(stringValue);
        }
    }
}
