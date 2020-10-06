﻿//*********************************************************************
//CAD+ Toolset
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://cadplus.xarial.com
//License: https://cadplus.xarial.com/license/
//*********************************************************************

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using Xarial.XCad;

namespace Xarial.CadPlus.CustomToolbar.Services
{
    public partial class CommandsManager
    {
        public class VbNetStateResolveCompiler : RoslynStateResolveCompiler
        {
            public VbNetStateResolveCompiler(string codeTemplate, IXApplication app) : base(codeTemplate, app)
            {
            }

            protected override Compilation CreateCompilation(IEnumerable<SyntaxTree> code, string dllName, IEnumerable<MetadataReference> refs, CompilationOptions opts)
                => VisualBasicCompilation.Create(dllName, code, refs, (VisualBasicCompilationOptions)opts);

            protected override CompilationOptions CreateCompilationOptions()
                => new VisualBasicCompilationOptions(OutputKind.DynamicallyLinkedLibrary);

            protected override SyntaxTree CreateSyntaxTree(SourceText src)
                => Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.ParseSyntaxTree(src,
                    VisualBasicParseOptions.Default.WithLanguageVersion(Microsoft.CodeAnalysis.VisualBasic.LanguageVersion.VisualBasic16), "");

            protected override IEnumerable<MetadataReference> GetReferences()
            {
                yield return MetadataReference.CreateFromFile(typeof(IVbHost).Assembly.Location);
            }
        }
    }
}
