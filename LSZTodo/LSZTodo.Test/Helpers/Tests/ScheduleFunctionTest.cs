using LSZTodo.Functions.Functions;
using System;
using Xunit;
using LSZTodo.Test.Helpers;
using Microsoft.Extensions.Logging;

namespace LSZTodo.Test.Helpers.Tests
{
    public class ScheduleFunctionTest
    {

        [Fact]
        public void ScheduleFunction_Should_Log_Message() 
        {

            // Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreaccount1/reports"));
            ListLoggers logger = (ListLoggers)TestFactory.CreateLogger(LoggerTypes.List);

            // Act
            ScheduleFunction.RunAsync(null, mockTodos, logger);
            string message = logger.Logs[0];

            // Assert
            Assert.Contains("Delete function completed", message);
        }
    }
}
