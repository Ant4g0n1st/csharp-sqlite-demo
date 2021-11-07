using Microsoft.Extensions.Logging;

namespace SQLiteDemo.Tests.Common.Logging
{
    public class FakeLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new FakeLogger();
        }

        public void Dispose()
        {
        }
    }
}
