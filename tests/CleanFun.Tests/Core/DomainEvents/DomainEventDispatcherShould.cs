using CleanFun.Core.Entities;
using CleanFun.Core.Events;
using CleanFun.Infrastructure;
using CleanFun.Infrastructure.DomainEvents;
using Xunit;

namespace CleanFun.UnitTests.Core.DomainEvents
{
    public class DomainEventDispatcherShould
    {
        [Fact]
        public void NotReturnAnEmptyListOfAvailableHandlers()
        {
            var container = ContainerSetup.BaseAutofacInitialization();

            var domainEventDispatcher = new DomainEventDispatcher(container);
            var toDoItemCompletedEvent = new ToDoItemCompletedEvent(new ToDoItem());

            var handlersForEvent = domainEventDispatcher.GetWrappedHandlers(toDoItemCompletedEvent);

            Assert.NotEmpty(handlersForEvent);
        }
    }
}
