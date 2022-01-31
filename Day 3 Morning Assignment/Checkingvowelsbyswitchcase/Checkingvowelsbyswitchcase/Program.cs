using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkingvowelsbyswitchcase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            char inputCharacter;

            //Read data from user

            Console.WriteLine("Enter any Character");
            inputCharacter = Convert.ToChar(Console.ReadLine());

            //Logic and Output

            switch(inputCharacter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Given character is a vowel");
                    break;
                    default:
                    Console.WriteLine("Invalid");
                    break;


            }
        }
    }
}
