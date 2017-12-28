using System.IO;

namespace TPModule.Serializer
{
    public interface ISeriazable
    {
        void Serialzie(BinaryWriter writer);
    }
}