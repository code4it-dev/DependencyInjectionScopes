namespace DependencyInjectionScopes.Services
{

    public interface IEnglishGuidMessage
    {
        string GetGuidMessage();
    }

    public class EnglishGuidMessage : IEnglishGuidMessage
    {
        private readonly IGuidGenerator guidGenerator;

        public EnglishGuidMessage(IGuidGenerator guidGenerator)
        {
            this.guidGenerator = guidGenerator;
        }
        public string GetGuidMessage() => $"{guidGenerator.GetGuid()} - English";
    }
}
