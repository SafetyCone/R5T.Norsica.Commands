using System;

using R5T.Heraklion;
using R5T.Heraklion.Extensions;


namespace R5T.Norsica.Commands
{
    public static class PublishContextExtensions
    {
        public static ICommandBuilderContext<PublishContext> SetProjectFile(this ICommandBuilderContext<PublishContext> publishContext, string projectFilePath)
        {
            publishContext.AppendPath(projectFilePath);

            return publishContext;
        }

        public static ICommandBuilderContext<PublishContext> SetBuildConfigurationName(this ICommandBuilderContext<PublishContext> publishContext, string buildConfigurationName)
        {
            publishContext.AppendNameValuePair("--configuration", buildConfigurationName);

            return publishContext;
        }

        public static ICommandBuilderContext<PublishContext> SetFramework(this ICommandBuilderContext<PublishContext> publishContext, string frameworkName)
        {
            publishContext.AppendNameValuePair("--framework", frameworkName);

            return publishContext;
        }

        public static ICommandBuilderContext<PublishContext> SetOutputDirectoryPath(this ICommandBuilderContext<PublishContext> publishContext, string outputDirectoryPath)
        {
            publishContext.AppendNameValuePair("--output", outputDirectoryPath);

            return publishContext;
        }
    }
}
