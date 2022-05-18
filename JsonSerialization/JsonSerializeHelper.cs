using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#pragma warning disable

namespace JsonSerialization.Models
{
    public static class JsonSerializeHelper
    {
        public static void Serialize(object data, string filePath)
        {
            var jsonSerializer = new JsonSerializer();

            if (File.Exists(filePath))
                File.Delete(filePath);

            using StreamWriter streamWriter = new StreamWriter(filePath);
            using JsonWriter jsonWriter = new JsonTextWriter(streamWriter);

            jsonSerializer.Serialize(jsonWriter, data);
        }

        public static object Desirialize(Type type, string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using StreamReader streamReader = new StreamReader(filePath);
            using JsonReader jsonReader = new JsonTextReader(streamReader);

            var jsonSerializer = new JsonSerializer();
            return (jsonSerializer.Deserialize(jsonReader) as JObject)?.ToObject(type);
        }
    }
}
