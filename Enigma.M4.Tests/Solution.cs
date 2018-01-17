namespace Enigma.M4.Tests
{
    using Exceptions;
    using Enigma.Machine.M4;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class Solution
    {
        //Reflector: Thin C
        //Wheel order: γ (Gamma) V I III
        //Ringstellung: CODE 
        //Ring positions: 16 09 13 16 
        //Plug pairs: AY BF DL GX HZ NS OC QT RJ VP

        private IEnigmaMachine engimaMachine;

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "Y");
            plugBoard.Add("B", "F");
            plugBoard.Add("D", "L");
            plugBoard.Add("G", "X");
            plugBoard.Add("H", "Z");
            plugBoard.Add("N", "S");
            plugBoard.Add("O", "C");
            plugBoard.Add("Q", "T");
            plugBoard.Add("R", "J");
            plugBoard.Add("V", "P");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.I);
            settings.Rotors.Add(Constants.Rotors.V);
            settings.Rotors.Add(Constants.Rotors.Gamma);

            settings.RotorPositions.Add(Constants.Alpha.E);
            settings.RotorPositions.Add(Constants.Alpha.D);
            settings.RotorPositions.Add(Constants.Alpha.O);
            settings.RotorPositions.Add(Constants.Alpha.C);

            settings.Rotors[0].Ringstellung = Constants.Alpha.P;
            settings.Rotors[1].Ringstellung = Constants.Alpha.M;
            settings.Rotors[2].Ringstellung = Constants.Alpha.I;
            settings.Rotors[3].Ringstellung = Constants.Alpha.P;

            settings.Reflector = Constants.Reflectors.CThin;

            engimaMachine = new M4(settings);
        }

        [TestCleanup]
        public void Cleanup()
        {
            engimaMachine = null;
        }

        [TestMethod]
        public void SolutionTest()
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
