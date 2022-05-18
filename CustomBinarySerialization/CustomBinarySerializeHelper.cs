using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable

namespace CustomBinarySerialization
{
    public static class CustomBinarySerializeHelper
    {
        public static void Serialize(Vehicle data, string filePath)
        {
            var binaryFormatter = new BinaryFormatter();

            if (File.Exists(filePath))
                File.Delete(filePath);

            using var fileStream = File.Create(filePath);

            binaryFormatter.Serialize(fileStream, data);
        }

        public static Vehicle Desirialize(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            using var fileStream = File.OpenRead(filePath);
            var binaryFormatter = new BinaryFormatter();
            return (Vehicle)binaryFormatter.Deserialize(fileStream);
        }
    }
}
