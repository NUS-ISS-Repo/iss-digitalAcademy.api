using ISS.DigitalAcademy.Core.Cqs;

namespace ISS.DigitalAcademy.Api.Registration.Command.Models
{
    public class SubmitContactRequest : ICommand
    {
        public string Name { get; set; }
    }
}
