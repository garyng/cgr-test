using System;
using System.Diagnostics;
using CodeGeneration.Roslyn;

namespace LanguageExt.CodeGen
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
    [CodeGenerationAttribute("LanguageExt.CodeGen.Generators.Generator1, LanguageExt.CodeGen.Generators")]
    [Conditional("CodeGeneration")]
    public class Generator1Attribute : Attribute
    {
        public Generator1Attribute()
        {
        }
    }
}
