using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TPModule.Serializer
{
    public static class SerializerUtilis
    {
        public static void Write(this BinaryWriter writer, ISeriazable obj)
        {
            obj.Serialzie(writer);
        }

        public static void Write(this BinaryWriter writer, IEnumerable<ISeriazable> obj)
        {
            writer.Write(obj.Count());
            foreach (var item in obj)
                item.Serialzie(writer);
        }
    }
}