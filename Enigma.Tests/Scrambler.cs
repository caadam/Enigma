namespace Enigma.Tests
{
    using Exceptions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class Scrambler
    {
        private IScramblerUnit scramblerUnit;

        [TestInitialize]
        public void Initialize()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(21);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);
        }

        [TestCleanup]
        public void Cleanup()
        {
            scramblerUnit = null;
        }

        /// <summary>
        /// AAU — normal step of right rotor
        /// AAV — right rotor(III)goes in V—notch position
        /// ABW — right rotor takes middle rotor one step further
        /// ABX — normal step of right rotor
        /// </summary>
        [TestMethod]
        public void SingleRotorStepTest()
        {
            // Check initial wheel positions
            // AAU — normal step of right rotor

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);

            // AAV — right rotor(III)goes in V—notch position
            scramblerUnit.Scramble("T");

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(22, scramblerUnit.RotorPositions[0]);

            // ABW — right rotor takes middle rotor one step further
            scramblerUnit.Scramble("T");

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(2, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(23, scramblerUnit.RotorPositions[0]);

            // ABX — normal step of right rotor
            scramblerUnit.Scramble("T");

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(2, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(24, scramblerUnit.RotorPositions[0]);
        }

        /// <summary>
        /// ADU — normal step of right rotor
        /// ADV — right rotor(III)goes in V—notch position
        /// AEW — right rotor steps, takes middle rotor(II) one step further, which is now in its own E—notch position
        /// BFX — normal step of right rotor, double step of middle rotor, normal step of left rotor
        /// BFY — normal step of right rotor
        /// </summary>
        [TestMethod]
        public void DoubleRotorStepTest()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(21);
            settings.RotorPositions.Add(4);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.A;

            scramblerUnit = new ScramblerUnitBase(settings);

            // Check initial wheel positions
            // ADU — normal step of right rotor

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(4, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);

            // ADV — right rotor(III)goes in V—notch position
            scramblerUnit.Scramble("T");

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(4, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(22, scramblerUnit.RotorPositions[0]);

            // AEW — right rotor steps, takes middle rotor(II) one step further, which is now in its own E—notch position
            scramblerUnit.Scramble("T");

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(5, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(23, scramblerUnit.RotorPositions[0]);

            // BFX — normal step of right rotor, double step of middle rotor, normal step of left rotor
            scramblerUnit.Scramble("T");

            Assert.AreEqual(2, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(6, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(24, scramblerUnit.RotorPositions[0]);

            // BFY — normal step of right rotor
            scramblerUnit.Scramble("T");

            Assert.AreEqual(2, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(6, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(25, scramblerUnit.RotorPositions[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestEncodingSingleStep()
        {
            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("U", scramblerUnit.Scramble("T"));

            Assert.AreEqual(22, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("P", scramblerUnit.Scramble("E"));

            Assert.AreEqual(23, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(2, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("L", scramblerUnit.Scramble("S"));
            Assert.AreEqual<string>("W", scramblerUnit.Scramble("T"));
            Assert.AreEqual<string>("X", scramblerUnit.Scramble("I"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("N"));
            Assert.AreEqual<string>("T", scramblerUnit.Scramble("G"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestEncodingNoStep()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(1, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("O", scramblerUnit.Scramble("T"));
            Assert.AreEqual<string>("L", scramblerUnit.Scramble("E"));
            Assert.AreEqual<string>("P", scramblerUnit.Scramble("S"));
            Assert.AreEqual<string>("F", scramblerUnit.Scramble("T"));
            Assert.AreEqual<string>("D", scramblerUnit.Scramble("I"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("N"));
            Assert.AreEqual<string>("Z", scramblerUnit.Scramble("G"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestEncodingSingleStepKnownWorkingExample()
        {
            // Reflector B I II III 
            // 1 1 26
            // Knowing working traversal (input) rotors | rotors (output)
            // (A) B J Z | T L K (U)
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(26);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            // (A) B J Z | T L K (U)
            // (1) 2 10 26 | 20 12 11 (21)
            Assert.AreEqual<string>("U", scramblerUnit.Scramble("A"));

            // (A) B E S | F D D (B)
            // (1) 2 5 19 | 6 4 4 (2)
            Assert.AreEqual<string>("B", scramblerUnit.Scramble("A"));

            Assert.AreEqual<string>("D", scramblerUnit.Scramble("A"));
            Assert.AreEqual<string>("Z", scramblerUnit.Scramble("A"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("A"));
        }


        [TestMethod]
        public void TestEncodingAlphabet()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[0]);

            Assert.AreEqual<string>("B", scramblerUnit.Scramble("A"));
            Assert.AreEqual<string>("J", scramblerUnit.Scramble("B"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("C"));
            Assert.AreEqual<string>("L", scramblerUnit.Scramble("D"));
            Assert.AreEqual<string>("R", scramblerUnit.Scramble("E"));

            Assert.AreEqual<string>("Q", scramblerUnit.Scramble("F"));
            Assert.AreEqual<string>("Z", scramblerUnit.Scramble("G"));
            Assert.AreEqual<string>("V", scramblerUnit.Scramble("H"));
            Assert.AreEqual<string>("J", scramblerUnit.Scramble("I"));
            Assert.AreEqual<string>("W", scramblerUnit.Scramble("J"));

            Assert.AreEqual<string>("A", scramblerUnit.Scramble("K"));
            Assert.AreEqual<string>("R", scramblerUnit.Scramble("L"));
            Assert.AreEqual<string>("X", scramblerUnit.Scramble("M"));
            Assert.AreEqual<string>("S", scramblerUnit.Scramble("N"));
            Assert.AreEqual<string>("N", scramblerUnit.Scramble("O"));

            Assert.AreEqual<string>("B", scramblerUnit.Scramble("P"));
            Assert.AreEqual<string>("X", scramblerUnit.Scramble("Q"));
            Assert.AreEqual<string>("O", scramblerUnit.Scramble("R"));
            Assert.AreEqual<string>("R", scramblerUnit.Scramble("S"));
            Assert.AreEqual<string>("S", scramblerUnit.Scramble("T"));

            Assert.AreEqual<string>("T", scramblerUnit.Scramble("U"));
            Assert.AreEqual<string>("N", scramblerUnit.Scramble("V"));
            Assert.AreEqual<string>("C", scramblerUnit.Scramble("W"));
            Assert.AreEqual<string>("F", scramblerUnit.Scramble("X"));
            Assert.AreEqual<string>("M", scramblerUnit.Scramble("Y"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("Z"));

            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);
            Assert.AreEqual(2, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[0]);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestDecodingNoStep()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(1, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("T", scramblerUnit.Scramble("O"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("L"));
            Assert.AreEqual<string>("S", scramblerUnit.Scramble("P"));
            Assert.AreEqual<string>("T", scramblerUnit.Scramble("F"));
            Assert.AreEqual<string>("I", scramblerUnit.Scramble("D"));
            Assert.AreEqual<string>("N", scramblerUnit.Scramble("E"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("Z"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestDecodingSingleStep()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(21);
            settings.RotorPositions.Add(1);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("T", scramblerUnit.Scramble("U"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("P"));
            Assert.AreEqual<string>("S", scramblerUnit.Scramble("L"));
            Assert.AreEqual<string>("T", scramblerUnit.Scramble("W"));
            Assert.AreEqual<string>("I", scramblerUnit.Scramble("X"));
            Assert.AreEqual<string>("N", scramblerUnit.Scramble("G"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("T"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestEncodingDoubleStep()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(21);
            settings.RotorPositions.Add(4);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(4, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("Y", scramblerUnit.Scramble("T"));
            Assert.AreEqual<string>("B", scramblerUnit.Scramble("E"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("S"));
            Assert.AreEqual<string>("F", scramblerUnit.Scramble("T"));
            Assert.AreEqual<string>("J", scramblerUnit.Scramble("I"));
            Assert.AreEqual<string>("W", scramblerUnit.Scramble("N"));
            Assert.AreEqual<string>("Q", scramblerUnit.Scramble("G"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestDecodingDoubleStep()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.III);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.I);

            settings.RotorPositions.Add(21);
            settings.RotorPositions.Add(4);
            settings.RotorPositions.Add(1);

            settings.Reflector = Constants.Reflectors.B;

            scramblerUnit = new ScramblerUnitBase(settings);

            Assert.AreEqual(21, scramblerUnit.RotorPositions[0]);
            Assert.AreEqual(4, scramblerUnit.RotorPositions[1]);
            Assert.AreEqual(1, scramblerUnit.RotorPositions[2]);

            Assert.AreEqual<string>("T", scramblerUnit.Scramble("Y"));
            Assert.AreEqual<string>("E", scramblerUnit.Scramble("B"));
            Assert.AreEqual<string>("S", scramblerUnit.Scramble("G"));
            Assert.AreEqual<string>("T", scramblerUnit.Scramble("F"));
            Assert.AreEqual<string>("I", scramblerUnit.Scramble("J"));
            Assert.AreEqual<string>("N", scramblerUnit.Scramble("W"));
            Assert.AreEqual<string>("G", scramblerUnit.Scramble("Q"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestRingstellung()
        {
            EnigmaSettings settings = new EnigmaSettings();

            settings.Rotors.Add(Constants.Rotors.I);
            settings.Rotors.Add(Constants.Rotors.II);
            settings.Rotors.Add(Constants.Rotors.III);

            settings.RotorPositions.Add(Constants.Alpha.G);
            settings.RotorPositions.Add(Constants.Alpha.A);
            settings.RotorPositions.Add(Constants.Alpha.A);

            settings.Rotors[0].Ringstellung = Constants.Alpha.S;
            settings.Rotors[1].Ringstellung = Constants.Alpha.B;
            settings.Rotors[2].Ringstellung = Constants.Alpha.C;

            settings.Reflector = Constants.Reflectors.B;

            IEnigmaMachine engimaMachine = new EnigmaMachineBase(settings);

            Assert.AreEqual<string>("Y", engimaMachine.EncryptDecrypt("A"));
            Assert.AreEqual<string>("F", engimaMachine.EncryptDecrypt("A"));
            Assert.AreEqual<string>("F", engimaMachine.EncryptDecrypt("A"));
            Assert.AreEqual<string>("X", engimaMachine.EncryptDecrypt("A"));
            Assert.AreEqual<string>("D", engimaMachine.EncryptDecrypt("A"));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void TestSetRingstellungTo2onRotorI()
        {
            IRotor rotorUnderTest = Constants.Rotors.I;

            rotorUnderTest.Ringstellung = Constants.Alpha.A;
            var mapping = rotorUnderTest.Mapping.Single(r => r.InputCharacter == "X");
            Assert.AreEqual<string>("R", mapping.OutputCharacter);

            rotorUnderTest.Ringstellung = Constants.Alpha.B;
            mapping = rotorUnderTest.Mapping.Single(r => r.InputPin == 1);
            Assert.AreEqual<string>("J", mapping.OutputCharacter);

            rotorUnderTest.Ringstellung = Constants.Alpha.F;
            mapping = rotorUnderTest.Mapping.Single(r => r.InputPin == 1);
            Assert.AreEqual<string>("I", mapping.OutputCharacter);
        }
    }
}