using System;

using R5T.Heraklion;
using R5T.Piraeus.Extensions;


namespace R5T.Norsica.Commands
{
    public static class NewProjectContextExtensions
    {
        public static ICommandBuilderContext<TNewProjectContext> SetLanguage<TNewProjectContext>(this ICommandBuilderContext<TNewProjectContext> newProjectContext, string language)
            where TNewProjectContext: NewProjectContext
        {
            newProjectContext.CommandBuilder.AppendNameValuePair("--language", language);

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewProjectContext> SetCSharpLanguage<TNewProjectContext>(this ICommandBuilderContext<TNewProjectContext> newProjectContext)
            where TNewProjectContext : NewProjectContext
        {
            newProjectContext.SetLanguage("\"C#\"");

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewProjectContext> SetOutputDirectory<TNewProjectContext>(this ICommandBuilderContext<TNewProjectContext> newProjectContext, string outputDirectoryPath)
            where TNewProjectContext : NewProjectContext
        {
            newProjectContext.CommandBuilder.AppendNamePathValuePair("--output", outputDirectoryPath);

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewProjectContext> SetProjectName<TNewProjectContext>(this ICommandBuilderContext<TNewProjectContext> newProjectContext, string projectName)
            where TNewProjectContext : NewProjectContext
        {
            newProjectContext.CommandBuilder.AppendNamePathValuePair("--name", projectName);

            return newProjectContext;
        }
    }
}
