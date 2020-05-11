using DependencyInjectionScopes.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;

namespace DependencyInjectionScopes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuidMessagesController : ControllerBase
    {
        private readonly IEnglishGuidMessage englishGuidMessage;
        private readonly IItalianGuidMessage italianGuidMessage;
        private readonly IServiceCollection serviceCollection;

        public GuidMessagesController(IItalianGuidMessage italianGuidMessage, IEnglishGuidMessage englishGuidMessage, IServiceCollection serviceCollection)
        {
            this.englishGuidMessage = englishGuidMessage;
            this.italianGuidMessage = italianGuidMessage;
            this.serviceCollection = serviceCollection;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var guidLifetime = serviceCollection.Where(s => s.ServiceType == typeof(IGuidGenerator)).Last().Lifetime;
            var messages = new List<string>
            {
                $"IGuidGenerator lifetime: {guidLifetime}",
                italianGuidMessage.GetGuidItalianMessage(),
                englishGuidMessage.GetGuidEnglishMessage()
            };
            Debug.WriteLine("After Get in Controller");

            return messages;
        }
    }
}
