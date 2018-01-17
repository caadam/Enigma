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
    public class Extensions
    {
        public const string testMessage = "this is the test message to format";

        [TestInitialize]
        public void Initialize()
        {
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void SplitIntoCorrectGroupSize3()
        {
            string expectedFormattedMessage = "THI SIS THE TES TME SSA GET OFO RMA T--";
            string actualFormattedMessage = testMessage.ToEnigmaMessageFormat(3);

            Assert.AreEqual<string>(expectedFormattedMessage, actualFormattedMessage);
        }

        [TestMethod]
        public void SplitIntoCorrectGroupSize4()
        {
            string expectedFormattedMessage = "THIS ISTH ETES TMES SAGE TOFO RMAT";
            string actualFormattedMessage = testMessage.ToEnigmaMessageFormat(4);

            Assert.AreEqual<string>(expectedFormattedMessage, actualFormattedMessage);
        }

        [TestMethod]
        public void SplitIntoCorrectGroupSize5()
        {
            string expectedFormattedMessage = "THISI STHET ESTME SSAGE TOFOR MAT--";
            string actualFormattedMessage = testMessage.ToEnigmaMessageFormat(5);

            Assert.AreEqual<string>(expectedFormattedMessage, actualFormattedMessage);
        }

        // throw exception for invalid group size
        [TestMethod]
        [ExpectedException(typeof(InvalidEnigmaMessageFormationException))]

        public void ThrowExceptionForIncorrectSizes()
        {
            testMessage.ToEnigmaMessageFormat(2);
            testMessage.ToEnigmaMessageFormat(6);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void AddTrailingDashes()
        {
            string expectedFormattedMessage = "THISI STHET ESTME SSAGE TOFOR MAT--";
            string actualFormattedMessage = testMessage.ToEnigmaMessageFormat(5);

            Assert.IsTrue(actualFormattedMessage.EndsWith("--"));
        }

        [TestMethod]
        public void TestIntSteppingFrom1To26()
        {
            int rotorPosition = 1;

            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(2, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(3, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(4, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(5, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(6, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(7, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(8, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(9, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(10, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(11, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(12, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(13, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(14, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(15, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(16, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(17, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(18, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(19, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(20, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(21, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(22, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(23, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(24, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(25, rotorPosition);
            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(26, rotorPosition);
        }

        [TestMethod]
        public void TestIntSteppingFrom26To1()
        {
            int rotorPosition = 26;

            rotorPosition = rotorPosition.StepRotor();
            Assert.AreEqual<int>(1, rotorPosition);
        }

        [TestMethod]
        public void TestIntWrappingFrom35to9()
        {
            int rotorPosition = 35;
            int expectedPosition = 9;

            rotorPosition = rotorPosition.Wrap(26);
            Assert.AreEqual<int>(expectedPosition, rotorPosition);
        }

        [TestMethod]
        public void TestIntWrappingFrom34to8()
        {
            int rotorPosition = 34;
            int expectedPosition = 8;

            rotorPosition = rotorPosition.Wrap();
            Assert.AreEqual<int>(expectedPosition, rotorPosition);
        }

        [TestMethod]
        public void TestRotorAddition()
        {
            int rotor = 1;

            Assert.AreEqual<int>(1, rotor);

            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);
            rotor = rotor.RotorCircularAdd(1);

            Assert.AreEqual<int>(26, rotor);

            rotor = rotor.RotorCircularAdd(1);

            Assert.AreEqual<int>(1, rotor);
        }

        [TestMethod]
        public void TestRotorSubtraction()
        {
            int rotor = 26;

            Assert.AreEqual<int>(26, rotor);

            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);
            rotor = rotor.RotorCircularSubtract(1);

            Assert.AreEqual<int>(1, rotor);

            rotor = rotor.RotorCircularSubtract(1);

            Assert.AreEqual<int>(26, rotor);
        }
    }
}