using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Norsica.Commands
{
    public static class SlnAddContextExtensions
    {
        public static ICommandBuilderContext<SlnAddContext> SetProjectPath(this ICommandBuilderContext<SlnAddContext> slnAddContext, string projectFilePath)
        {
            slnAddContext.AppendPath(projectFilePath);

            return slnAddContext;
        }

        /// <summary>
        /// Sets the "--in-root" option (no idea what that is though!).
        /// </summary>
        public static ICommandBuilderContext<SlnAddContext> SetInRoot(this ICommandBuilderContext<SlnAddContext> slnAddContext)
        {
            slnAddContext.Append("--in-root");

            return slnAddContext;
        }

        /// <summary>
        /// Sets the "--solution-folder" option (no idea what that is though!).
        /// </summary>
        public static ICommandBuilderContext<SlnAddContext> SetSolutionFolder(this ICommandBuilderContext<SlnAddContext> slnAddContext)
        {
            slnAddContext.Append("--solution-folder");

            return slnAddContext;
        }
    }
}
