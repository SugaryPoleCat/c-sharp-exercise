using System;

namespace CSharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables.
            string characterName = "";
            int characterAge;
            characterAge = 35;

            // concat the string
            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            // if we want to change the name sudddenlly
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.WriteLine("press a key to continue to data types");

            // waits for iunput = pauses the console.
            Console.ReadLine();

            //Data types
            // String has "" while char has '' and ONLY handles 1 character.;
            string phrase = "Boku no goku";
            char poopster = 'P';
            // unsigned ints are ALWAYS positive.
            // just saying int, you ake it possile to be + or -
            // Ints are always 32 bit. Unsigned: 0 - 4294967295
            // signed : -2147483648 - 2147483647
            // BASICALLY, the way this works, is, signed min and max, if you plus them together ignoring the - in the min
            // you get teh max for unsigned.
            int degrees = -30;
            uint age = 20;
            // Long are 64 bits. They work the same like int
            // you can define these using etiher int64 or long.
            // signed: -9223372036854775808 - 9223372036854775807
            // unsigned: 0 - 18446744073709551615
            long bigNegNumber = -989;
            ulong bigPosNumber = 989;
            // short = int16
            // signed: -32768 - 32767 | unsigned: 0-65535
            short length = -23;
            ushort width = 23;
            // byte = int8
            // signed: -128 - 127 | unsigned: 0 - 255
            // almost never used in sbyte.
            byte idNumber = 230;
            sbyte negId = -100;

            // this is a hex;
            int hexLiteral = 0x2A;

            // floating point numeric types. Are retarded. No im joking!
            // theyre fine, but the problem with them is that they are NOT accurate 100%.
            // They are floating point afterall.
            // float: +- 1.5*10^-45 - +- 3.4*10^38, precision: ~6-9 digits, 4 bytes. using System.Single, must add 'f' at end.
            // double: +- 5.0*10^-324 - +- 1.7*10^308, precision: ~15-17 digits, 8 bytes, using System.Double
            // decimal: +- 1.0*10^-28 - +- 7.9228*10^28, precision: 28-29 digits, 16 bytes, using System.Decimal, must add 'm' at end.
            double gpa = 3.3;
            float myPoint = 3.2f;
            decimal someStuff = 9.9m;

            // true/false
            bool isMale = false;

            // constant values are not stored anywhere. So for example:
            // console.writeline(30);,  the 30 is a constant value. its just there.
        }
    }
}
