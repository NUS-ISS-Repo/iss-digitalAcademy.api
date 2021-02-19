using System.Threading;
using System.Threading.Tasks;

namespace ISS.DigitalAcademy.Core.Cqs
{
    public interface IQueryHandler<in T1, T2> where T1 : IQuery
                                                where T2 : IQueryResult
    {
        ValueTask<T2> HandleAsync(T1 command, CancellationToken token = default);
    }


}
