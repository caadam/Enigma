namespace Enigma
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlugboardBase : AbstractPlugboard
    {
        private const string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public PlugboardBase()
        {
            this.Layout = new Dictionary<string, string>();
        }

        public PlugboardBase(Dictionary<string, string> layout)
        {
            this.Layout = layout;
        }

        public override string MapCharacter(string characterToMap)
        {
            if (!allowedCharacters.Contains(characterToMap, StringComparison.InvariantCultureIgnoreCase)
                && characterToMap != "-")
            {
                throw new IllegalCharacterException(characterToMap);
            }

            if (this.Layout.ContainsKey(characterToMap))
            {
                characterToMap = this.Layout[characterToMap];
            }
            else if (this.Layout.ContainsValue(characterToMap))
            {
                characterToMap = this.Layout.Single(x => x.Value == characterToMap).Key;
            }

            return characterToMap;
        }
    }
}
