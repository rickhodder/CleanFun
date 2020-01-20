using System.Threading.Tasks;
using CleanFun.SharedKernel.Interfaces;
using CleanFun.SharedKernel;

namespace CleanFun.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
