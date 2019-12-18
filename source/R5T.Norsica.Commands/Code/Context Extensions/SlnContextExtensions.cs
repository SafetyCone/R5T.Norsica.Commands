using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Norsica.Commands
{
    public static class SlnContextExtensions
    {
        public static ICommandBuilderContext<SlnSolutionFileSetContext> SetSolutionFile(this ICommandBuilderContext<SlnContext> slnContext, string solutionFilePath)
        {
            slnContext.AppendPath(solutionFilePath);

            var slnSolutionSpecifiedContext = slnContext.ChangeContext<SlnSolutionFileSetContext>();
            return slnSolutionSpecifiedContext;
        }
    }
}
