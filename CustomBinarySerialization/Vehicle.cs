using System.Runtime.Serialization;

#pragma warning disable

namespace CustomBinarySerialization;

[Serializable]
public class Vehicle : ISerializable
{
    public string Name { get; set; }
    public double HorsePowers { get; set; }

    public Vehicle() { }

    public Vehicle(string name, double square)
    {
        Name = name;
        HorsePowers = square;
    }

    public Vehicle(SerializationInfo info, StreamingContext context)
    {
        Name = (string)info.GetValue("Name", typeof(string));
        HorsePowers = (double)info.GetValue("HorsePowers", typeof(double));
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("Name", Name);
        info.AddValue("HorsePowers", HorsePowers);
    }

    public override string ToString() => Name + ": " + HorsePowers.ToString();
}