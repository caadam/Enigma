namespace Enigma
{
    public abstract class AbstractScrabmlerUnit : IScramblerUnit
    {
        public IRotor[] Rotors { get; protected set; }
        public int[] RotorPositions { get; set; }
        public IReflector Reflector { get; protected set; }
        public IRotor EntryWheel { get; protected set; }
        public abstract string Scramble(string characterToScramble);
        public abstract void IncrementRotors();
    }
}
