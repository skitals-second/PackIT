using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<Tcommand>(Tcommand command) where Tcommand : class, ICommand;
    }
}