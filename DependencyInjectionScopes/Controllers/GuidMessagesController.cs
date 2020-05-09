using DependencyInjectionScopes.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace DependencyInjectionScopes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuidMessagesController : ControllerBase
    {
        private readonly IEnglishGuidMessage englishGuidMessage;
        private readonly IItalianGuidMessage italianGuidMessage;
        private readonly IServiceCollection coll;

        public GuidMessagesController(IItalianGuidMessage italianGuidMessage, IEnglishGuidMessage englishGuidMessage, IServiceCollection coll)
        {
            this.englishGuidMessage = englishGuidMessage;
            this.italianGuidMessage = italianGuidMessage;
            this.coll = coll;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var guidLifetime = coll.Where(s => s.ServiceType == typeof(IGuidGenerator)).Last().Lifetime;
            var messages = new List<string>
            {
                $"IGuidGenerator lifetime: {guidLifetime}",
                italianGuidMessage.GetGuidMessage(),
                englishGuidMessage.GetGuidMessage()
            };
            return messages;
        }
    }
}
