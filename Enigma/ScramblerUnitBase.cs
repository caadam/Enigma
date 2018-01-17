namespace Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ScramblerUnitBase : AbstractScrabmlerUnit
    {
        public ScramblerUnitBase(EnigmaSettings settings)
        {
            this.Rotors = settings.Rotors.ToArray();
            this.RotorPositions = settings.RotorPositions.ToArray();
            this.Reflector = settings.Reflector;
            this.EntryWheel = settings.EntryWheel;
        }

        public ScramblerUnitBase(IRotor entryWheel, IReflector reflector, IRotor[] rotors, int[] rotorPositions)
        {
            this.Rotors = rotors;
            this.RotorPositions = rotorPositions;
            this.Reflector = reflector;
            this.EntryWheel = entryWheel;
        }

        public override string Scramble(string characterToScramble)
        {
            StringBuilder path = new StringBuilder();

            // Increment rotor(s)
            IncrementRotors();

            List<int> positions = new List<int>();

            // Calculator inbound character position (convert from char to int)
            int inboundPosition = Constants.Rotors.rotorStatic.Mapping.Single(m => m.InputCharacter == characterToScramble).OutputPin;
            positions.Add(inboundPosition);

            path.AppendLine(string.Format("Scrambler Input ({0}:{1})", characterToScramble, inboundPosition));

            // Traverse rotors right (position 0) to left (position 3/4)
            for (int r = 0; r < this.Rotors.Length; r++)
            {
                int inputPin = positions.Last();
                // offset is current rotor position - 1
                int offset = RotorPositions[r] - 1;

                int nextPosition = (positions.Last().RotorCircularAdd(offset));
                var mapping = this.Rotors[r].Mapping.Single(m => m.InputPin == nextPosition);

                positions.Add(mapping.OutputPin.RotorCircularSubtract(offset));

                path.Append(string.Format("Rotor {0} [{1}:{2} @ {3} -> {4}:{5} @ {6}]", this.Rotors[r].Name, mapping.InputCharacter, mapping.InputPin, inputPin, mapping.OutputCharacter, mapping.OutputPin, positions.Last()));
                if (offset > 0)
                    path.Append(string.Format(" offset by {0}", offset));

                path.Append(string.Format(" Ringstellung {0}", this.Rotors[r].Ringstellung));

                path.Append("\r\n");
            }

            //Reflectors

            var reflecMap = this.Reflector.Mapping.Single(m => m.InputPin == positions.Last().Wrap());
            path.AppendLine(string.Format("Reflector {0} [{1}:{2} -> {3}:{4}]", this.Reflector.Name, reflecMap.InputCharacter, reflecMap.InputPin, reflecMap.OutputCharacter, reflecMap.OutputPin));

            positions.Add(reflecMap.OutputPin);

            // Traverse rotors left (position 3/4) to right (position 0)
            for (int r = this.Rotors.Length - 1; r >= 0; r--)
            {
                // offset is current rotor position - 1
                int offset = RotorPositions[r] - 1;
                int outputPin = positions.Last();

                int nextPosition = positions.Last().RotorCircularAdd(offset);
                var mapping = this.Rotors[r].Mapping.Single(m => m.OutputPin == nextPosition);

                positions.Add(mapping.InputPin.RotorCircularSubtract(offset));
                positions.Add(mapping.InputPin.RotorCircularSubtract(offset));

                path.Append(string.Format("Rotor {0} [{1}:{2} @ {3} -> {4}:{5} @ {6}]", this.Rotors[r].Name, mapping.OutputCharacter, mapping.OutputPin, outputPin, mapping.InputCharacter, mapping.InputPin, positions.Last()));

                if (offset > 0)
                    path.Append(string.Format(" offset by {0}", offset));
                path.Append(string.Format(" Ringstellung {0}", this.Rotors[r].Ringstellung));

                path.Append("\r\n");
            }

            characterToScramble = Constants.Rotors.rotorStatic.Mapping.Single(m => m.OutputPin == positions.Last()).InputCharacter;
            path.AppendLine(string.Format("Scrambler Output ({0}:{1})", characterToScramble, positions.Last()));

            return characterToScramble;
        }

        /// <summary>
        /// 
        /// </summary>
        public override void IncrementRotors()
        {
            if (Rotors[1].IsTurnoverPoint(this.RotorPositions[1]))
            {
                RotorPositions[0] = RotorPositions[0].StepRotor();
                RotorPositions[1] = RotorPositions[1].StepRotor();
                RotorPositions[2] = RotorPositions[2].StepRotor();
            }
            else if (Rotors[0].IsTurnoverPoint(this.RotorPositions[0]))
            {
                RotorPositions[1] = RotorPositions[1].StepRotor();
                RotorPositions[0] = RotorPositions[0].StepRotor();
            }
            else {
                RotorPositions[0] = RotorPositions[0].StepRotor();
            }
        }
    }
}
