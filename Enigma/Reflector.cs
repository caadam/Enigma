namespace Enigma
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public class Reflector : IReflector
    {
        private string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string[] allowedCharArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public List<RotorMapping> Mapping { get; private set; }
        public string Name { get; private set; }
        public string Layout { get; private set; }

        public Reflector(string layout, string name)
        {
            Name = name;
            Layout = layout;

            Mapping = new List<RotorMapping>();

            string[] charSet = Regex.Split(allowedCharacters, string.Empty); ;
            string[] layoutSet = Regex.Split(layout, string.Empty);

            for (int i = 1; i < charSet.Length - 1; i++)
            {
                bool isTurnover = false;
                int outBoundPin = (allowedCharacters.IndexOf(layoutSet[i]) + 1);
                int inBoundPin = i;

                Mapping.Add(new RotorMapping(charSet[i].ToUpper(), inBoundPin, layoutSet[i].ToUpper(), outBoundPin, isTurnover));
            }
        }

        /// <summary>
        /// Right-to-left encoding/decoding
        /// </summary>
        /// <param name="Character"></param>
        /// <returns></returns>
        public int Inbound(int position)
        {
            return Mapping.Single(r => r.InputPin == position).OutputPin;
        }

        /// <summary>
        /// Reverse traversal across rotor for encoding/decoding
        /// </summary>
        /// <param name="Character"></param>
        /// <returns></returns>
        public int Outbound(int position)
        {
            return Mapping.Single(r => r.OutputPin == position).InputPin;
        }
    }
}
