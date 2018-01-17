namespace Enigma
{
    public class RotorMapping
    {
        public string InputCharacter { get; set; }
        public int InputPin { get; set; }
        public string OutputCharacter { get; set; }
        public int OutputPin { get; set; }
        public bool IsTurnoverPoint { get; set; }

        public RotorMapping(string inputCharacter, int inputPin, string outputCharacter, int outputPin, bool isTurnoverPoint)
        {
            InputCharacter = inputCharacter;
            InputPin = inputPin;
            OutputCharacter = outputCharacter;
            OutputPin = outputPin;
            IsTurnoverPoint = isTurnoverPoint;
        }
    }
}
