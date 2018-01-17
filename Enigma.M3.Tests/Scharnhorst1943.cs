namespace Enigma.M3.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Enigma.Machine.M3;
    using Exceptions;
    [TestClass]
    public class Scharnhorst1943
    {
        //Scharnhorst (Konteradmiral Erich Bey), 1943
        //Reflector: B
        //Wheel order: III VI VIII
        //Ring positions: 01 08 13  
        //Plug pairs: AN EZ HK IJ LR MQ OT PV SW UX
        //Message key: UZV

        //YKAE NZAP MSCH ZBFO CUVM RMDP YCOF HADZ IZME FXTH FLOL PZLF GGBO TGOX GRET DWTJ IQHL MXVJ WKZU ASTR
        //Decrypt: STEUE REJTA NAFJO RDJAN STAND ORTQU AAACC CVIER NEUNN EUNZW OFAHR TZWON ULSMX XSCHA RNHOR STHCO
        //German: Steuere Tanafjord an.Standort Quadrat AC4992, fahrt 20sm.Scharnhorst. [hco - padding ?]
        //English: Heading for Tanafjord.Position is square AC4992, speed 20 knots.Scharnhorst.

        #region Full Encrypt Log
        #endregion

        #region Full Decrypt Log
        #endregion

        private IEnigmaMachine engimaMachine;
        private string messageKey = "UZV";
        private string cypherText = "YKAE NZAP MSCH ZBFO CUVM RMDP YCOF HADZ IZME FXTH FLOL PZLF GGBO TGOX GRET DWTJ IQHL MXVJ WKZU ASTR";
        private string decrypt = "STEUE REJTA NAFJO RDJAN STAND ORTQU AAACC CVIER NEUNN EUNZW OFAHR TZWON ULSMX XSCHA RNHOR STHCO";

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "N");
            plugBoard.Add("E", "Z");
            plugBoard.Add("H", "K");
            plugBoard.Add("I", "J");
            plugBoard.Add("L", "R");
            plugBoard.Add("M", "Q");
            plugBoard.Add("O", "T");
            plugBoard.Add("P", "V");
            plugBoard.Add("S", "W");
            plugBoard.Add("U", "X");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;
            settings.Reflector = Constants.Reflectors.B;
            settings.EntryWheel = Constants.Rotors.Etw;

            settings.Rotors.Add(Constants.Rotors.VIII);
            settings.Rotors.Add(Constants.Rotors.VI);
            settings.Rotors.Add(Constants.Rotors.III);

            settings.Rotors[0].Ringstellung = Constants.Alpha.M;
            settings.Rotors[1].Ringstellung = Constants.Alpha.H;
            settings.Rotors[2].Ringstellung = Constants.Alpha.A;

            settings.RotorPositions.Add(Constants.Alpha.V);
            settings.RotorPositions.Add(Constants.Alpha.Z);
            settings.RotorPositions.Add(Constants.Alpha.U);

            engimaMachine = new M3(settings);
        }

        [TestCleanup]
        public void Cleanup()
        {
            engimaMachine = null;
        }

        [TestMethod]
        public void EncodeMessageExpectCorrectOutput()
        {
            string encodedmessage = engimaMachine.EncryptDecrypt(decrypt);
            Assert.AreEqual(cypherText, encodedmessage.ToEnigmaMessageFormat(4));
        }

        [TestMethod]
        public void DecodeMessageExpectCorrectOutput()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt(cypherText);
            Assert.AreEqual(decrypt, decodedmessage.ToEnigmaMessageFormat(5));
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
