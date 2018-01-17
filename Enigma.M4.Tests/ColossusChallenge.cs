namespace Enigma.M4.Tests
{
    using Exceptions;
    using Enigma.Machine.M4;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class ColossusChallenge
    {
        //Reflector: Thin C
        //Wheel order: β III IV II
        //Ringstellung: BOSS 
        //Ring positions: 01 03 03 07 
        //Plug pairs: AX BK DE GJ HM NW OP QY RZ VT

        private IEnigmaMachine engimaMachine;

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "X");
            plugBoard.Add("B", "K");
            plugBoard.Add("D", "E");
            plugBoard.Add("G", "J");
            plugBoard.Add("H", "M");
            plugBoard.Add("N", "W");
            plugBoard.Add("O", "P");
            plugBoard.Add("Q", "Y");
            plugBoard.Add("R", "Z");
            plugBoard.Add("V", "T");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;

            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.IV);
            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.Beta);

            settings.RotorPositions.Add(Constants.Alpha.S);
            settings.RotorPositions.Add(Constants.Alpha.S);
            settings.RotorPositions.Add(Constants.Alpha.O);
            settings.RotorPositions.Add(Constants.Alpha.B);

            settings.Rotors[0].Ringstellung = Constants.Alpha.G;
            settings.Rotors[1].Ringstellung = Constants.Alpha.C;
            settings.Rotors[2].Ringstellung = Constants.Alpha.C;
            settings.Rotors[3].Ringstellung = Constants.Alpha.A;

            settings.Reflector = Constants.Reflectors.CThin;

            engimaMachine = new M4(settings);
        }

        [TestCleanup]
        public void Cleanup()
        {
            engimaMachine = null;
        }

        [TestMethod]
        public void ColossusChallengeTest()
        {
            // initialize setup
            string message = "You cracked this code like a boss";
            string expectedMessage = message.ToEnigmaMessageFormat(4);

            // encode random message
            string encodedMessage = engimaMachine.EncryptDecrypt(message.ToUpper());
            
            // reset machine to starting values to decode
            Initialize();

            // decode message 
            string decodedMessage = engimaMachine.EncryptDecrypt(encodedMessage).ToEnigmaMessageFormat(4);

            Assert.AreEqual<string>(expectedMessage, decodedMessage);
        }
    }
}
