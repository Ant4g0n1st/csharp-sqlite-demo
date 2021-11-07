using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SQLiteDemo.Tests.Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.Test.Util
{
    public static class GenericHostUtilities
    {
        public static IHostBuilder CreateBuilderWithFakeLogging() =>
            Host.CreateDefaultBuilder()
                .ConfigureLogging(builder => builder.ClearProviders().AddFakeLogger());
    }
}
