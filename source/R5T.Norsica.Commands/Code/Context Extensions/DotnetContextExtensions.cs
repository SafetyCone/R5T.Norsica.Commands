using System;

using R5T.Heraklion;


namespace R5T.Norsica.Commands
{
    public static class DotnetContextExtensions
    {
        public static ICommandBuilderContext<NewContext> New(this ICommandBuilderContext<DotnetContext> dotnetContext)
        {
            dotnetContext.CommandBuilder.Append("new");

            var dotnetNewContext = dotnetContext.ChangeContext<NewContext>();
            return dotnetNewContext;
        }
    }
}
