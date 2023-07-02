string filePath1 = @"C:\Users\nurla\RiderProjects\ByteFile\";
string filePath2 = @"C:\Users\nurla\RiderProjects\ByteFile\";

string path = Console.ReadLine();
string path1 = Console.ReadLine();
filePath1 += path;
filePath2 += path1;

List<byte> bytes = new List<byte>();

try
{
    using (BinaryReader reader = new BinaryReader(File.Open(filePath1, FileMode.Open)))
    {
        while (reader.BaseStream.Position < reader.BaseStream.Length)
        {
            byte value = reader.ReadByte();
            bytes.Add(value);
        }
    }

    bytes.Reverse();

    using (BinaryWriter writer = new BinaryWriter(File.Open(filePath2, FileMode.Create)))
    {
        foreach (var byte1 in bytes)
        {
            writer.Write(byte1);
        }
    }

    Console.WriteLine("Новый файл создан.");
}
catch (Exception ex)
{
    Console.WriteLine("Ошибка: " + ex.Message);
}