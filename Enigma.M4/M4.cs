namespace Enigma.Machine.M4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class M4 : EnigmaMachineBase
    {
        public M4(EnigmaSettings settings) : base(settings) { }
    }

    public class M4ScrabmlerUnit : ScramblerUnitBase
    {
        public M4ScrabmlerUnit(EnigmaSettings settings) : base(settings)
        {
            // Validate settings
            //  validate wheel numbers
            //  validate wheel types
            //  validate reflector 
            //  validate plugboard
        }
    }
}
