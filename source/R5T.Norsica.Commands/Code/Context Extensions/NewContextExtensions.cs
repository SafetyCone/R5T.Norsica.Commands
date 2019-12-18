using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;
using R5T.Piraeus.Extensions;


namespace R5T.Norsica.Commands
{
    public static class NewContextExtensions
    {
        public static ICommandBuilderContext<NewSolutionContext> Solution(this ICommandBuilderContext<NewContext> newContext)
        {
            newContext.CommandBuilder.Append("sln");

            var solutionContext = newContext.ChangeContext<NewSolutionContext>();
            return solutionContext;
        }

        public static ICommandBuilderContext<NewSolutionContext> Sln(this ICommandBuilderContext<NewContext> newContext)
        {
            var solutionContext = newContext.Solution();

            return solutionContext;
        }

        /// <summary>
        /// Requires the "sln2017" dotnet new template available at: https://www.nuget.org/packages/R5T.Templates.Solution.VS2017/.
        /// </summary>
        public static ICommandBuilderContext<NewSolution2017Context> Solution2017(this ICommandBuilderContext<NewContext> newContext)
        {
            newContext.CommandBuilder.Append("sln2017");

            var solution2017Context = newContext.ChangeContext<NewSolution2017Context>();
            return solution2017Context;
        }

        /// <summary>
        /// Requires the "sln2019" dotnet new template available at: https://www.nuget.org/packages/R5T.Templates.Solution.VS2019/.
        /// </summary>
        public static ICommandBuilderContext<NewSolution2019Context> Solution2019(this ICommandBuilderContext<NewContext> newContext)
        {
            newContext.CommandBuilder.Append("sln2019");

            var solution2019Context = newContext.ChangeContext<NewSolution2019Context>();
            return solution2019Context;
        }

        public static ICommandBuilderContext<NewCSharpProjectContext> CSharpProject(this ICommandBuilderContext<NewContext> newContext, string projectTemplateShortName)
        {
            newContext
                .Append(projectTemplateShortName)
                .SetCSharpLanguage()
                ;

            var newCsharpProjectContext = newContext.ChangeContext<NewCSharpProjectContext>();
            return newCsharpProjectContext;
        }

        public static ICommandBuilderContext<TNewContext> SetOutputDirectoryPath<TNewContext>(this ICommandBuilderContext<TNewContext> newSlnContext, string solutionDirectoryPath)
            where TNewContext : NewContext
        {
            newSlnContext.CommandBuilder.AppendNamePathValuePair("--output", solutionDirectoryPath);

            return newSlnContext;
        }

        public static ICommandBuilderContext<TNewContext> SetName<TNewContext>(this ICommandBuilderContext<TNewContext> newSlnContext, string solutionName)
            where TNewContext : NewContext
        {
            newSlnContext.CommandBuilder.AppendNameValuePair("--name", solutionName);

            return newSlnContext;
        }

        public static ICommandBuilderContext<TNewContext> SetLanguage<TNewContext>(this ICommandBuilderContext<TNewContext> newProjectContext, string language)
            where TNewContext : NewContext
        {
            newProjectContext.CommandBuilder.AppendNameValuePair("--language", language);

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewContext> SetCSharpLanguage<TNewContext>(this ICommandBuilderContext<TNewContext> newProjectContext)
            where TNewContext : NewContext
        {
            newProjectContext.SetLanguage("\"C#\"");

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewContext> SetOutputDirectory<TNewContext>(this ICommandBuilderContext<TNewContext> newProjectContext, string outputDirectoryPath)
            where TNewContext : NewContext
        {
            newProjectContext.CommandBuilder.AppendNamePathValuePair("--output", outputDirectoryPath);

            return newProjectContext;
        }

        public static ICommandBuilderContext<TNewContext> SetProjectName<TNewContext>(this ICommandBuilderContext<TNewContext> newProjectContext, string projectName)
            where TNewContext : NewContext
        {
            newProjectContext.CommandBuilder.AppendNamePathValuePair("--name", projectName);

            return newProjectContext;
        }
    }
}
