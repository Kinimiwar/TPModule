using System.Collections.Generic;
using System.IO;
using TPModule.Serializer;

namespace TPModule.Methods
{
    public class IMethod : ISeriazable
    {
        public string Name { get; }
        public List<Local> Locals { get; }
        public List<Instruction> Instructions { get; }

        public IMethod(string name, List<Instruction> instructions) : this(name, instructions, new List<Local>()) { }

        public IMethod(string name, List<Instruction> instructions, List<Local> locals)
        {
            Name = name;
            Locals = locals;
            Instructions = instructions;
        }

        public void Serialzie(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(Locals);
            writer.Write(Instructions);
        }
    }
}