namespace Enigma
{
    using System;
    using Enigma.Exceptions;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Text;
    public static class Extensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source.IndexOf(toCheck, comp) >= 0;
        }

        public static string ToEnigmaMessageFormat(this string message, int groupSize)
        {
            // Convert to uppercase
            message = message.ToUpper();

            // Remove spaces
            message = message.Replace(" ", "");
            int messageLength = message.Length; // Needed to calc the number of trailing dashes to add

            if (groupSize != 3
                && groupSize != 4
                && groupSize != 5)
                throw new InvalidEnigmaMessageFormationException(groupSize);

            // Group in character blocks of 3, 4 or 5 characters
            message = Regex.Replace(message, string.Format(".{{{0}}}", groupSize), "$0 ").Trim();

            // Add trailing dashes
            int remainder = groupSize - (message.Length - (message.LastIndexOf(" ") + 1));

            StringBuilder outputMessage = new StringBuilder();
            outputMessage.Append(message);
            outputMessage.Append('-', remainder);

            return outputMessage.ToString(); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rotorPosition"></param>
        /// <returns></returns>
        public static int StepRotor(this int rotorPosition)
        {
            if (rotorPosition <= 0)
                throw new InvalidRotorPositionException(rotorPosition);
            else if (rotorPosition >= 26)
                rotorPosition = 1;
            else
                rotorPosition++;

            return rotorPosition;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rotorPosition"></param>
        /// <param name="wrapNumber"></param>
        /// <returns></returns>
        public static int Wrap(this int rotorPosition, int wrapNumber)
        {
            if (rotorPosition >= wrapNumber)
                rotorPosition = rotorPosition - wrapNumber;

            return rotorPosition;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rotorPosition"></param>
        /// <returns></returns>
        public static int Wrap(this int rotorPosition)
        {
            if (rotorPosition > 26)
                rotorPosition = rotorPosition - 26;
            else if (rotorPosition <= 0)
                rotorPosition = rotorPosition + 26;

            return rotorPosition;
        }

        public static int RotorCircularSubtract(this int rotorPosition, int amountToSubtract)
        {
            if ((rotorPosition - amountToSubtract) > 0)
                return rotorPosition - amountToSubtract;

            return 26 + (rotorPosition - amountToSubtract);
        }

        public static int RotorCircularAdd(this int rotorPosition, int amountToAdd)
        {
            if ((rotorPosition + amountToAdd) <= 26)
                return rotorPosition + amountToAdd;

            return (rotorPosition + amountToAdd) - 26;
        }

        public static string ToAlpha(this int rotorPosition)
        {
            if (rotorPosition > 26 || rotorPosition < 1)
                rotorPosition = rotorPosition.Wrap();

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            return characters[rotorPosition].ToString();
        }

        public static int ToInt(this string rotorCharacter)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (!characters.Contains(rotorCharacter, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new IllegalCharacterException(rotorCharacter);
            }

            return characters.IndexOf(rotorCharacter) + 1;
        }
    }
}
