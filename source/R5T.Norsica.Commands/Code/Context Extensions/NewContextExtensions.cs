using System;

using R5T.Heraklion;
using R5T.Piraeus.Extensions;


namespace R5T.Norsica.Commands
{
    public static class NewContextExtensions
    {
        public static ICommandBuilderContext<NewSolutionContext> Solution(this ICommandBuilderContext<NewContext> newContext)
        {
            newContext.CommandBuilder.Append("sln");

            var slncontext = newContext.ChangeContext<NewSolutionContext>();
            return slncontext;
        }

        public static ICommandBuilderContext<NewSolutionContext> Sln(this ICommandBuilderContext<NewContext> newContext)
        {
            var slnContext = newContext.Solution();

            return slnContext;
        }

        public static ICommandBuilderContext<NewCSharpProjectContext> CSharpProject(this ICommandBuilderContext<NewContext> newContext, string projectTemplateShortName)
        {
            newContext.CommandBuilder.Append(projectTemplateShortName);

            var newCsharpProjectContext = newContext.ChangeContext<NewCSharpProjectContext>()
                .SetCSharpLanguage()
                ;

            return newCsharpProjectContext;
        }
    }
}
