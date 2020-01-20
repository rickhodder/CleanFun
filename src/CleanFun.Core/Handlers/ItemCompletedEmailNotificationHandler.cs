using System.Threading.Tasks;
using Ardalis.GuardClauses;
using CleanFun.Core.Events;
using CleanFun.SharedKernel.Interfaces;

namespace CleanFun.Core.Services
{
    public class ItemCompletedEmailNotificationHandler : IHandle<ToDoItemCompletedEvent>
    {
        public Task Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
            return Task.CompletedTask;
        }
    }
}
