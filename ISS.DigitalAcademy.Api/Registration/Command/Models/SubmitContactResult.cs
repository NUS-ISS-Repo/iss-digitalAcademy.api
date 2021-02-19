using ISS.DigitalAcademy.Core.Cqs;

namespace ISS.DigitalAcademy.Api.Registration.Command.Models
{
    public class SubmitContactResult : ICommandResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
