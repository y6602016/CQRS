using CQRS.Core.Commands;

namespace CQRS.Core.Infrastructure
{
  // dispatcher working as a mediator that manages the distribution of messages(commands) among other objects
  public interface ICommandDispatcher
  {
    void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand;
    Task SendAsync(BaseCommand command);
  }
}