using System;

using R5T.Heraklion;
using R5T.Piraeus.Extensions;


namespace R5T.Norsica.Commands
{
    public static class NewSlnContextExtensions
    {
        public static ICommandBuilderContext<NewSolutionContext> SetOutputDirectoryPath(this ICommandBuilderContext<NewSolutionContext> newSlnContext, string solutionDirectoryPath)
        {
            newSlnContext.CommandBuilder.AppendNamePathValuePair("--output", solutionDirectoryPath);

            return newSlnContext;
        }

        public static ICommandBuilderContext<NewSolutionContext> SetName(this ICommandBuilderContext<NewSolutionContext> newSlnContext, string solutionName)
        {
            newSlnContext.CommandBuilder.AppendNameValuePair("--name", solutionName);

            return newSlnContext;
        }
    }
}
