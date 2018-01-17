namespace Enigma
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class EnigmaMachineBase : AbstractEnigmaMachine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="machineSettings"></param>
        public EnigmaMachineBase(EnigmaSettings machineSettings)
        {
            PlugBoard = machineSettings.PlugBoard;
            ScramblerUnit = new ScramblerUnitBase(machineSettings);
        }

        public EnigmaMachineBase(IPlugboard plugBoard, IScramblerUnit scramblerUnit)
        {
            PlugBoard = plugBoard;
            ScramblerUnit = scramblerUnit;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public override string EncryptDecrypt(string message)
        {
            string output = string.Empty;
            string[] text = Regex.Split(message.Replace(" ", ""), string.Empty);

            for (int i = 1; i < text.Length - 1; i++)
            {
                output = string.Format("{0}{1}", output, Traverse(text[i]));
            }

            return output;
        }

        /// <summary>
        /// Keyboard (implicit)
        /// Plugboard 
        /// Traverse rotors
        /// Reflectors
        /// Traverse rotors in reverse
        /// Plugboard 
        /// Lampboard (return string/char)
        /// </summary>
        /// <param name="character"></param>
        /// <returns></returns>
        private string Traverse(string character)
        {
            // Validate input message for invalid characters
            if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ-".Contains(character, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new IllegalCharacterException(character);
            }

            // Ignore padding dash
            if (character == "-")
                return character;

            //Plugboard 
            character = this.PlugBoard.MapCharacter(character);

            // Traverse rotors
            character = this.ScramblerUnit.Scramble(character);

            //Plugboard
            character = this.PlugBoard.MapCharacter(character);

            return character;
        }
    }
}
