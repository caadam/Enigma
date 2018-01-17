namespace Enigma.Exceptions
{
    using System;
    public class InvalidEnigmaMessageFormationException : Exception
    {
        private const string _message = "'{0}' is not a valid option for Enigma message formatting. Valid options are 3,4 or 5";
        public InvalidEnigmaMessageFormationException(int groupSize) : base(string.Format(_message, groupSize))
        {
        }
    }
}
