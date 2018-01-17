namespace Enigma.Exceptions
{
    using System;

    public class InvalidMachineSettingsException : Exception
    {
        private const string _message = "The settings are not valid for a '{0}' machine";
        public InvalidMachineSettingsException(string machineType) : base(string.Format(_message, machineType))
        {
        }
    }
}
