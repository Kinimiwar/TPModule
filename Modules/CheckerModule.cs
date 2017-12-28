using System.Collections.Generic;
using System.IO;
using TPModule.Methods;
using TPModule.Serializer;

namespace TPModule.Modules
{
    public abstract class CheckerModule : IModule, ISeriazable
    {
        private readonly string _name = "";
        private readonly List<IMethod> _methods = new List<IMethod>();

        public ModuleType ModuleType => ModuleType.Checker;
        public string Name => _name;
        public abstract CheckerInputType InputType { get; }
        public string DefalultMethod => "Check";
        public List<IMethod> Methods => _methods;

        protected CheckerModule(string name, List<IMethod> methods)
        {
            _name = name;
            _methods = methods;
        }

        public void Serialzie(BinaryWriter writer)
        {
            writer.Write((byte)ModuleType);
            writer.Write(Name);
            writer.Write((byte)InputType);
            writer.Write(DefalultMethod);
            writer.Write(Methods);
        }
    }
}