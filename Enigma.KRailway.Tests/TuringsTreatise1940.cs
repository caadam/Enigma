namespace Enigma.KRailway.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Enigma.Machine.KRailway;
    using System.Collections.Generic;
    using Exceptions;

    [TestClass]
    public class TuringsTreatise1940
    {
        //Wheel order: III I II 
        //Ring positions: 26 17 16 13 

        //Message key: JEZA
        //QSZVI DVMPN EXACM RWWXU IYOTY NGVVX DZ---
        //Decrypt: DEUTS QETRU PPENS INDJE TZTIN ENGLA ND--- 
        //German: Deutsche Truppen sind jetzt in England.
        //English: German troops are now in England.

        private IEnigmaMachine engimaMachine;
        private string messageKey = "JEZA";
        private string cypherText = "QSZVI DVMPN EXACM RWWXU IYOTY NGVVX DZ---";
        private string message = "DEUTS QETRU PPENS INDJE TZTIN ENGLA ND---";

        [TestInitialize]
        public void Initialize()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);
            settings.Rotors.Add(Constants.Rotors.III);

            settings.RotorPositions.Add(16);
            settings.RotorPositions.Add(17);
            settings.RotorPositions.Add(26);

            settings.Reflector = Constants.Reflectors.A;

            engimaMachine = new KRailway(settings);
        }

        [TestCleanup]
        public void Cleanup()
        {
            engimaMachine = null;
        }

        //[TestMethod]
        public void EncodeMessageExpectCorrectOutput()
        {
            string encodedmessage = engimaMachine.EncryptDecrypt(message);
            Assert.AreEqual(cypherText, encodedmessage.ToEnigmaMessageFormat(5));
        }

        //[TestMethod]
        public void DecodeMessageExpectCorrectOutput()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt(cypherText);
            Assert.AreEqual(cypherText, decodedmessage.ToEnigmaMessageFormat(5));
        }

        [TestMethod]
        public void SetupEncodeAndDecode()
        {
            // initialize setup
            string message = "This is a test message to encode and decode";
            string expectedMessage = message.ToEnigmaMessageFormat(4);

            // encode random message
            string encodedMessage = engimaMachine.EncryptDecrypt(message.ToUpper());

            // reset machine to starting values to decode
            Initialize();

            // decode message 
            string decodedMessage = engimaMachine.EncryptDecrypt(encodedMessage).ToEnigmaMessageFormat(4);

            Assert.AreEqual<string>(expectedMessage, decodedMessage);
        }

        // Dealing with illeage characters
        [TestMethod]
        [ExpectedException(typeof(IllegalCharacterException))]
        public void TestIlleageCharactersPresent()
        {
            engimaMachine.EncryptDecrypt("!@#$%^&*()");
        }
    }
}
