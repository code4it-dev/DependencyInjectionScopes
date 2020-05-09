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


}
