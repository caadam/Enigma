namespace Enigma.M4.Tests
{
    using Exceptions;
    using Enigma.Machine.M4;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class U2641942
    {
        //Reflector: Thin B
        //Wheel order: β II IV I
        //Ringstellung: VJNA 
        //Ring positions: 01 01 01 22 
        //Plug pairs: AT BL DF GJ HM NW OP QY RZ VX

        //U-264 (Kapitänleutnant Hartwig Looks), 1942
        //Message key: VJNA
        //NCZW VUSX PNYM INHZ XMQX SFWX WLKJ AHSH NMCO CCAK UQPM KCSM HKSE INJU SBLK IOSX CKUB HMLL XCSJ USRR DVKO HULX WCCB GVLI YXEO AHXR HKKF VDRE WEZL XOBA FGYU JQUK GRTV UKAM EURB VEKS UHHV OYHA BCJW MAKL FKLM YFVN RIZR VVRT KOFD ANJM OLBG FFLE OPRG TFLV RHOW OPBE KVWM UQFM PWPA RMFH AGKX IIBG
        //Decrypt: VONV ONJL OOKS JHFF TTTE INSE INSD REIZ WOYY QNNS NEUN INHA LTXX BEIA NGRI FFUN TERW ASSE RGED RUEC KTYW ABOS XLET ZTER GEGN ERST ANDN ULAC HTDR EINU LUHR MARQ UANT ONJO TANE UNAC HTSE YHSD REIY ZWOZ WONU LGRA DYAC HTSM YSTO SSEN ACHX EKNS VIER MBFA ELLT YNNN NNNO OOVI ERYS ICHT EINS NULL
        //German: Von Von 'Looks' F T 1132/19 Inhalt: Bei Angriff unter Wasser gedrückt, Wasserbomben.Letzter Gegnerstandort 08:30 Uhr Marine Quadrat AJ9863, 220 Grad, 8sm, stosse nach. 14mb fällt, NNO 4, Sicht 10. 
        //English: From Looks, radio-telegram 1132/19 contents: Forced to submerge under attack, depth charges. Last enemy location 08:30 hours, sea square AJ9863, following 220 degrees, 8 knots. [Pressure] 14 millibars falling, [wind] north-north-east 4, visibility 10. 

        private IEnigmaMachine engimaMachine;

        private string cypherText = "NCZW VUSX PNYM INHZ XMQX SFWX WLKJ AHSH NMCO CCAK UQPM KCSM HKSE INJU SBLK IOSX CKUB HMLL XCSJ USRR DVKO HULX WCCB GVLI YXEO AHXR HKKF VDRE WEZL XOBA FGYU JQUK GRTV UKAM EURB VEKS UHHV OYHA BCJW MAKL FKLM YFVN RIZR VVRT KOFD ANJM OLBG FFLE OPRG TFLV RHOW OPBE KVWM UQFM PWPA RMFH AGKX IIBG";
        private string decrypt = "VONV ONJL OOKS JHFF TTTE INSE INSD REIZ WOYY QNNS NEUN INHA LTXX BEIA NGRI FFUN TERW ASSE RGED RUEC KTYW ABOS XLET ZTER GEGN ERST ANDN ULAC HTDR EINU LUHR MARQ UANT ONJO TANE UNAC HTSE YHSD REIY ZWOZ WONU LGRA DYAC HTSM YSTO SSEN ACHX EKNS VIER MBFA ELLT YNNN NNNO OOVI ERYS ICHT EINS NULL";

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "T");
            plugBoard.Add("B", "L");
            plugBoard.Add("D", "F");
            plugBoard.Add("G", "J");
            plugBoard.Add("H", "M");
            plugBoard.Add("N", "W");
            plugBoard.Add("O", "P");
            plugBoard.Add("Q", "Y");
            plugBoard.Add("R", "Z");
            plugBoard.Add("V", "X");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;

            //settings.Rotors.Add(new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "I", new List<string>() { "Y" }, new List<string>() { "Q" }, new List<string>() { "R" }));
            //settings.Rotors.Add(new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "IV", new List<string>() { "R" }, new List<string>() { "J" }, new List<string>() { "K" }));
            //settings.Rotors.Add(new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "II", new List<string>() { "M" }, new List<string>() { "E" }, new List<string>() { "F" }));
            //settings.Rotors.Add(new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "Beta", null, null, null));

            settings.Rotors.Add(Constants.Rotors.I);
            settings.Rotors.Add(Constants.Rotors.IV);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.Beta);

            settings.RotorPositions.Add(Constants.Alpha.A);
            settings.RotorPositions.Add(Constants.Alpha.N);
            settings.RotorPositions.Add(Constants.Alpha.J);
            settings.RotorPositions.Add(Constants.Alpha.V);

            settings.Rotors[0].Ringstellung = Constants.Alpha.V;
            settings.Rotors[1].Ringstellung = Constants.Alpha.A;
            settings.Rotors[2].Ringstellung = Constants.Alpha.A;
            settings.Rotors[3].Ringstellung = Constants.Alpha.A;

            settings.Reflector = Constants.Reflectors.BThin;

            engimaMachine = new M4(settings);
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
            Assert.AreEqual<string>(cypherText, encodedmessage.ToEnigmaMessageFormat(4));
        }

        [TestMethod]
        public void DecodeMessageExpectCorrectOutput()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt(cypherText);
            Assert.AreEqual<string>(decrypt, decodedmessage.ToEnigmaMessageFormat(4));
        }

        [TestMethod]
        public void Shirleen_Quick_question_20160226_1342()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt("N");
            Assert.AreEqual<string>("V", decodedmessage);
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
