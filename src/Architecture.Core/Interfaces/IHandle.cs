using Architecture.Core.SharedKernel;

namespace Architecture.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}