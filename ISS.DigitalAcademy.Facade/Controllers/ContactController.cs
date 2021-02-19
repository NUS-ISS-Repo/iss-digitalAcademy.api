using ISS.DigitalAcademy.Api.Registration.Command.Models;
using ISS.DigitalAcademy.Core.Cqs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ISS.DigitalAcademy.Facade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ICommandHandler<SubmitContactRequest, SubmitContactResult> submitContactFormHandler;
        private readonly IQueryHandler<GetContactRequest, GetContactResult> getContactFormHandler;

        public ContactController(ICommandHandler<SubmitContactRequest, SubmitContactResult> submitContactFormHandler,
            IQueryHandler<GetContactRequest, GetContactResult> getContactFormHandler)
        {
            this.submitContactFormHandler = submitContactFormHandler;
            this.getContactFormHandler = getContactFormHandler;
        }

        [HttpPost("submit")]
        public async Task<ActionResult<SubmitContactResult>> SubmitContact(SubmitContactRequest request)
        {
            var result = await submitContactFormHandler.HandleAsync(request);
            return result;
        }

        public async Task<ActionResult<GetContactResult>> GetContacts(GetContactRequest request)
        {
            var result = await getContactFormHandler.HandleAsync(request);
            return result;
        }
    }
}
