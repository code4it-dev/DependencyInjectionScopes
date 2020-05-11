namespace DependencyInjectionScopes.Services
{

    public interface IItalianGuidMessage
    {
        string GetGuidItalianMessage();
    }

    public class ItalianGuidMessage : IItalianGuidMessage
    {
        private readonly IGuidGenerator guidGenerator;

        public ItalianGuidMessage(IGuidGenerator guidGenerator)
        {
            this.guidGenerator = guidGenerator;
        }
        public string GetGuidItalianMessage() => $"{guidGenerator.GetGuid()} - Italian";
    }
}
