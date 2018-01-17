namespace Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Constants
    {
        /// <summary>
        /// Strongly typed version for tests only
        /// </summary>
        public static class Rotors
        {
            public static IRotor rotorStatic
            {
                get
                {
                    return new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "", null, null, null);
                }
            }
            public static IRotor I
            {
                get
                {
                    return new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "I", new List<string>() { "Y" }, new List<string>() { "Q" }, new List<string>() { "R" });
                }
            }
            public static IRotor II
            {
                get
                {
                    return new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "II", new List<string>() { "M" }, new List<string>() { "E" }, new List<string>() { "F" });
                }
            }
            public static IRotor III
            {
                get
                {
                    return new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "III", new List<string>() { "D" }, new List<string>() { "V" }, new List<string>() { "W" });
                }
            }
            public static IRotor IV
            {
                get
                {
                    return new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "IV", new List<string>() { "R" }, new List<string>() { "J" }, new List<string>() { "K" });
                }
            }
            public static IRotor V
            {
                get
                {
                    return new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "V", new List<string>() { "H" }, new List<string>() { "Z" }, new List<string>() { "A" });
                }
            }
            public static IRotor VI
            {
                get
                {
                    return new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "VI", new List<string>() { "H", "U" }, new List<string>() { "Z", "M" }, new List<string>() { "A", "N" });
                }
            }
            public static IRotor VII
            {
                get
                {
                    return new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "VII", new List<string>() { "H", "U" }, new List<string>() { "Z", "M" }, new List<string>() { "A", "N" });
                }
            }
            public static IRotor VIII
            {
                get
                {
                    return new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "VIII", new List<string>() { "H", "U" }, new List<string>() { "Z", "M" }, new List<string>() { "A", "N" });
                }
            }
            public static IRotor Beta
            {
                get
                {
                    return new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "Beta", null, null, null);
                }
            }
            public static IRotor Gamma
            {
                get
                {
                    return new Rotor("FSOKANUERHMBTIYCWLQPZXVGJD", "Gamma", null, null, null);
                }
            }
            public static IRotor Etw
            {
                get
                {
                    return new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ETW", null, null, null);
                }
            }
        }

        public static class Reflectors
        {
            public static IReflector A
            {
                get
                {
                    return new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD", "A");
                }
            }
            public static IReflector B
            {
                get
                {
                    return new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT", "B");
                }
            }
            public static IReflector C
            {
                get
                {
                    return new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL", "C");
                }
            }
            public static IReflector BThin
            {
                get
                {
                    return new Reflector("ENKQAUYWJICOPBLMDXZVFTHRGS", "B Thin");
                }
            }
            public static IReflector CThin
            {
                get
                {
                    return new Reflector("RDOBJNTKVEHMLFCWZAXGYIPSUQ", "C Thin");
                }
            }
        }

        public static class Alpha
        {
            public const int A = 1;
            public const int B = 2;
            public const int C = 3;
            public const int D = 4;
            public const int E = 5;
            public const int F = 6;
            public const int G = 7;
            public const int H = 8;
            public const int I = 9;
            public const int J = 10;
            public const int K = 11;
            public const int L = 12;
            public const int M = 13;
            public const int N = 14;
            public const int O = 15;
            public const int P = 16;
            public const int Q = 17;
            public const int R = 18;
            public const int S = 19;
            public const int T = 20;
            public const int U = 21;
            public const int V = 22;
            public const int W = 23;
            public const int X = 24;
            public const int Y = 25;
            public const int Z = 26;
        }
    }
}

