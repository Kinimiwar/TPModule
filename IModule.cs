using System.Collections.Generic;
using TPModule.Methods;

namespace TPModule
{
    public interface IModule
    {
        ModuleType ModuleType { get; }
        string Name { get; }
        string DefalultMethod { get; }
        List<IMethod> Methods { get; }
    }
}