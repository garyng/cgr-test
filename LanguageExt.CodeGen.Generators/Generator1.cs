using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using CodeGeneration.Roslyn;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace LanguageExt.CodeGen.Generators
{
    public class Generator1 : ICodeGenerator
    {
        public Generator1(AttributeData attributeData) 
        {
        }

        public Task<SyntaxList<MemberDeclarationSyntax>> GenerateAsync(TransformationContext context, IProgress<Diagnostic> progress, CancellationToken cancellationToken)
        {
            Debugger.Launch();
            return Task.FromResult(List<MemberDeclarationSyntax>());
        }
    }
}
