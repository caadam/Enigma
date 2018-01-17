namespace Enigma.Exceptions
{
    using System;

    public class IllegalCharacterException : Exception
    {
        private const string _message = "The character '{0}' is not valid";
        public IllegalCharacterException(string illegalCharacter) : base(string.Format(_message, illegalCharacter))
        {
        }
    }
}
