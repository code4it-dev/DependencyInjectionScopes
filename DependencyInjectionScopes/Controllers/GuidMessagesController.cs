using DependencyInjectionScopes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DependencyInjectionScopes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuidMessagesController : ControllerBase
    {
        private readonly IEnglishGuidMessage englishGuidMessage;
        private readonly IItalianGuidMessage italianGuidMessage;

        public GuidMessagesController(IItalianGuidMessage italianGuidMessage, IEnglishGuidMessage englishGuidMessage)
        {
            this.englishGuidMessage = englishGuidMessage;
            this.italianGuidMessage = italianGuidMessage;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var messages = new List<string>
            {
                italianGuidMessage.GetGuidMessage(),
                englishGuidMessage.GetGuidMessage()
            };
            return messages;
        }
    }
}
