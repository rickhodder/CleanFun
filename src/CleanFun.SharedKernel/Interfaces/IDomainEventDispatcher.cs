using System.Threading.Tasks;
using CleanFun.SharedKernel;

namespace CleanFun.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}