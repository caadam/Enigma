namespace Enigma.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class Rotors
    {
        [TestMethod]
        public void TestRotorIMapping()
        {
            IRotor reflector = Constants.Rotors.I;

            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorIIMapping()
        {
            IRotor reflector = Constants.Rotors.II;

            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorIIIMapping()
        {
            IRotor reflector = Constants.Rotors.III;

            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorIVMapping()
        {
            IRotor reflector = Constants.Rotors.IV;

            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorVMapping()
        {
            IRotor reflector = Constants.Rotors.V;

            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorVIMapping()
        {
            IRotor reflector = Constants.Rotors.VI;

            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorVIIMapping()
        {
            IRotor reflector = Constants.Rotors.VII;

            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorVIIIMapping()
        {
            IRotor reflector = Constants.Rotors.VIII;

            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorBetaMapping()
        {
            IRotor reflector = Constants.Rotors.Beta;

            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorGammaMapping()
        {
            IRotor reflector = Constants.Rotors.Gamma;

            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }

        [TestMethod]
        public void TestRotorEtwMapping()
        {
            IRotor reflector = Constants.Rotors.Etw;

            Assert.AreEqual<string>("A", reflector.Mapping.Single(r => r.InputCharacter == "A").OutputCharacter);
            Assert.AreEqual<string>("B", reflector.Mapping.Single(r => r.InputCharacter == "B").OutputCharacter);
            Assert.AreEqual<string>("C", reflector.Mapping.Single(r => r.InputCharacter == "C").OutputCharacter);
            Assert.AreEqual<string>("D", reflector.Mapping.Single(r => r.InputCharacter == "D").OutputCharacter);
            Assert.AreEqual<string>("E", reflector.Mapping.Single(r => r.InputCharacter == "E").OutputCharacter);
            Assert.AreEqual<string>("F", reflector.Mapping.Single(r => r.InputCharacter == "F").OutputCharacter);
            Assert.AreEqual<string>("G", reflector.Mapping.Single(r => r.InputCharacter == "G").OutputCharacter);
            Assert.AreEqual<string>("H", reflector.Mapping.Single(r => r.InputCharacter == "H").OutputCharacter);
            Assert.AreEqual<string>("I", reflector.Mapping.Single(r => r.InputCharacter == "I").OutputCharacter);
            Assert.AreEqual<string>("J", reflector.Mapping.Single(r => r.InputCharacter == "J").OutputCharacter);
            Assert.AreEqual<string>("K", reflector.Mapping.Single(r => r.InputCharacter == "K").OutputCharacter);
            Assert.AreEqual<string>("L", reflector.Mapping.Single(r => r.InputCharacter == "L").OutputCharacter);
            Assert.AreEqual<string>("M", reflector.Mapping.Single(r => r.InputCharacter == "M").OutputCharacter);
            Assert.AreEqual<string>("N", reflector.Mapping.Single(r => r.InputCharacter == "N").OutputCharacter);
            Assert.AreEqual<string>("O", reflector.Mapping.Single(r => r.InputCharacter == "O").OutputCharacter);
            Assert.AreEqual<string>("P", reflector.Mapping.Single(r => r.InputCharacter == "P").OutputCharacter);
            Assert.AreEqual<string>("Q", reflector.Mapping.Single(r => r.InputCharacter == "Q").OutputCharacter);
            Assert.AreEqual<string>("R", reflector.Mapping.Single(r => r.InputCharacter == "R").OutputCharacter);
            Assert.AreEqual<string>("S", reflector.Mapping.Single(r => r.InputCharacter == "S").OutputCharacter);
            Assert.AreEqual<string>("T", reflector.Mapping.Single(r => r.InputCharacter == "T").OutputCharacter);
            Assert.AreEqual<string>("U", reflector.Mapping.Single(r => r.InputCharacter == "U").OutputCharacter);
            Assert.AreEqual<string>("V", reflector.Mapping.Single(r => r.InputCharacter == "V").OutputCharacter);
            Assert.AreEqual<string>("W", reflector.Mapping.Single(r => r.InputCharacter == "W").OutputCharacter);
            Assert.AreEqual<string>("X", reflector.Mapping.Single(r => r.InputCharacter == "X").OutputCharacter);
            Assert.AreEqual<string>("Y", reflector.Mapping.Single(r => r.InputCharacter == "Y").OutputCharacter);
            Assert.AreEqual<string>("Z", reflector.Mapping.Single(r => r.InputCharacter == "Z").OutputCharacter);
        }
    }
}