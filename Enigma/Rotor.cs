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
    public class Rotor : IRotor
    {
        private string allowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string[] allowedCharArray = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public List<RotorMapping> Mapping { get; private set; }
        public List<string> TurnoverPoints { get; private set; }
        public string Name { get; private set; }

        private int _ringstellung = 1;
        public int Ringstellung
        {
            get
            {
                return _ringstellung;
            }
            set
            {
                if (_ringstellung != value)
                {
                    _ringstellung = value;
                    SetRingstellung();
                }
            }
        }

        public string Layout { get; private set; }

        public Rotor(string rotorLayout, string name, List<string> notches, List<string> turnoverPoints, List<string> windows)
        {
            Name = name;
            Layout = rotorLayout;
            TurnoverPoints = turnoverPoints;

            InitialiseRotor();
        }

        private void InitialiseRotor()
        {
            Mapping = new List<RotorMapping>();

            string[] charSet = Regex.Split(allowedCharacters, string.Empty); ;
            string[] layoutSet = Regex.Split(Layout, string.Empty);

            for (int i = 1; i < charSet.Length - 1; i++)
            {
                bool isTurnover = false;
                int outBoundPin = (allowedCharacters.IndexOf(layoutSet[i]) + 1).RotorCircularAdd(Ringstellung -1);
                int inBoundPin = i.RotorCircularAdd(Ringstellung - 1);

                if (TurnoverPoints != null)
                {
                    isTurnover = TurnoverPoints.Contains(charSet[i], StringComparer.OrdinalIgnoreCase);
                }

                Mapping.Add(new RotorMapping(charSet[i].ToUpper(), inBoundPin, layoutSet[i].ToUpper(), outBoundPin, isTurnover));
            }
        }

        private void SetRingstellung()
        {
            if (_ringstellung > 1
                && _ringstellung <= 26)
            {
                InitialiseRotor();
            }
        }

        /// <summary>
        /// Right-to-left encoding/decoding
        /// </summary>
        /// <param name="Character"></param>
        /// <returns></returns>
        public int Inbound(int position)
        {
            position = position.RotorCircularSubtract(_ringstellung - 1);
            return Mapping.Single(r => r.InputPin == position).OutputPin;
        }

        /// <summary>
        /// Reverse traversal across rotor for encoding/decoding
        /// </summary>
        /// <param name="Character"></param>
        /// <returns></returns>
        public int Outbound(int position)
        {
            position = position.RotorCircularAdd(1 - _ringstellung - 1);
            return Mapping.Single(r => r.OutputPin == position).InputPin;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool IsTurnoverPoint(int position)
        {
            position = position.RotorCircularAdd(_ringstellung - 1);
            return Mapping.Single(r => r.InputPin == position).IsTurnoverPoint;
        }
    }
}
