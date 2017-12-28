using System;
using System.IO;
using System.Text;
using TPModule.Modules;

namespace TPModule.Serializer
{
    public static class ModuleSerializer
    {
        public static readonly byte[] Flag = Encoding.ASCII.GetBytes("TPM");
        public static readonly SerializerVersion Version = SerializerVersion.Alpha_0;

        public static void Serialize(IModule module, string path)
        {
            using (var writer = new BinaryWriter(File.Open(path, FileMode.CreateNew)))
            {
                writer.Write(Flag);
                writer.Write((byte)Version);
                switch (module)
                {
                    case CheckerModule checkerModule:
                        checkerModule.Serialzie(writer); break;
                    default:
                        throw new Exception("Unknown module type");
                }
            }
        }
    }
}