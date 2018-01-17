namespace Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //public interface IEnigmaMachineFactory<TEnigmaMachineFactory>
    //{
    //    TEnigmaMachine Create<TEnigmaMachine>(EnigmaSettings settings) where TEnigmaMachine : IEnigmaMachine<TEnigmaMachineFactory>, new();
    //}

    public class EnigmaFactory
    {
        /// <summary>
        /// Create an M3 (Army/Navy/Airforce) engmia device
        /// </summary>
        /// <returns></returns>
        //public static IEnigmaMachine Create<TEngimaMachine>(EnigmaSettings settings) where TEngimaMachine : IEnigmaMachine
        //{
            //1. Set the Sequence of Rotors(Code Wheels) on the rotor shaft.
            //2. Set the Number or Letter Rings on each of the 3 Rotors(Code Wheels).
            //3. Set the Number or Letter to be visible through the 3 windows at the start of coding.
            //4. Insert Double-Plug Cables into the Plugboard (Patch Panel).

            //return new TEngimaMachine();
        //}   
    }

    /// <summary>
    /// 
    /// </summary>
    //public class EnigmaFactory : IEnigmaFactory
    //{
    //    /// <summary>
    //    /// Create an M3 (Army/Navy/Airforce) engmia device
    //    /// </summary>
    //    /// <returns></returns>
    //    public static IEnigmaMachine Create<TEngimaMachine>(EnigmaSettings settings) where TEngimaMachine : IEnigmaMachine
    //    {
    //        //1. Set the Sequence of Rotors(Code Wheels) on the rotor shaft.
    //        //2. Set the Number or Letter Rings on each of the 3 Rotors(Code Wheels).
    //        //3. Set the Number or Letter to be visible through the 3 windows at the start of coding.
    //        //4. Insert Double-Plug Cables into the Plugboard (Patch Panel).

    //        //return new TEngimaMachine();
    //        return new EnigmaMachine(settings);
    //    }

    //    /// <summary>
    //    /// Create an M4 (Navy) engmia device
    //    /// </summary>
    //    /// <param name="settings"></param>
    //    /// <returns></returns>
    //    public static IEnigmaMachine CreateM4(EnigmaSettings settings)
    //    {
    //        //1. Set the Sequence of Rotors(Code Wheels) on the rotor shaft.
    //        //2. Set the Number or Letter Rings on each of the 3 Rotors(Code Wheels).
    //        //3. Set the Number or Letter to be visible through the 3 windows at the start of coding.
    //        //4. Insert Double-Plug Cables into the Plugboard (Patch Panel).

    //        //EnigmaSettings settings = new EnigmaSettings();

    //        //settings.Reflector = reflector;

    //        //settings.Rotors.Add(r1);
    //        //settings.Rotors.Add(r2);
    //        //settings.Rotors.Add(r3);
    //        //settings.Rotors.Add(r4);

    //        //settings.PlugBoard = plugBoard;

    //        return new EnigmaMachine(settings);
    //    }
    //}
}
