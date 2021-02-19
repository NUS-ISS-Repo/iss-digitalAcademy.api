using ISS.DigitalAcademy.Api.Registration.Command.Models;
using ISS.DigitalAcademy.Core.Cqs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ISS.DigitalAcademy.Api.Registration.Query
{
    public class GetContactHandler : IQueryHandler<GetContactRequest, GetContactResult>
    {
        public ValueTask<GetContactResult> HandleAsync(GetContactRequest command, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}

