using System;
using System.Diagnostics;

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
            Debug.WriteLine($"Calling getGuid: {_guid}");
        }

        public Guid GetGuid()
        {
            return _guid;
        }
    }


}
