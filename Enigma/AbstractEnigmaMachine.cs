namespace Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public abstract class AbstractEnigmaMachine : IEnigmaMachine
    {
        public IScramblerUnit ScramblerUnit { get; protected set; }
        public IPlugboard PlugBoard { get; protected set; }
        public abstract string EncryptDecrypt(string message);
    }
}
