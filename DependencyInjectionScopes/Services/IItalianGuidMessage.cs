namespace DependencyInjectionScopes.Services
{

    public interface IItalianGuidMessage
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
        public string GetGuidMessage() => $"{guidGenerator.GetGuid()} - Italian";
    }
}
