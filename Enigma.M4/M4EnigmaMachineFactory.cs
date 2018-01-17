using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma;

namespace Enigma.Machine.M4
{
    public class M4EnigmaMachineFactory : IEnigmaMachineFactory<M4EnigmaMachineFactory>
    {
        public TEnigmaMachine Create<TEnigmaMachine>(EnigmaSettings settings) where TEnigmaMachine : IEnigmaMachine<M4EnigmaMachineFactory>, new()
        {
            Console.WriteLine("Creating enigma machine: " + typeof(TEnigmaMachine));
            return new TEnigmaMachine();
        }
    }
}
