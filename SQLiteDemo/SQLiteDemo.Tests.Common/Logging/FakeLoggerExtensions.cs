using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;

namespace SQLiteDemo.Tests.Common.Logging
{
    public static class FakeLoggerExtensions
    {

        public static ILoggingBuilder AddFakeLogger(this ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.AddConfiguration();
            loggingBuilder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, FakeLoggerProvider>());
            return loggingBuilder;
        }

    }
}
