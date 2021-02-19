using ISS.DigitalAcademy.Core.Cqs;

namespace ISS.DigitalAcademy.Api.Registration.Command.Models
{
    public class GetContactRequest : IQuery
    {
        public string Name { get; set; }
    }

    public class GetContactResult : IQueryResult
    {

    }
}
