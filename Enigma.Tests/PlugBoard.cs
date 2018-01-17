namespace Enigma.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PlugBoard
    {
        private IPlugboard plugBoard;

        [TestInitialize]
        public void Initialize()
        {
            // Mock plugboard mapping
            Dictionary<string, string> pb = new Dictionary<string, string>();
            pb.Add("A", "E");
            pb.Add("F", "T");
            pb.Add("R", "Q");
            pb.Add("L", "B");
            pb.Add("X", "Z");
            pb.Add("Y", "O");
            pb.Add("H", "I");

            plugBoard = new PlugboardBase(pb);
        }

        [TestCleanup]
        public void Cleanup()
        {
            plugBoard = null;
        }

        [TestMethod]
        public void TestPlugboardInboundForMappedCharacters()
        {
            Assert.AreEqual<string>("A", plugBoard.MapCharacter("E"));
            Assert.AreEqual<string>("F", plugBoard.MapCharacter("T"));
            Assert.AreEqual<string>("R", plugBoard.MapCharacter("Q"));
            Assert.AreEqual<string>("L", plugBoard.MapCharacter("B"));
            Assert.AreEqual<string>("X", plugBoard.MapCharacter("Z"));
            Assert.AreEqual<string>("Y", plugBoard.MapCharacter("O"));
            Assert.AreEqual<string>("H", plugBoard.MapCharacter("I"));
        }

        [TestMethod]
        public void TestPlugboardOutboundForMappedCharacters()
        {
            Assert.AreEqual<string>("E", plugBoard.MapCharacter("A"));
            Assert.AreEqual<string>("T", plugBoard.MapCharacter("F"));
            Assert.AreEqual<string>("Q", plugBoard.MapCharacter("R"));
            Assert.AreEqual<string>("B", plugBoard.MapCharacter("L"));
            Assert.AreEqual<string>("Z", plugBoard.MapCharacter("X"));
            Assert.AreEqual<string>("O", plugBoard.MapCharacter("Y"));
            Assert.AreEqual<string>("I", plugBoard.MapCharacter("H"));
        }

        [TestMethod]
        public void TestPlugboardInboundForUnmappedCharacters()
        {
            Assert.AreEqual<string>("C", plugBoard.MapCharacter("C"));
            Assert.AreEqual<string>("D", plugBoard.MapCharacter("D"));
            Assert.AreEqual<string>("G", plugBoard.MapCharacter("G"));
            Assert.AreEqual<string>("J", plugBoard.MapCharacter("J"));
            Assert.AreEqual<string>("K", plugBoard.MapCharacter("K"));
            Assert.AreEqual<string>("M", plugBoard.MapCharacter("M"));
            Assert.AreEqual<string>("N", plugBoard.MapCharacter("N"));
            Assert.AreEqual<string>("P", plugBoard.MapCharacter("P"));
            Assert.AreEqual<string>("S", plugBoard.MapCharacter("S"));
            Assert.AreEqual<string>("U", plugBoard.MapCharacter("U"));
            Assert.AreEqual<string>("V", plugBoard.MapCharacter("V"));
            Assert.AreEqual<string>("W", plugBoard.MapCharacter("W"));
        }

        [TestMethod]
        public void TestPlugboardOutoundForUnmappedCharacters()
        {
            Assert.AreEqual<string>("D", plugBoard.MapCharacter("D"));
            Assert.AreEqual<string>("G", plugBoard.MapCharacter("G"));
            Assert.AreEqual<string>("J", plugBoard.MapCharacter("J"));
            Assert.AreEqual<string>("K", plugBoard.MapCharacter("K"));
            Assert.AreEqual<string>("M", plugBoard.MapCharacter("M"));
            Assert.AreEqual<string>("N", plugBoard.MapCharacter("N"));
            Assert.AreEqual<string>("P", plugBoard.MapCharacter("P"));
            Assert.AreEqual<string>("S", plugBoard.MapCharacter("S"));
            Assert.AreEqual<string>("U", plugBoard.MapCharacter("U"));
            Assert.AreEqual<string>("V", plugBoard.MapCharacter("V"));
            Assert.AreEqual<string>("W", plugBoard.MapCharacter("W"));
        }

        [TestMethod]
        public void TestScharnhorstPlugboardSettings()
        {
            Dictionary<string, string> pb = new Dictionary<string, string>();
            pb.Add("A", "N");
            pb.Add("E", "Z");
            pb.Add("H", "K");
            pb.Add("I", "J");
            pb.Add("L", "R");
            pb.Add("M", "Q");
            pb.Add("O", "T");
            pb.Add("P", "V");
            pb.Add("S", "W");
            pb.Add("U", "X");

            plugBoard = new PlugboardBase();
            plugBoard.Layout = pb;

            Assert.AreEqual<string>("W", plugBoard.MapCharacter("S"));
            Assert.AreEqual<string>("O", plugBoard.MapCharacter("T"));
            Assert.AreEqual<string>("Z", plugBoard.MapCharacter("E"));
            Assert.AreEqual<string>("X", plugBoard.MapCharacter("U"));

            Assert.AreEqual<string>("Z", plugBoard.MapCharacter("E"));
            Assert.AreEqual<string>("L", plugBoard.MapCharacter("R"));
            Assert.AreEqual<string>("Z", plugBoard.MapCharacter("E"));
            Assert.AreEqual<string>("I", plugBoard.MapCharacter("J"));

            Assert.AreEqual<string>("O", plugBoard.MapCharacter("T"));
            Assert.AreEqual<string>("N", plugBoard.MapCharacter("A"));
            Assert.AreEqual<string>("A", plugBoard.MapCharacter("N"));
        }
    }
}
