using CleanFun.Core.Entities;
using CleanFun.Core.Events;
using CleanFun.Core.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CleanFun.UnitTests.Core.Entities
{
    public class ItemCompletedEmailNotificationHandlerHandle
    {
        [Fact]
        public async Task ThrowsExceptionGivenNullEventArgument()
        {
            var handler = new ItemCompletedEmailNotificationHandler();

            Exception ex = await Assert.ThrowsAsync<ArgumentNullException>(() => handler.Handle(null));
        }

        [Fact]
        public async Task DoesNothingGivenEventInstance()
        {
            var handler = new ItemCompletedEmailNotificationHandler();

            await handler.Handle(new ToDoItemCompletedEvent(new ToDoItem()));
        }
    }
}
