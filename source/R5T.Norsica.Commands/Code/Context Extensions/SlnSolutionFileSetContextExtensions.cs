using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Norsica.Commands
{
    public static class SlnSolutionFileSetContextExtensions
    {
        public static ICommandBuilderContext<SlnAddContext> Add(this ICommandBuilderContext<SlnSolutionFileSetContext> solutionSpecifiedContext)
        {
            solutionSpecifiedContext.Append("add");

            var slnAddContext = solutionSpecifiedContext.ChangeContext<SlnAddContext>();
            return slnAddContext;
        }

        public static ICommandBuilderContext<FinishedContext> Add(this ICommandBuilderContext<SlnSolutionFileSetContext> solutionSpecifiedContext, string projectFilePath)
        {
            solutionSpecifiedContext.Add().SetProjectPath(projectFilePath);

            var finishedContext = solutionSpecifiedContext.ChangeContext<FinishedContext>();
            return finishedContext;
        }
    }
}
