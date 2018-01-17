namespace Enigma.M4.Tests
{
    using Exceptions;
    using Enigma.Machine.M4;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class GrandAdmiralDonitz1May1945
    {
        //Enigma: M4 
        //Umkehrwalze(reflector): C 
        //Wheel order: β V VI VIII
        //Ringstellung(ring setting): EPEL 
        //Grundstellung(start position): NAEM 
        //Ring positions: CDSZ
        //Steckern(plugs): AE BF CM DQ HU JN LX PR SZ VW

        //Grand Admiral Dönitz on 1 May 1945 at 06:55, announcing his appointment as Hitler's successor
        //LANO TCTO UARB BFPM HPHG CZXT DYGA HGUF XGEW KBLK GJWL QXXT GPJJ AVTO CKZF SLPP QIHZ FXOE BWII EKFZ LCLO AQJU LJOY HSSM BBGW HZAN VOII PYRB RTDJ QDJJ OQKC XWDN BBTY VXLY TAPG VEAT XSON PNYN QFUD BBHH VWEP YEYD OHNL XKZD NWRH DUWU JUMW WVII WZXI VIUQ DRHY MNCY EFUA PNHO TKHK GDNP SAKN UAGH JZSM JBMH VTRE QEDG XHLZ WIFU SKDQ VELN MIMI THBH DBWV HDFY HJOQ IHOR TDJD BWXE MEAY XGYQ XOHF DMYU XXNO JAZR SGHP LWML RECW WUTL RTTV LBHY OORG LGOW UXNX HMHY FAAC QEKT HSJW
        //Decrypt: 
        //German: KRIEGSNOTMELDUNG[An] Alle: Folgendes ist sofort bekanntzugeben: Ich habe folgende Befehl erhalten: 'Anstelle des bisherigen Reichsmarschalls 'Göring' setzt der Führer Sie, Herr Großadmiral, als seinen Nachfolger ein. Schriftlische Vollmacht unterwegs. Ab sofort sollen Sie sämtliche Maßnahmen verfügen, die sich aus die gegenwärtigen Lage ergeben. Gez.Reichsleiter (Tulpe) 'Bormann' [Von] Oberbefehlshaber der Marine, durch Funkstelle der Kommandierender Admiral der Unterseeboote.
        //English: WAR EMERGENCY MESSAGE[To] All: The following is to be announced immediately: I have received the following order: 'In place of former Reichsmarschall 'Göring', the Führer has appointed you, Herr Grossadmiral, as his successor. Written authorization[is] on the way.Effective immediately, you are to order all measures that are required by the present situation. Signed, Reichsleiter (Tulpe) 'Bormann': [From] Commander-in-Chief of the Navy, [sent] by way of the Radio Station of the Commanding Admiral of Submarines

        private IEnigmaMachine engimaMachine;
        private string cypherText = "LANO TCTO UARB BFPM HPHG CZXT DYGA HGUF XGEW KBLK GJWL QXXT GPJJ AVTO CKZF SLPP QIHZ FXOE BWII EKFZ LCLO AQJU LJOY HSSM BBGW HZAN VOII PYRB RTDJ QDJJ OQKC XWDN BBTY VXLY TAPG VEAT XSON PNYN QFUD BBHH VWEP YEYD OHNL XKZD NWRH DUWU JUMW WVII WZXI VIUQ DRHY MNCY EFUA PNHO TKHK GDNP SAKN UAGH JZSM JBMH VTRE QEDG XHLZ WIFU SKDQ VELN MIMI THBH DBWV HDFY HJOQ IHOR TDJD BWXE MEAY XGYQ XOHF DMYU XXNO JAZR SGHP LWML RECW WUTL RTTV LBHY OORG LGOW UXNX HMHY FAAC QEKT HSJW";
        private string decrypt = "KRKR ALLE XXFO LGEN DESI STSO FORT BEKA NNTZ UGEB ENXX ICHH ABEF OLGE LNBE BEFE HLER HALT ENXX JANS TERL EDES BISH ERIG XNRE ICHS MARS CHAL LSJG OERI NGJS ETZT DERF UEHR ERSI EYHV RRGR ZSSA DMIR ALYA LSSE INEN NACH FOLG EREI NXSC HRIF TLSC HEVO LLMA CHTU NTER WEGS XABS OFOR TSOL LENS IESA EMTL ICHE MASS NAHM ENVE RFUE GENY DIES ICHA USDE RGEG ENWA ERTI GENL AGEE RGEB ENXG EZXR EICH SLEI TEIK KTUL PEKK JBOR MANN JXXO BXDX MMMD URNH FKST XKOM XADM XUUU BOOI EXKP";

        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "E");
            plugBoard.Add("B", "F");
            plugBoard.Add("C", "M");
            plugBoard.Add("D", "Q");
            plugBoard.Add("H", "U");
            plugBoard.Add("J", "N");
            plugBoard.Add("L", "X");
            plugBoard.Add("P", "R");
            plugBoard.Add("S", "Z");
            plugBoard.Add("V", "W");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;

            settings.Rotors.Add(Constants.Rotors.VIII);
            settings.Rotors.Add(Constants.Rotors.VI);
            settings.Rotors.Add(Constants.Rotors.V);
            settings.Rotors.Add(Constants.Rotors.Beta);

            settings.RotorPositions.Add(Constants.Alpha.Z);
            settings.RotorPositions.Add(Constants.Alpha.S);
            settings.RotorPositions.Add(Constants.Alpha.D);
            settings.RotorPositions.Add(Constants.Alpha.C);

            settings.Rotors[0].Ringstellung = Constants.Alpha.L;
            settings.Rotors[1].Ringstellung = Constants.Alpha.E;
            settings.Rotors[2].Ringstellung = Constants.Alpha.P;
            settings.Rotors[3].Ringstellung = Constants.Alpha.E;

            settings.Reflector = Constants.Reflectors.CThin;

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
    }
}
