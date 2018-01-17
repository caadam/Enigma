namespace Enigma.Machine.M3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class M3 : EnigmaMachineBase
    {
        public M3(EnigmaSettings settings) : base(settings) { }
    }

    public class M3ScrabmlerUnit : ScramblerUnitBase
    {
        public M3ScrabmlerUnit(EnigmaSettings settings) : base(settings)
        {
            // Validate settings
            //  validate wheel numbers
            //  validate wheel types
            //  validate reflector 
            //  validate plugboard
        }
    }
}
