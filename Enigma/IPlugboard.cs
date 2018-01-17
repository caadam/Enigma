namespace Enigma
{
    using System.Collections.Generic;

    public interface IPlugboard
    {
        Dictionary<string, string> Layout { get; set; }

        string MapCharacter(string characterToMap);
    }
}
