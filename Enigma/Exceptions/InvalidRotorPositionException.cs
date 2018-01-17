namespace Enigma.Exceptions
{
    using System;

    public class InvalidRotorPositionException : Exception
    {
        private const string _message = "'{0}' is not valid rotor position. 1-26 are valid positions";
        public InvalidRotorPositionException(int rotorPosition) : base(string.Format(_message, rotorPosition))
        {
        }
    }
}
