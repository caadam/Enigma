namespace Enigma
{
    public interface IScramblerUnit
    {
        string Scramble(string characterToScramble);
        int[] RotorPositions { get; }
        IReflector Reflector { get; }
        IRotor EntryWheel { get; }
        IRotor[] Rotors { get; }
    }
}
