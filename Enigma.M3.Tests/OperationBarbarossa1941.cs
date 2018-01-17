namespace Enigma.M3.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Enigma.Machine.M3;
    using Exceptions;
    [TestClass]
    public class OperationBarbarossa1941
    {
        //Reflector: B
        //Wheel order: II IV V
        //Ring positions: 02 21 12 
        //Plug pairs: AV BS CG DL FU HZ IN KM OW RX

        //Message key: BLA
        //EDPUD NRGYS ZRCXN UYTPO MRMBO FKTBZ REZKM LXLVE FGUEY SIOZV EQMIK UBPMM YLKLT TDEIS MDICA GYKUA CTCDO MOHWX MUUIA UBSTS LRNBZ SZWNR FXWFY SSXJZ VIJHI DISHP RKLKA YUPAD TXQSP INQMA TLPIF SVKDA SCTAC DPBOP VHJK- 
        //Decrypt: AUFKL XABTE ILUNG XVONX KURTI NOWAX KURTI NOWAX NORDW ESTLX SEBEZ XSEBE ZXUAF FLIEG ERSTR ASZER IQTUN GXDUB ROWKI XDUBR OWKIX OPOTS CHKAX OPOTS CHKAX UMXEI NSAQT DREIN ULLXU HRANG ETRET ENXAN GRIFF XINFX RGTX- 

        //Message key: LSD
        //SFBWD NJUSE GQOBH KRTAR EEZMW KPPRB XOHDR OEQGB BGTQV PGVKB VVGBI MHUSZ YDAJQ IROAX SSSNR EHYGG RPISE ZBOVM QIEMM ZCYSG QDGRE RVBIL EKXYQ IRGIR QNRDN VRXCY YTNJR
        //Decrypt: DREIG EHTLA NGSAM ABERS IQERV ORWAE RTSXE INSSI EBENN ULLSE QSXUH RXROE MXEIN SXINF RGTXD REIXA UFFLI EGERS TRASZ EMITA NFANG XEINS SEQSX KMXKM XOSTW XKAME NECXK [truncated?] 

        //German: Aufklärung abteilung von Kurtinowa nordwestlich Sebez[auf] Fliegerstraße in Richtung Dubrowki, Opotschka. Um 18:30 Uhr angetreten angriff.Infanterie Regiment 3 geht langsam aber sicher vorwärts. 17:06 Uhr röm eins InfanterieRegiment 3 auf Fliegerstraße mit Anfang 16km ostwärts Kamenec.
        //English: Reconnaissance division from Kurtinowa north-west of Sebezh on the flight corridor towards Dubrowki, Opochka.Attack begun at 18:30 hours.Infantry Regiment 3 goes slowly but surely forwards. 17:06 hours[Roman numeral I ?] Infantry Regiment 3 on the flight corridor starting 16 km east of Kamenec.

        #region Full Encrypt Log
        #endregion

        #region Full Decrypt Log
        #endregion

        private IEnigmaMachine engimaMachine;
        private string messageKey1 = "BLA";
        private string cypherText1 = "EDPUD NRGYS ZRCXN UYTPO MRMBO FKTBZ REZKM LXLVE FGUEY SIOZV EQMIK UBPMM YLKLT TDEIS MDICA GYKUA CTCDO MOHWX MUUIA UBSTS LRNBZ SZWNR FXWFY SSXJZ VIJHI DISHP RKLKA YUPAD TXQSP INQMA TLPIF SVKDA SCTAC DPBOP VHJK-";
        private string decrypt1 = "AUFKL XABTE ILUNG XVONX KURTI NOWAX KURTI NOWAX NORDW ESTLX SEBEZ XSEBE ZXUAF FLIEG ERSTR ASZER IQTUN GXDUB ROWKI XDUBR OWKIX OPOTS CHKAX OPOTS CHKAX UMXEI NSAQT DREIN ULLXU HRANG ETRET ENXAN GRIFF XINFX RGTX-";

        private string messageKey2 = "LSD";
        private string cypherText2 = "SFBWD NJUSE GQOBH KRTAR EEZMW KPPRB XOHDR OEQGB BGTQV PGVKB VVGBI MHUSZ YDAJQ IROAX SSSNR EHYGG RPISE ZBOVM QIEMM ZCYSG QDGRE RVBIL EKXYQ IRGIR QNRDN VRXCY YTNJR";
        private string decrypt2 = "DREIG EHTLA NGSAM ABERS IQERV ORWAE RTSXE INSSI EBENN ULLSE QSXUH RXROE MXEIN SXINF RGTXD REIXA UFFLI EGERS TRASZ EMITA NFANG XEINS SEQSX KMXKM XOSTW XKAME NECXK";
        
        [TestInitialize]
        public void Initialize()
        {
            Dictionary<string, string> plugBoard = new Dictionary<string, string>();
            plugBoard.Add("A", "V");
            plugBoard.Add("B", "S");
            plugBoard.Add("C", "G");
            plugBoard.Add("D", "L");
            plugBoard.Add("F", "U");
            plugBoard.Add("H", "Z");
            plugBoard.Add("I", "N");
            plugBoard.Add("K", "M");
            plugBoard.Add("O", "W");
            plugBoard.Add("R", "X");

            EnigmaSettings settings = new EnigmaSettings();

            PlugboardBase pb = new PlugboardBase();
            pb.Layout = plugBoard;

            settings.PlugBoard = pb;
            settings.Reflector = Constants.Reflectors.B;
            
            settings.Rotors.Add(Constants.Rotors.V);
            settings.Rotors.Add(Constants.Rotors.IV);
            settings.Rotors.Add(Constants.Rotors.II);

            settings.RotorPositions.Add(Constants.Alpha.A);
            settings.RotorPositions.Add(Constants.Alpha.L);
            settings.RotorPositions.Add(Constants.Alpha.B);

            settings.Rotors[0].Ringstellung = Constants.Alpha.L;
            settings.Rotors[1].Ringstellung = Constants.Alpha.U;
            settings.Rotors[2].Ringstellung = Constants.Alpha.B;

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
            string encodedmessage = engimaMachine.EncryptDecrypt(decrypt1);
            Assert.AreEqual(cypherText1, encodedmessage.ToEnigmaMessageFormat(5));
        }

        [TestMethod]
        public void DecodeMessageExpectCorrectOutput()
        {
            string decodedmessage = engimaMachine.EncryptDecrypt(cypherText1);
            Assert.AreEqual(decrypt1, decodedmessage.ToEnigmaMessageFormat(5));
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
