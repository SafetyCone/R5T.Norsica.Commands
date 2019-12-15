using System;

using R5T.Heraklion;


namespace R5T.Norsica.Commands
{
    public static class NewContextExtensions
    {
        public static ICommandBuilderContext<NewSlnContext> Solution(this ICommandBuilderContext<NewContext> newContext)
        {
            newContext.CommandBuilder.Append("sln");

            var slncontext = newContext.ChangeContext<NewSlnContext>();
            return slncontext;
        }

        public static ICommandBuilderContext<NewSlnContext> Sln(this ICommandBuilderContext<NewContext> newContext)
        {
            var slnContext = newContext.Solution();

            return slnContext;
        }
    }
}
