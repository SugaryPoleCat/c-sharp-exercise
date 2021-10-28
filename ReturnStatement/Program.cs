using System;

namespace ReturnStatement
{
    class Program
    {
        /// <summary>
        /// this will take a NUM and make it CUBED. AKA num*num*num
        /// </summary>
        /// <param name="num">The INT number it takes in</param>
        /// <returns></returns>
        static int cube(int num)
        {
            // if your METHOD is returning soehting, it canb not be VOID.
            int result = num * num * num;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("the number to be cubed: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cube(num));

            // exercise: maybe let bitchboi sebastian, do the cube();
            // and then, user has to input the number to be cubed.
            // and hten of course print it out.
            Console.ReadLine();
        }
    }
}
