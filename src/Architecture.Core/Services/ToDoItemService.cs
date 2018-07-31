using Ardalis.GuardClauses;
using Architecture.Core.Events;
using Architecture.Core.Interfaces;

namespace Architecture.Core.Services
{
    public class ToDoItemService : IHandle<ToDoItemCompletedEvent>
    {
        public void Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
        }
    }
}
