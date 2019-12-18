using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Norsica.Commands
{
    public static class DotnetContextExtensions
    {
        public static ICommandBuilderContext<NewContext> New(this ICommandBuilderContext<DotnetContext> dotnetContext)
        {
            dotnetContext.Append("new");

            var dotnetNewContext = dotnetContext.ChangeContext<NewContext>();
            return dotnetNewContext;
        }

        public static ICommandBuilderContext<SlnContext> Sln(this ICommandBuilderContext<DotnetContext> dotnetContext)
        {
            dotnetContext.Append("sln");

            var slnContext = dotnetContext.ChangeContext<SlnContext>();
            return slnContext;
        }

        public static ICommandBuilderContext<SlnSolutionFileSetContext> Sln(this ICommandBuilderContext<DotnetContext> dotnetContext, string solutionFilePath)
        {
            var slnSpecifiedContext = dotnetContext.Sln().SetSolutionFile(solutionFilePath);
            return slnSpecifiedContext;
        }
    }
}
