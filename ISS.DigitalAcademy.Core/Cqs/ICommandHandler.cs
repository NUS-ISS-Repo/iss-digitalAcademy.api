using System.Threading;
using System.Threading.Tasks;

namespace ISS.DigitalAcademy.Core.Cqs
{
    public interface ICommandHandler<in T1, T2> where T1 : ICommand
                                                where T2 : ICommandResult
    {
        ValueTask<T2> HandleAsync(T1 command, CancellationToken token = default);
    }


}
