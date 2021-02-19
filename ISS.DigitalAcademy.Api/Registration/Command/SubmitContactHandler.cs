using ISS.DigitalAcademy.Api.Registration.Command.Models;
using ISS.DigitalAcademy.Core.Cqs;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ISS.DigitalAcademy.Api.Registration.Command
{
    public class SubmitContactHandler : ICommandHandler<SubmitContactRequest, SubmitContactResult>
    {
        public ValueTask<SubmitContactResult> HandleAsync(SubmitContactRequest command, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}
