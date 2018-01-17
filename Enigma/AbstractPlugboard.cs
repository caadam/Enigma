namespace Enigma
{
    using System.Collections.Generic;

    public abstract class AbstractPlugboard : IPlugboard
    {
        public Dictionary<string, string> Layout { get; set; }

        public abstract string MapCharacter(string characterToMap);
    }
}
