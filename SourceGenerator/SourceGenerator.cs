namespace SourceGenerator
{
    using System;
    using Microsoft.CodeAnalysis;

    [Generator]
    public class SourceGenerator : ISourceGenerator
    {

        public void Execute(GeneratorExecutionContext context)
        {
            Console.WriteLine("Debug this.");
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            
        }
    }
}
