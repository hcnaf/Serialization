using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable

namespace SerializationDeepCloning
{
    public class CloneHelper
    {
        public static T Clone<T>(object objSource)
        {
            using var tmpStream = new MemoryStream();
            var bf = new BinaryFormatter();
            bf.Serialize(tmpStream, objSource);
            tmpStream.Position = 0;
            return (T)bf.Deserialize(tmpStream);
        }
    }
}
