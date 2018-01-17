namespace Enigma.M3.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Enigma.Machine.M3;
    using Exceptions;

    [TestClass]
    public class EnigmaInstructionManual1930
    {
        //Reflector: A
        //Wheel order: II I III
        //Position:ABL
        //Ring positions: X(24) M(13) V(22) 
        //Plug pairs: AM FI NV PS TU WZ

        //GCDSE AHUGW TQGRK VLFGX UCALX VYMIG MMNMF DXTGN VHVRM MEVOU YFZSL RHDRR XFJWC FHUHM UNZEF RDISI KBGPM YVXUZ
        //Decrypt: FEIND LIQEI NFANT ERIEK OLONN EBEOB AQTET XANFA NGSUE DAUSG ANGBA ERWAL DEXEN DEDRE IKMOS TWAER TSNEU STADT
        //German: Feindliche Infanterie Kolonne beobachtet.Anfang Südausgang Bärwalde. Ende 3km ostwärts Neustadt.
        //English: Enemy infantry column was observed.Beginning[at] southern exit[of] Baerwalde. Ending 3km east of Neustadt. 

        #region Full Encrypt Log
        #endregion

        #region Full Decrypt Log
        #endregion

        private IEnigmaMachine engimaMachine;
        private string messageKey = "ABL";
        private string cypherText = "GCDSE AHUGW TQGRK VLFGX UCALX VYMIG MMNMF DXTGN VHVRM MEVOU YFZSL RHDRR XFJWC FHUHM UNZEF RDISI KBGPM YVXUZ";
        private string decrypt = "FEIND LIQEI NFANT ERIEK OLONN EBEOB AQTET XANFA NGSUE DAUSG ANGBA ERWAL DEXEN DEDRE IKMOS TWAER TSNEU STADT";

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A","M"); 
            plugBoard.Add("F","I"); 
            plugBoard.Add("N","V"); 
            plugBoard.Add("P","S"); 
            plugBoard.Add("T","U");
            plugBoard.Add("W","Z");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;
            settings.Reflector = Constants.Reflectors.A;

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.I);
            settings.Rotors.Add(Constants.Rotors.II);

            settings.RotorPositions.Add(Constants.Alpha.L);
            settings.RotorPositions.Add(Constants.Alpha.B);
            settings.RotorPositions.Add(Constants.Alpha.A);

            settings.Rotors[0].Ringstellung = Constants.Alpha.V;
            settings.Rotors[1].Ringstellung = Constants.Alpha.M;
            settings.Rotors[2].Ringstellung = Constants.Alpha.X;

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
            string encodedmessage = engimaMachine.EncryptDecrypt(decrypt.ToEnigmaMessageFormat(5));
            Assert.AreEqual(cypherText, encodedmessage.ToEnigmaMessageFormat(5));
        }

        [TestMethod]
        public void DecodeMessageExpectCorrectOutput()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt(cypherText);
            Assert.AreEqual(decrypt, decodedmessage.ToEnigmaMessageFormat(5));
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
