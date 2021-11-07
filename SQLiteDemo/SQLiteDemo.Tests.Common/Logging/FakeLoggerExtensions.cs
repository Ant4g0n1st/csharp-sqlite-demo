using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Tests.Common.Logging
{
    public static class FakeLoggerExtensions
    {

        public static ILoggingBuilder AddFakeLogger(this ILoggingBuilder loggingBuilder) {
            loggingBuilder.AddConfiguration();
            loggingBuilder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, FakeLoggerProvider>());
            return loggingBuilder;
        }

    }
}
