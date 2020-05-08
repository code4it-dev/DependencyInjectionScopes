using System;

namespace DependencyInjectionScopes.Services
{
    public interface IGuidGenerator
    {
        Guid GetGuid();
    }

    public class GuidGenerator : IGuidGenerator
    {
        private readonly Guid _guid;

        public GuidGenerator()
        {
            _guid = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return _guid;
        }
    }

    public interface IItalianGuidMessage
    {
        string GetGuidMessage();
    }

    public interface IEnglishGuidMessage
    {
        string GetGuidMessage();
    }

    public class ItalianGuidMessage : IItalianGuidMessage
    {
        private readonly IGuidGenerator guidGenerator;

        public ItalianGuidMessage(IGuidGenerator guidGenerator)
        {
            this.guidGenerator = guidGenerator;
        }
        public string GetGuidMessage() => $"Un messaggio con id {guidGenerator.GetGuid()}";
    }


    public class EnglishGuidMessage : IEnglishGuidMessage
    {
        private readonly IGuidGenerator guidGenerator;

        public EnglishGuidMessage(IGuidGenerator guidGenerator)
        {
            this.guidGenerator = guidGenerator;
        }
        public string GetGuidMessage() => $"A message with id {guidGenerator.GetGuid()}";
    }
}
