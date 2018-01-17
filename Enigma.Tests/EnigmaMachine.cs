namespace Enigma.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Exceptions;

    [TestClass]
    public class EnigmaMachine
    {
        [TestMethod]
        public void TestEnigmaMachineValidCharacter()
        {
            IScramblerUnit scrambler = new Enigma.Fakes.StubIScramblerUnit()
            {
                ScrambleString = (S) => { return "A"; }
            };

            IPlugboard plugboard = new Enigma.Fakes.StubIPlugboard()
            {
                MapCharacterString = (S) => { return "A"; }
            };

            IEnigmaMachine machine = new EnigmaMachineBase(plugboard, scrambler);

            Assert.AreEqual<string>("A", machine.EncryptDecrypt("A"));
        }

        [TestMethod]
        public void TestEnigmaMachineIgnoreDash()
        {
            IScramblerUnit scrambler = new Enigma.Fakes.StubIScramblerUnit()
            {
                ScrambleString = (S) => { return "A"; }
            };

            IPlugboard plugboard = new Enigma.Fakes.StubIPlugboard()
            {
                MapCharacterString = (S) => { return "A"; }
            };

            IEnigmaMachine machine = new EnigmaMachineBase(plugboard, scrambler);

            Assert.AreEqual<string>("-", machine.EncryptDecrypt("-"));
        }

        [TestMethod]
        [ExpectedException(typeof(IllegalCharacterException))]
        public void TestEnigmaMachineThrowIllegalCharacterExceptionOnInvalidCharacter()
        {
            IScramblerUnit scrambler = new Enigma.Fakes.StubIScramblerUnit()
            {
                ScrambleString = (S) => { return "A"; }
            };

            IPlugboard plugboard = new Enigma.Fakes.StubIPlugboard()
            {
                MapCharacterString = (S) => { return "A"; }
            };

            IEnigmaMachine machine = new EnigmaMachineBase(plugboard, scrambler);

            Assert.AreEqual<string>("A", machine.EncryptDecrypt("!@#$%^&*()"));
        }
    }
}
