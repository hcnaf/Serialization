using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable

namespace BinarySerialization.Models
{
    public static class BinarySerializeHelper
    {
        public static void Serialize(object data, string filePath)
        {
            var binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
                File.Delete(filePath);

            using var fileStream = File.Create(filePath);

            binaryFormatter.Serialize(fileStream, data);
        }

        public static object Desirialize(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using var fileStream = File.OpenRead(filePath);
            var binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(fileStream);
        }
    }
}
