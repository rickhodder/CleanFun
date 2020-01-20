using System.Threading.Tasks;
using CleanFun.SharedKernel;

namespace CleanFun.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}