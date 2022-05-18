using CustomBinarySerialization;

var vehicle = new Vehicle
{
    Name = "Jiga",
    HorsePowers = 103.1
};

CustomBinarySerializeHelper.Serialize(vehicle, FilePath(vehicle.Name));

var vehicle1 = CustomBinarySerializeHelper.Desirialize(FilePath(vehicle.Name));

Console.WriteLine(vehicle1);

string FilePath(string fileName) => @$"..\..\..\Serialized\{fileName}.data";