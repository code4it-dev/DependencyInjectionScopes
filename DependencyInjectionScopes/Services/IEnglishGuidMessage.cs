namespace DependencyInjectionScopes.Services
{

    public interface IEnglishGuidMessage
    {
        string GetGuidEnglishMessage();
    }

    public class EnglishGuidMessage : IEnglishGuidMessage
    {
        private readonly IGuidGenerator guidGenerator;

        public EnglishGuidMessage(IGuidGenerator guidGenerator)
        {
            this.guidGenerator = guidGenerator;
        }
        public string GetGuidEnglishMessage() => $"{guidGenerator.GetGuid()} - English";
    }
}
