using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace SourceGenerator
{
    [Generator]
    public class SampleGenerator : ISourceGenerator
    {
        public void Initialize(GeneratorInitializationContext context)
        {
            // nothing happening
        }

        public void Execute(GeneratorExecutionContext context)
        {
            const string code = @"
using System;
namespace HelloWorldGenerator {
    public static class Greetings 
    {
        public static void Say() => Console.WriteLine(""Hi, folks!"");
    }
}";
            context.AddSource(
                "hellWorldGenerator",
                SourceText.From(code, Encoding.UTF8)
            );
        }
    }
}