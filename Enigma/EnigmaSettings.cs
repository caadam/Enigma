namespace Enigma
{
    using System.Collections.Generic;

    /// <summary>
    /// Ringstellung = Ring settings
    /// </summary>
    public class EnigmaSettings
    {
        /// <summary>
        /// Steckerbrett - Plugboard
        /// </summary>
        //public Dictionary<string, string> PlugBoard { get; set; }
        public IPlugboard PlugBoard { get; set; }

        /// <summary>
        /// Entrittswalze  - Static rotor
        /// </summary>
        public IRotor StaticRotor { get; set; }

        /// <summary>
        /// Entry rotor(ETW)
        /// </summary>
        public IRotor EntryWheel { get; set; }


        /// <summary>
        /// Walzenlage - Rotors (Walzenlage = rotor order)
        /// Ringstellung - Ring settings
        /// </summary>
        public List<IRotor> Rotors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<int> RotorPositions { get; set; }

        /// <summary>
        /// Umkehrwalze - Reflactor wheel
        /// </summary>
        public IReflector Reflector { get; set; }

        public EnigmaSettings()
        {
            Rotors = new List<IRotor>();
            RotorPositions = new List<int>();
            PlugBoard = new PlugboardBase();
        }

        public EnigmaSettings(IRotor etw, List<IRotor> rotors, IPlugboard plugboard, List<int> rotorPositions)
        {
            EntryWheel = etw;
            Rotors = rotors;
            PlugBoard = plugboard;
            RotorPositions = rotorPositions;
        }
    }
}
