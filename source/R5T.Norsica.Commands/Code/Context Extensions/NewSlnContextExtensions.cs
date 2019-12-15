using System;

using R5T.Heraklion;
using R5T.Piraeus;


namespace R5T.Norsica.Commands
{
    public static class NewSlnContextExtensions
    {
        public static ICommandBuilderContext<NewSlnContext> SetOutputDirectoryPath(this ICommandBuilderContext<NewSlnContext> newSlnContext, string solutionDirectoryPath)
        {
            newSlnContext.CommandBuilder.AppendNamePathValuePair("--output", solutionDirectoryPath);

            return newSlnContext;
        }

        public static ICommandBuilderContext<NewSlnContext> SetName(this ICommandBuilderContext<NewSlnContext> newSlnContext, string solutionName)
        {
            newSlnContext.CommandBuilder.AppendNameValuePair("--name", solutionName);

            return newSlnContext;
        }
    }
}
